#pragma once
#include <OAIdl.h>
#include "Fwlib32.h"

extern "C" __declspec(dllexport)	short   GetProgramDir(PRGDIR2 * res, short *prgTotalNum, unsigned short flib);

extern "C" __declspec(dllexport)	short   DownLoadNcProgramFromPcToCnc(char* pcFilePath, char* ncFilePath, unsigned short flib);


extern "C" __declspec(dllexport)	short   UpLoadNcProgramFromCncToPc(char* pcFilePath, char* ncFilePath, unsigned short flib);

extern "C" __declspec(dllexport)	short   DeleteProgram(char* prgName, unsigned short flib);

extern "C" __declspec(dllexport)	short   DeleteProgramFile(char* path, unsigned short flib);
