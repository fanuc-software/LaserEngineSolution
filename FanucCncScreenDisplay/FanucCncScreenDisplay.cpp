// FanucCncScreenDisplay.cpp : 定义 DLL 的初始化例程。
//

#include "stdafx.h"
#include "FanucCncScreenDisplay.h"
#include "CSD.h"
#include "cncscrn_ctrl.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//
//TODO:  如果此 DLL 相对于 MFC DLL 是动态链接的，
//		则从此 DLL 导出的任何调入
//		MFC 的函数必须将 AFX_MANAGE_STATE 宏添加到
//		该函数的最前面。
//
//		例如: 
//
//		extern "C" BOOL PASCAL EXPORT ExportedFunction()
//		{
//			AFX_MANAGE_STATE(AfxGetStaticModuleState());
//			// 此处为普通函数体
//		}
//
//		此宏先于任何 MFC 调用
//		出现在每个函数中十分重要。  这意味着
//		它必须作为函数中的第一个语句
//		出现，甚至先于所有对象变量声明，
//		这是因为它们的构造函数可能生成 MFC
//		DLL 调用。
//
//		有关其他详细信息，
//		请参阅 MFC 技术说明 33 和 58。
//

// CFanucCncScreenDisplayApp

BEGIN_MESSAGE_MAP(CFanucCncScreenDisplayApp, CWinApp)
END_MESSAGE_MAP()


// CFanucCncScreenDisplayApp 构造

CFanucCncScreenDisplayApp::CFanucCncScreenDisplayApp()
{
	// TODO:  在此处添加构造代码，
	// 将所有重要的初始化放置在 InitInstance 中
}


// 唯一的一个 CFanucCncScreenDisplayApp 对象

CFanucCncScreenDisplayApp theApp;
volatile BOOL m_bRun;
HWND m_hWnd;

HANDLE hThread;
DWORD ThreadID;


// CFanucCncScreenDisplayApp 初始化

BOOL CFanucCncScreenDisplayApp::InitInstance()
{
	CWinApp::InitInstance();

	return TRUE;
}

void WINAPI _CreateCncScreenDisplay(HWND hWnd, char* ip,
	int xSrc, int ySrc, int xDest, int yDest, int nSrcWidth, int nSrcHeight, int nDestWidth, int nDestHeight)
{
	m_hWnd = hWnd;

	CCSD* pMyDlg = CCSD::GetInstance();
	pMyDlg->DestroyWindow();
	//memset(pMyDlg->ip, 0, sizeof(char) * 15);
	//memcpy(pMyDlg->ip, ip, strlen(ip));
	pMyDlg->Create(IDD_CSD, CWnd::FromHandle(m_hWnd));
	pMyDlg->ShowWindow(SW_NORMAL);
	pMyDlg->SetIp(ip);

	pMyDlg->SetScreenPara(xSrc, ySrc, xDest, yDest, nSrcWidth, nSrcHeight, nDestWidth, nDestHeight);

}

void ThreadFunc()
{
	m_bRun = TRUE;
	while (m_bRun)
	{
		CCSD* pMyDlg = CCSD::GetInstance();
		pMyDlg->Refresh();

	}

}

void WINAPI _StartRefresh()
{

	hThread = CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)ThreadFunc, NULL, 0, &ThreadID);
}

void WINAPI _StopRefresh()
{
	//CCSD *pMyDlg = CCSD::GetInstance();
	//pMyDlg->StopRefresh();

	m_bRun = false;

	//CCSD *pMyDlg = CCSD::GetInstance();
	//pMyDlg->DestroyWindow();
}

void WINAPI _SendKey(WORD state, WORD key)
{
	CCSD* pMyDlg = CCSD::GetInstance();

	pMyDlg->SendKey(state, key);
}
