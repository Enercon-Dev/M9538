..\..\..\Scripts\srec_cat.exe M9538.bin -binary -CRC16_Little_Endian -maximum-addr M9538.bin -binary -POLY ccitt -XMODEM -o M9538_crc.bin -binary
..\..\..\Scripts\srec_cat.exe M9538.hex -intel -offset -0x08000000 ..\..\BootLoader\CUBEIDE\Debug\BootLoader.hex -intel -offset -0x08000000 --fill 0xFF 0x00000000 0x00002000 -o M9538_boot.bin -binary



