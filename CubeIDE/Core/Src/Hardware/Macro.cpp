#include "Macro.h"
#include "systemManagement.h"
#include "stm32Interface.h"

Macro_O::Macro_O(){
  pNext = NUM_OF_CBS;
  PendingMacro = 0;
}

ErrorStatus Macro_O::Start(MacroType macro){
  PendingMacro |= 1 << macro;
  return SUCCESS;
}

void Macro_O::periodicCall(){
  if (pNext < NUM_OF_CBS && NextOperationTime < getTimerTicks())
  {
    eventSetOutput(Channel[pNext],Operation[pNext]);
    pNext++;
    NextOperationTime += Delay[pNext];
    if (Channel[pNext] == 0)
      pNext = NUM_OF_CBS;
  }
  if (!PendingMacro)
    return;
  if (pNext == NUM_OF_CBS)
  {
    ErrorStatus rc = ERROR;
    if (PendingMacro & 0x01)
    {
      rc = SystemManagement::getPersistentDataCenter().Get_PorSetting(Channel,Delay);
      for (int i=0; i<NUM_OF_CBS; ++i)
        Operation[i] = 1;
      PendingMacro &= (~0x01);                       
    }
    else if(PendingMacro & 0x02){
      rc = SystemManagement::getPersistentDataCenter().Get_DCISetting(Channel,Operation,Delay);
      PendingMacro &= (~0x02);
    }
    if (rc == SUCCESS)
    {
      pNext = 0;
      NextOperationTime = getTimerTicks() + Delay[pNext];
      if (Channel[pNext] == 0)
        pNext = NUM_OF_CBS;
    }
  }
}


