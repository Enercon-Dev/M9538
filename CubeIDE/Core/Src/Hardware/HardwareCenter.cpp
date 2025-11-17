#include "HardwareCenter.h"
#include "stm32Interface.h"
#include "systemManagement.h"


HardwareCenter* HardwareCenter::mSingelton = NULL;



HardwareCenter::HardwareCenter():DebugFlag(0), CommStat(0), OverTemp(FunctionalState::ENABLE), TempWarning(FunctionalState::DISABLE), state(0), IOs(GPIO::GetInstance()) ,ADC(ADC_DRV::Get_Instance())
{
  for (int i=0 ; i<NUM_OF_CBS; i++)
    mOutOnTime[i] = 0;
  
}


void HardwareCenter::periodicCall(){
  
	if(DebugFlag == 1)
		return;

  int16_t Temp = ADC.Get_ADC_Specific_Input_Data(ADC_Inputs_Enum::ADC_In_Temp);
  OverTemp = ( Temp > (ADC_TEMP_SHUTDOWN*16) || ( Temp > (ADC_TEMP_SHUTDOWN-10)*16 && OverTemp )) ? FunctionalState::ENABLE : FunctionalState::DISABLE;
  TempWarning = ( Temp > ADC_TEMP_WARNING*16 || ( Temp > (ADC_TEMP_WARNING-5)*16 && TempWarning )) ? FunctionalState::ENABLE : FunctionalState::DISABLE;
  
  IOs.periodicCall();
  GPIO_Inputs ins = IOs.Get_GPIO_Inputs();
  CB_Int::shutdown_CBs(ins.SHDN ? FunctionalState::ENABLE : FunctionalState::DISABLE);
  if (ins.SHDN_H2L_Flag)
  {
    Macro.Start(MacroType::POR);
  }
  if (ins.DCI_L2H_Flag)
  {
    Macro.Start(MacroType::DCI);
  }
  Macro.periodicCall();

  CB_Int::Hold = OverTemp;
  CB_Int::periodicCall(ADC.Get_ADC_Specific_Input_Data(ADC_Inputs_Enum::ADC_In_Vin_Sense));  
  
  Status_Msg_T Status;
  GetStatus(Status);
  if (ins.RAT_L2H_Flag)
  {
    for (int i=0; i< NUM_OF_CBS; ++i)
      if (Status.TRIP_STAT[i])
        CB_Int::Select(i)->Power(FunctionalState::DISABLE);
  }
    
  return;
}

