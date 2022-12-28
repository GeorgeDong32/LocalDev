#ifndef __LOADING_HPP__
#define __LOADING_HPP__
#include <stdio.h>
#include <Windows.h>

void LoadingRing(int rotationTime)//控制台中的加载动画，输入为旋转一次所需时间
{
    char chars[4] = { '\\', '|', '/', '-' };
    while (true) {
        for (int i = 0; i < 4; i++) {
            printf("\r%c", chars[i]);
            Sleep(rotationTime);
        }
    }
}

void ProcessBar(int processTime, int processbarLength)//控制台中的进度条，输入为加载时间和进度条共有几个进度块
{
	int devidedTime = processTime / processbarLength;
	printf("");
	for (int i = 0; i < processbarLength; i++)
	{
		printf("\r|");
		for (int j = 0; j < i; j++)
		{
			printf("");
		}
		for (int j = i; j < processbarLength - 1; j++)
		{
			printf(" ");
		}
		printf("|");
		Sleep(devidedTime);
	}
}

#endif