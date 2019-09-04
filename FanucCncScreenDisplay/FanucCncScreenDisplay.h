// FanucCncScreenDisplay.h : FanucCncScreenDisplay DLL 的主头文件
//

#pragma once

#ifndef __AFXWIN_H__
#error "在包含此文件之前包含“stdafx.h”以生成 PCH 文件"
#endif

#include "resource.h"		// 主符号

extern "C" _declspec(dllexport) void WINAPI _CreateCncScreenDisplay(HWND hWnd, char* ip,
	int xSrc, int ySrc, int xDest, int yDest, int nSrcWidth, int nSrcHeight, int nDestWidth, int nDestHeight);

extern "C" _declspec(dllexport) void WINAPI _StartRefresh(void);

extern "C" _declspec(dllexport) void WINAPI _StopRefresh(void);

extern "C" _declspec(dllexport) void WINAPI _SendKey(WORD state, WORD key);


// CFanucCncScreenDisplayApp
// 有关此类实现的信息，请参阅 FanucCncScreenDisplay.cpp
//

class CFanucCncScreenDisplayApp : public CWinApp
{
public:
	CFanucCncScreenDisplayApp();

	// 重写
public:
	virtual BOOL InitInstance();


private:


	DECLARE_MESSAGE_MAP()
};