ErrorStatus HardwareCenter::GetStatus(Status_Msg_T& Status)
{
  /* Initializations */
  Status.INPUT_CURR = 0;
  Status.SW_STATE = CB_Int::HandleGetStatusSWState();
  Status.SW_CMD   = CB_Int::HandleGetStatusSWCmd();
  CB_Int::HandleGetStatusTripStat(Status.TRIP_STAT);  
  Status.BTL_MODE = CB_Int::HandleGetStatusBtlMode();
  CB_Int::HandleGetStatusOutVolt(Status.OUT_VOLT);
  CB_Int::HandleGetStatusOutCurr(Status.OUT_CURR);
  for (int i = 0; i < NUM_OF_CBS; ++i)
    Status.CHANNEL_GROUP[i] = CB_Int::getGroupOfSpecificCB(i);
  Status.INPUT_VOLT = ADC.Get_ADC_Specific_Input_Data(ADC_Inputs_Enum::ADC_In_Vin_Sense);
  for(int i = 0; i < NUM_OF_CBS; ++i)
    Status.INPUT_CURR += (Status.OUT_CURR[i]);
  Status.TEMP = ADC.Get_ADC_Specific_Input_Data(ADC_Inputs_Enum::ADC_In_Temp); 


  
  Status.BIT = 0;
  for (int i=0; i < NUM_OF_CBS ; i++)
  {
    if (LastStatus.SW_STATE != Status.SW_STATE)
      mOutOnTime[i] = getTimerTicks() + 500;
    if ( getTimerTicks() < mOutOnTime[i])
      continue;        
    /* different checks to see if switch is On */
    uint8_t A = (Status.SW_STATE >> i) & 0x01; 
    uint8_t B = (Status.INPUT_VOLT - Status.OUT_VOLT[i]) < (1.5*16); 
    uint8_t C = Status.OUT_CURR[i] > (0.5*16);  
    uint8_t D = Status.OUT_VOLT[i] > (5*16); 
    Status.BIT |= ( !(A||B||C||D) || (A&&B&&D)) ? 0 : 1<<i;
  }     
  
  Status.ERROR_STAT = 0;
  for (int i=0; i< NUM_OF_CBS; i++){
    Status.ERROR_STAT |= Status.TRIP_STAT[i] ? 0x01 : 0 ;
  }
  Status.ERROR_STAT |= Status.BIT ? 0x02 : 0;
  Status.ERROR_STAT |= (TempWarning) ? 0x04 : 0;
  
  for (int i=0; i<NUM_OF_CBS; i++)
  {
    StatusAlert.TRIP_STAT[i] = Status.TRIP_STAT[i] & (~LastStatus.TRIP_STAT[i]);
  }
  StatusAlert.ERROR_STAT = Status.ERROR_STAT & (~LastStatus.ERROR_STAT);
  StatusAlert.BIT = Status.BIT & (~LastStatus.BIT);
  
  
  for (int i=0; i<sizeof(StatusAlert); i++)
    *(((uint8_t *)(&LastStatus))+i) = *(((uint8_t *)(&Status))+i);
  
  IOs.SetFault((Status.ERROR_STAT & 0x01) ? FunctionalState::ENABLE : FunctionalState::DISABLE);
  
  return ErrorStatus::SUCCESS;
}

FlagStatus HardwareCenter::GetAlert() const
{
  for (int i=0; i<sizeof(StatusAlert); i++)
    if (*((uint8_t *)(&StatusAlert)+i) != 0)
      return SET;
  return FlagStatus::RESET;
}
void HardwareCenter::AlertAcknoledge(){
  for (int i=0; i<sizeof(StatusAlert); i++)
    *((uint8_t *)(&StatusAlert)+i) = 0;
  
}

void HardwareCenter::handleSetOutput(uint8_t output, uint8_t operation){
  uint8_t  group_flag = 0;  
  if(IsValidOutputNumber(output) == NACK) 
    return ;
  if(output > 128)
  {
    output -= 128;
    group_flag = 1;
  }
  CB_En_t val = operation ? CB_CONTROL_EN : CB_CONTROL_DIS;
  if(group_flag)
    CB_Int::Select(output)->HandleSetGroupOutput(val);
  else
    CB_Int::SelectOutput(output)->HandleSetSingleOutput(val);
  
}

COMMAND_SUCCESS HardwareCenter::handleSetOutput(Buffer& DataIn){
  if (DataIn.readShort() != 5)
    return NACK;
  uint8_t Output = DataIn.readChar();
  uint8_t Value = DataIn.readChar();
  handleSetOutput(Output,Value);  
  return ACK;
}

COMMAND_SUCCESS HardwareCenter::handleSetBattle(Buffer& DataIn){
  if (DataIn.readShort() != 5)
    return NACK;
  uint8_t Output = DataIn.readChar();
  uint8_t Value = DataIn.readChar() == 1 ? 0xD : 0x0;
  uint8_t  group_flag = 0;
  if(IsValidOutputNumber(Output) == NACK) 
    return NACK;
  if(Output > 128)
  {
    Output -= 128;
    group_flag = 1;
  }
  
  if(group_flag)
    CB_Int::Select(Output)->HandleSetGroupBattle(Value);
  else
    CB_Int::SelectOutput(Output)->HandleSetSingleBattle(Value);
  
  return ACK;
}

