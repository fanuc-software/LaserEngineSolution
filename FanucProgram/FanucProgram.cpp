// FanucProgram.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "FanucProgram.h"
#include <stdio.h>
#include <malloc.h>
#include <cmath>
#include <stdlib.h>
#include <string>
#include <math.h>

/// <summary>
/// 获得CNC中的程序列表
/// </summary>
/// <param name="prgName">程序名称列表</param>OUTPUT:1000; NOT:O1000, char[256]
/// <param name="prgTotalNum">列表中元素的数量</param>
/// <returns>执行结果：0-正常执行结束 
///                 -16-通讯失败
///                 100-没有该功能
///                 101-其他错误</returns>
extern "C" __declspec(dllexport)	short   GetProgramDir(PRGDIR2 * res, short *prgTotalNum, unsigned short flib)
{

#pragma region Get Dir
	short ret;
	short top = 0;
	short tnum = *prgTotalNum;

	do {

		ret = cnc_rdprogdir2(flib, 1, &top, prgTotalNum, res);
		if (ret == EW_NUMBER) {
			break;
		}
		if (ret) {
			break;
		}
		top = res[*prgTotalNum - 1].number + 1;
	} while (*prgTotalNum >= tnum);

#pragma endregion Get Dir

#pragma region Return Value
	if (ret == -16) return ret;
	if (ret == 1) return 100;
	if (ret == 0) return ret;
	return 101;
#pragma endregion Return Value
}

/// <summary>
/// 从PC下载程序至CNC中
/// </summary>
/// <param name="pcFilePath">PC中的地址</param>
/// <param name="ncFilePath">NC中保存的地址</param>INPUT: //CNC_MEM/USER/PATH1/
/// <returns>执行结果：0-正常执行结束 
///                 -16-通讯失败 
///                 -100-CNC中的内存不足，下载失败 
///                 -101-当前程序号已经存在，下载失败
///                 -102-当前程序号为主程序，下载失败
///					-103-程序数量达到极限
///					-104-传输时执行了复位或者停止操作
///					-105-程序读写保护 O8000+、O9000+程序
///					-106-程序中有非法字符
///					-107-程序格式错误 'LF'数量和参数设定不符
///                 100-没有该功能
///                 101-其他错误</returns>
extern "C" __declspec(dllexport)	short   DownLoadNcProgramFromPcToCnc(char* pcFilePath, char* ncFilePath, unsigned short flib)
{

#pragma region  Read PC File To BUFFER
	short ret;

	char *pchBuf = NULL;
	char *prg = NULL;
	int  nLen = 0;
	FILE *pF;
	fopen_s(&pF, pcFilePath, "r"); //打开文件 
	fseek(pF, 0, SEEK_END); //文件指针移到文件尾 
	nLen = ftell(pF);  //得到当前指针位置, 即是文件的长度 
	rewind(pF);    //文件指针恢复到文件头位置 

				   //动态申请空间, 为保存字符串结尾标志\0, 多申请一个字符的空间 
	pchBuf = (char*)malloc(sizeof(char)*nLen + 1);
	if (!pchBuf)
	{
		perror("内存不够!\n");
	}
	//读取文件内容//读取的长度和源文件长度有可能有出入，这里自动调整 nLen 
	nLen = fread(pchBuf, sizeof(char), nLen, pF);
	pchBuf[nLen] = '\0'; //添加字符串结尾标志 
	prg = pchBuf;
	fclose(pF);  //关闭文件
#pragma endregion Read PC File To BUFFER

#pragma region DownLoad To CNC

	long len, n;

	ret = cnc_dwnstart4(flib, 0, ncFilePath);//开始传输
	if (ret)
	{
		if (pchBuf) { free(pchBuf); pchBuf = NULL; }
		if (ret == -16) return ret;
		return 101;
	}

	len = strlen(prg);
	while (len > 0) {
		n = len;
		ret = cnc_download4(flib, &n, prg);
		if (ret == EW_BUFFER) {
			continue;
		}
		if (ret == EW_OK) {
			prg += n;
			len -= n;
		}
		if (ret != EW_OK) {
			break;
		}
	}

	ret = cnc_dwnend4(flib);//结束传输

#pragma endregion DownLoad To CNC

#pragma region FREE BUFFER
	if (pchBuf)
	{
		free(pchBuf); //释放空间
	}
#pragma endregion FREE BUFFER

#pragma region Return Value
	if (ret == 5)
	{
		ODBERR ob;
		cnc_getdtailerr(flib, &ob);

		if (ob.err_dtno == 4)//同样的程序已经存在
			return -101;
		if (ob.err_dtno == 5)//当前程序号被选择为主程序
			return -102;
		if (ob.err_dtno == 3)//程序数量达到极限
			return -103;
		if (ob.err_dtno == 1)//程序中有非法字符
			return -106;
		if (ob.err_dtno == 2)//程序格式错误
			return -107;
		return 101;
	}

	if (ret == -2)	return -104;
	if (ret == 8)	return -100;
	if (ret == -16) return ret;
	if (ret == 0) return ret;
	return 101;
#pragma endregion Return Value
}

