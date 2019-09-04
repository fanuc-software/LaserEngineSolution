// CSD.cpp : 实现文件
//

#include "stdafx.h"
#include "FanucCncScreenDisplay.h"
#include "CSD.h"
#include "afxdialogex.h"


CCSD* CCSD::m_pInstance = NULL;

//volatile BOOL m_bRun;


// CCSD 对话框

IMPLEMENT_DYNAMIC(CCSD, CDialog)

CCSD::CCSD(CWnd* pParent /*=NULL*/)
	: CDialog(IDD_CSD, pParent)
{

}

CCSD::~CCSD()
{
}

CCSD* CCSD::GetInstance()
{
	if (NULL == m_pInstance)
	{
		m_pInstance = new CCSD();
	}
	else
	{
	}
	return m_pInstance;
}

void CCSD::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

void CCSD::Refresh()
{

	CStatic* st = (CStatic*)GetDlgItem(IDC_SCREEN);
	HDC dc = *st->GetDC();

	int ret = StretchDIBits(dc, XDest, YDest, nWidth, nHeight, XSrc, YSrc, dwWidth, dwHeight,
		(CONST VOID*)pdib->image, (LPBITMAPINFO)& pdib->bmi, DIB_RGB_COLORS, SRCCOPY);

	Sleep(20);

	::ReleaseDC(*st, dc);

}

void CCSD::SetIp(char* ip) {
	memset(m_ip, 0, sizeof(char) * 15);
	memcpy(m_ip, ip, strlen(ip));

	short ret = sdf_start_ether(m_ip, 8193, &flib, &pdib);
	//short ret = sdf_start_hssb(0, &flib, &pdib);
}

void CCSD::SetScreenPara(int xSrc, int ySrc, int xDest, int yDest, int nSrcWidth, int nSrcHeight, int nDestWidth, int nDestHeight)
{
	XSrc = xSrc;
	YSrc = ySrc;
	XDest = xDest;
	YDest = yDest;
	dwWidth = nSrcWidth;
	dwHeight = nSrcHeight;
	nWidth = nDestWidth;
	nHeight = nDestHeight;
}


void CCSD::SendKey(WORD state, WORD key)
{
	sdf_keyinput(flib, state, key);
}

BEGIN_MESSAGE_MAP(CCSD, CDialog)
	ON_WM_LBUTTONDOWN()
END_MESSAGE_MAP()

void CCSD::OnLButtonDown(UINT nFlags, CPoint point)
{
	//TODO: 在此添加消息处理程序代码和/或调用默认值

	double xpos = (double)point.x / (double)nWidth * (double)dwWidth;
	double ypos = (double)point.y / (double)nHeight * (double)dwHeight;

	sdf_mousepos(flib, 1, xpos, ypos);
	sdf_mousepos(flib, 0, xpos, ypos);

	CDialog::OnLButtonDown(nFlags, point);
}
