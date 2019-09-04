#pragma once
#include "cncscrn_ctrl.h"


// CCSD 对话框

class CCSD : public CDialog
{
	DECLARE_DYNAMIC(CCSD)

public:
	CCSD(CWnd* pParent = NULL);   // 标准构造函数
	virtual ~CCSD();

public:
	static CCSD* GetInstance();
	void Refresh();
	void SendKey(WORD state, WORD key);
	void SetIp(char* ip);
	void SetScreenPara(int xSrc, int ySrc, int xDest, int yDest, int nSrcWidth, int nSrcHeight, int nDestWidth, int nDestHeight);


private:

	// Copy constructor
	CCSD(const CCSD&);

	// "=" operator
	const CCSD& operator = (const CCSD);


private:
	static CCSD* m_pInstance;

	char m_ip[20];

	unsigned short flib;
	int XSrc = 0;
	int YSrc = 0;
	int XDest = -5;
	int YDest = -32;
	long dwWidth = 640;
	long dwHeight = 480;
	long nWidth = 640;
	long nHeight = 480;
	DIB* pdib;

	time_t lase_time;

	// 对话框数据
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_CSD };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

	//DECLARE_MESSAGE_MAP()
public:
	DECLARE_MESSAGE_MAP()
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	//afx_msg void OnBnClickedButton1();
};
