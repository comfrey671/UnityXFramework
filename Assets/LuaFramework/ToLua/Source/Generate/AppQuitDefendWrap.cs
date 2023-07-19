﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class AppQuitDefendWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(AppQuitDefend), typeof(System.Object));
		L.RegFunction("Init", Init);
		L.RegFunction("DontQuit", DontQuit);
		L.RegFunction("DoQuit", DoQuit);
		L.RegFunction("New", _CreateAppQuitDefend);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAppQuitDefend(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				AppQuitDefend obj = new AppQuitDefend();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: AppQuitDefend.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			AppQuitDefend.Init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DontQuit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = AppQuitDefend.DontQuit();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoQuit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			AppQuitDefend.DoQuit();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
