// HelloWorld.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

extern "C" __declspec(dllexport) void hello()
{
	printf("hello\n");
	return;
}
