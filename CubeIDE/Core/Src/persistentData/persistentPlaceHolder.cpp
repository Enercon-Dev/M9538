// **********************************************************************
// **********************************************************************
// Copyright 2011 by Avi Owshanko. All rights reserved.
// **********************************************************************
// **********************************************************************

// Following file is used for reserving space for the persistent data.
// It can be done more cleanly if we edit the 'stm32f10x_flash.icf' file,
// but it's safer this way.

#include "persistentCommon.h"

// **********************************************************************
// **********************************************************************
// Copyright 2011 by Avi Owshanko. All rights reserved.
// **********************************************************************
// **********************************************************************

// Following file is used for reserving space for the persistent data.
// It can be done more cleanly if we edit the 'stm32f10x_flash.icf' file,
// but it's safer this way.

#include "persistentCommon.h"

//__no_init const char boolLoader[BOOT_LOADER_TOP - INT_VEC_TOP];
#ifdef __GNUC__
extern const char MagicNum[20] __attribute__((used, section(".magic_const"))) = PERSISTENT_MAGIC_NUM;

#endif


int readDummyFlash()
{
//  const char copyright[] = "Copyright 2011 by Avi Owshanko. All rights reserved.";
//  int i, retVal = 0;
//  for (i=0; i<sizeof(copyright); i++) {
//    retVal += copyright[i];
//  }
//  retVal += *(const int*)flashMemory;
//  for (i=0; i<sizeof(MagicNum); i++) {
//    retVal += MagicNum[i];
 // }

    
  return 0;
}
