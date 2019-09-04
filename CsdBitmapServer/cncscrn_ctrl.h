/*-------------------------------------------------------------------*/
/* cncsrn_ctrl.h                                                     */
/*                                                                   */
/* Bitmap server function for CNC screen display function            */
/*                                                                   */
/* Copyright (C) 2012- by FANUC CORPORATION All rights reserved.     */
/*                                                                   */
/*-------------------------------------------------------------------*/

#ifndef _INC_SDFCTRL
#define _INC_SDFCTRL

#include <windows.h>

#ifdef __cplusplus
extern "C" {
#endif

#if !defined(_SDFCTRLDLL_)
#define SDFCTRLAPI __declspec(dllimport)
#else
#define SDFCTRLAPI __declspec(dllexport)
#endif

#define NUMCOLOR	256

/* Device Independent Bitmap */
typedef struct {
	BITMAPINFOHEADER	bmi;
	RGBQUAD				colortbl[NUMCOLOR];
	UCHAR				image[1];
} DIB;

SDFCTRLAPI short WINAPI sdf_start_hssb(long node_num, unsigned short *Hndl, DIB **pdib);
SDFCTRLAPI short WINAPI sdf_start_ether(const char *ipaddr, unsigned short port, unsigned short *Hndl, DIB **pdib);
SDFCTRLAPI short WINAPI sdf_stop(unsigned short Hndl);
SDFCTRLAPI short WINAPI sdf_refresh(unsigned short Hndl, HDC dc, int XSrc, int YSrc, int XDest, int YDest, DWORD dwWidth, DWORD dwHeight);
SDFCTRLAPI short WINAPI sdf_register(unsigned short Hndl, HWND hWnd, UINT nUpdateMsg);
SDFCTRLAPI short WINAPI sdf_keyinput(unsigned short Hndl, WORD flag, WORD code);
SDFCTRLAPI short WINAPI sdf_mousepos(unsigned short Hndl, WORD flag, short px, short py);
SDFCTRLAPI short WINAPI sdf_input(unsigned short Hndl, UINT msg, WPARAM wparam, LPARAM lparam);
SDFCTRLAPI short WINAPI sdf_activate(unsigned short Hndl, BOOL fFocus);

#ifdef __cplusplus
}
#endif

#endif  /* _INC_SDFCTRL */
