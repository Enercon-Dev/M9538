// **********************************************************************
// **********************************************************************
// Copyright 2011 by Avi Owshanko. All rights reserved.
// **********************************************************************
// **********************************************************************

#ifndef PERSISTENT_SYSTEM_DATA_H
#define PERSISTENT_SYSTEM_DATA_H

#include "persistentCommon.h"
#include "handlers/handlersCommon.h"
#include "eeprom.h"
#include "buffers/buffers.h"
#include "ethernet/mac.h"

#define SYSTEM_DATA_BASE_ADDRESS 0

#pragma pack(push)
#pragma pack(1)
typedef struct {
  IpSettings_t IP_Settings{0x3300A8C0, 0x00FFFFFF, 1};  // 9B
  CommLoss_t   CommLoss{1000, 0, 0};                    // 4B
#if (DASH_NUMBER == 100)
  Raw_Config_t ChannelConfig[8] = {                     // 7B * 8 = 56B
    {(uint16_t)(25*16), 125*16, 1000, 255},
    {25*16  , 125*16 , 1000, 255  },
    {25*16  , 125*16, 1000, 255},
    {(uint16_t)(15*16), 80*16, 1000, 255  },
    {15*16  , 80*16 , 1000, 255},
    {15*16  , 80*16 , 1000, 255},
    {15*16  , 80*16 , 1000, 255},
    {15*16  , 80*16 , 1000, 255},
  };
#elif (DASH_NUMBER == 101)
  Raw_Config_t ChannelConfig[8] = {                     // 7B * 8 = 56B
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255}
  };

#elif (DASH_NUMBER == 102)
  Raw_Config_t ChannelConfig[8] = {                     // 7B * 8 = 56B
    {(uint16_t)(30*16), 125*16, 1000, 255},
    {(uint16_t)(30*16), 125*16, 1000, 255},
    {(uint16_t)(10*16), 50*16, 1000, 255},
    {(uint16_t)(10*16), 50*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255},
    {(uint16_t)(5*16), 25*16, 1000, 255}
  };
#elif (DASH_NUMBER == 803)
  Raw_Config_t ChannelConfig[8] = {                     // 7B * 8 = 56B
    {(uint16_t)(25*16), 125*16, 1000, 255},
    {25*16  , 125*16 , 1000, 255  },
    {25*16  , 125*16, 1000, 255},
    {(uint16_t)(15*16), 80*16, 1000, 255  },
    {15*16  , 80*16 , 1000, 255},
    {15*16  , 80*16 , 1000, 255},
    {15*16  , 80*16 , 1000, 255},
    {5 *16  , 25*16 , 1000, 255}
  };
#endif
  Por_Order_t Por_Order[8] = {                          // 3B * 8 = 24B
    {0, 0}, 
    {0, 0}, 
    {0, 0}, 
    {0, 0}, 
    {0, 0}, 
    {0, 0}, 
    {0, 0}, 
    {0, 0}, 
 };
  DCI_Order_t Dci_Order[8] = {                          // 4B * 8 = 32B
    {0,0,0},
    {0,0,0},
    {0,0,0},
    {0,0,0},
    {0,0,0},
    {0,0,0},
    {0,0,0},
    {0,0,0},
  };
                                                        // SUB TOTAL = 125B
  char magicNumber[20] = PERSISTENT_MAGIC_NUM;          // 20B
} SystemSettings_t;                                     // TOTAL = 145B
#pragma pack(pop)


// **************************************************************
// The Serial persistent object
// **************************************************************
class PersistentSystemData
{
public:
  PersistentSystemData();
  ErrorStatus CheckMemory();
  ErrorStatus Initialize();
  //ErrorStatus FullBufferWrite(Buffer& DataIn);
  //ErrorStatus FullBufferRead(Buffer& DataOut);
  
  //Network Settings
   ErrorStatus Get_IpSetting(IpSettings_t &ip);
   ErrorStatus Set_IpSetting(uint8_t Mode, uint32_t Ip, uint32_t Mask);
   ErrorStatus Set_CommLossSetting(uint16_t Timeout, uint8_t Channels, uint8_t Mask);
   ErrorStatus Get_CommLossSetting(uint16_t *Timeout, uint8_t *Channels, uint8_t *Mask);
  
  //CB settings
   ErrorStatus Get_CBSetting(int CbNum, Raw_Config_t* pData);
   ErrorStatus Set_CBSetting(int CbNum, const Raw_Config_t* pData);
  
  //Hardware settings
   ErrorStatus Get_PorSetting(uint8_t *OrderSetting, uint16_t *DelaySetting); 
   ErrorStatus Set_PorSetting(const uint8_t *OrderSetting, const uint16_t *DelaySetting); 
   ErrorStatus Get_DCISetting(uint8_t *OrderSetting, uint8_t *ActionSetting, uint16_t *DelaySetting); 
   ErrorStatus Set_DCISetting(const uint8_t *OrderSetting, const uint8_t *ActionSetting, const uint16_t *DelaySetting); 
  
  void handleGetConfig(Buffer& DataOut);
  
  EEprom&      GetMemory(void);
private:
  ErrorStatus UpdateMemory(const SystemSettings_t* nSystemSettings);
  EEprom      Memory;
  ErrorStatus MemoryOk;

};








#endif // PERSISTENT_SYSTEM_DATA_H