COMMAND_SUCCESS HardwareCenter::handleTripRest(Buffer& DataIn)
{
  if (DataIn.readShort() != 4)
    return NACK;
  uint16_t Output = DataIn.readChar();
  uint8_t  group_flag = 0;
  if(IsValidOutputNumber(Output) == NACK) 
    return NACK;
  if(Output > 128)
  {
    Output -= 128;
    group_flag = 1;
  }
  if(group_flag)
    CB_Int::Select(Output)->HandleGroupTripReset();
  else
    CB_Int::SelectOutput(Output)->HandleSingleTripReset();
  
  return ACK;
}

COMMAND_SUCCESS HardwareCenter::handleSetLimit(Buffer& DataIn){
  int rc = ACK;  
  uint8_t group_flag = 0;
  if (DataIn.readShort() != 10)
  {
    return NACK;
  }
  else
  {
    uint8_t Output = DataIn.readChar();
    uint16_t Overload = DataIn.readShort();
    uint16_t CurrLimit = DataIn.readShort();
    uint16_t ThrmConst = DataIn.readShort();
    if(IsValidOutputNumber(Output) == NACK) 
      return NACK;
    if(Output > 128)
    {
      Output -= 128;
      group_flag = 1;
    }
    if(group_flag)
      rc |= CB_Int::Select(Output)->HandleSetGroupLimits(ThrmConst, Overload, CurrLimit) == SUCCESS ? ACK : EEPROM_ERROR;
    else
      rc |= CB_Int::SelectOutput(Output)->HandleSetSingleLimits(ThrmConst, Overload, CurrLimit) == SUCCESS ? ACK : EEPROM_ERROR;
    
  }
  return (COMMAND_SUCCESS)(rc ? EEPROM_ERROR : ACK);
}

COMMAND_SUCCESS HardwareCenter::handleSetGroup(Buffer& DataIn){
  if (DataIn.readShort() != NUM_OF_CBS +4)
  {
    return NACK;
  }
  else
  {
    uint8_t Group = DataIn.readChar();
    if (Group <1 || Group >8)
      return NACK;
    uint8_t ChannelMask[NUM_OF_CBS];
    for (int i=0; i<NUM_OF_CBS; ++i)
        ChannelMask[i] = 0;
    for (int i=0; i<NUM_OF_CBS; ++i){
      uint8_t Chan = DataIn.readChar();
      if (Chan == 0)
        break;
      for (int k=0; k<NUM_OF_CBS; ++k)
        if (IndexToCB[k] == Chan)
          ChannelMask[k] = 1;
    }
    return (COMMAND_SUCCESS) (CB_Int::handleSetGroup(Group,ChannelMask) == SUCCESS) ? ACK : EEPROM_ERROR; 
  }
}

void HardwareCenter::handelGetOutsTemp(Buffer& DataOut)
{
  for (int i=0; i< NUM_OF_CBS ; ++i)
    DataOut.writeShort( CB_Int::Select(i)->Get_CB_Temperature());
}

void ChangeOutputWrapper(uint8_t output, uint8_t operation){
  HardwareCenter::GetInstance().handleSetOutput(output, operation);
}

/* This function gets an integer and determine whether it could be considered as a legal output (1-8) or group (129-136) number */
COMMAND_SUCCESS HardwareCenter::IsValidOutputNumber(uint8_t group)
{
  COMMAND_SUCCESS is_legal_input = NACK;
  if(group <= 136) /* 136 is the maximum viable value, represents group 8 */
  {
    if(group > 8) /* output is given in the form of a group */
      group -= 128;
    if(group >= 1 && group <= 8) /* possible groups are 1-8 */
      is_legal_input = ACK;
  }
  return is_legal_input;
}

ErrorStatus HardwareCenter::DebugShutdown(FunctionalState val)
{
	 for (int i=0; i< NUM_OF_CBS; ++i)
	        CB_Int::Select(i)->Power(FunctionalState::DISABLE);
}

ErrorStatus HardwareCenter::WriteToCB(uint8_t index, FunctionalState val)
{
    CB_Int::Select(index)->Power(val);
}