/// <summary>
/// 从CNC上传程序至PC中
/// </summary>
/// <param name="ncFilePath">待上传的CNC程序地址</param>INPUT://CNC_MEM/USER/PATH1/O1234;OR:O1234;OR://CNC_MEM/USER/PATH1/
/// <param name="pcFilePath">PC中的保存地址</param>INPUT:
/// <returns>执行结果：0-正常执行结束 
///                 -16-通讯失败 
///                 -101-当前PC中文件已经存在，上传失败
///                 -102-待上传的程序不存在或者程序名错误
///					-104-传输时执行了复位或者停止操作
///					-105-程序读写保护 O8000+、O9000+程序
///                 100-没有该功能
///                 101-其他错误</returns>
extern "C" __declspec(dllexport)	short   UpLoadNcProgramFromCncToPc(char* pcFilePath, char* ncFilePath, unsigned short flib)
{

#pragma region Creat PC File
	FILE *pFile;
	fopen_s(&pFile, pcFilePath, "w");
#pragma endregion Creat PC File

#pragma region  Upload

	short ret;
	char buf[1024 + 1];
	long len;

	ret = cnc_upstart4(flib, 0, ncFilePath);
	if (ret)
	{
		fclose(pFile);
		if (ret == 5) return -102;
		if (ret == -16) return ret;
		return 101;
	}

	do {
		len = 1024;
		ret = cnc_upload4(flib, &len, buf);

		if (ret == EW_BUFFER)
		{
			continue;
		}
		if (ret == EW_OK)
		{
			buf[len] = '\0';
			//例子是打印,实际是存储//printf( "%s", buf ) ;
			{
				if (pFile)
				{
					//int i=sizeof(buf);
					fwrite(buf, len, 1, pFile);
				}

			}
		}
		if (buf[len - 1] == '%') {
			break;
		}
	} while (true);
	ret = cnc_upend3(flib);
	fclose(pFile);

#pragma endregion  Upload

#pragma region Return Value
	if (ret == -2) return -104;
	if (ret == 7) return -105;
	if (ret == -16) return ret;
	if (ret == 0) return ret;
	return 101;
#pragma endregion Return Value
}

/// <summary>
/// 从CNC中删除程序
/// </summary>
/// <param name="prgName">程序名称</param> INPUT: 1000; NOT INPUT :O1000
/// <returns>执行结果：0-正常执行结束 
///                 -16-通讯失败
///                 -101-当前程序为主程序，不能删除
///                 100-没有该功能
///                 101-其他错误</returns>
extern "C" __declspec(dllexport)	short   DeleteProgram(char* prgName, unsigned short flib)
{
	short ret;

	short pnum = (short)atoi(prgName + 1);
	ODBPRO prgnum;
	ret = cnc_rdprgnum(flib, &prgnum);
	if (ret == -16) return ret;
	if (ret != 0)return 101;
	if (prgnum.mdata == pnum)return -101;

	ret = cnc_delete(flib, pnum);

#pragma region Return Value
	if (ret == -16)return ret;
	if (ret == 0) return ret;
	return 101;
#pragma endregion Return Value
}

/// <summary>
/// 从CNC中删除程序
/// </summary>
/// <param name="prgName">程序名称</param> INPUT: 1000; NOT INPUT :O1000
/// <returns>执行结果：0-正常执行结束 
///                 -16-通讯失败
///                 -101-当前程序为主程序，不能删除
///                 100-没有该功能
///                 101-其他错误</returns>
extern "C" __declspec(dllexport)	short   DeleteProgramFile(char* path, unsigned short flib)
{
	short ret;

	ret = cnc_pdf_del(flib, path);

	#pragma region Return Value
	if (ret == -16)return ret;
	if (ret == 0) return ret;
	return 101;
	#pragma endregion Return Value
}



