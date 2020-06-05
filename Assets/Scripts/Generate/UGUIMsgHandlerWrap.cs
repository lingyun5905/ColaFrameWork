﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UGUIMsgHandlerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UGUIMsgHandler), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("AttachListener", AttachListener);
		L.RegFunction("UnAttachListener", UnAttachListener);
		L.RegFunction("RemoveEventHandler", RemoveEventHandler);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onClick", get_onClick, set_onClick);
		L.RegVar("onDown", get_onDown, set_onDown);
		L.RegVar("onUp", get_onUp, set_onUp);
		L.RegVar("onEnter", get_onEnter, set_onEnter);
		L.RegVar("onInitializePotentialDragHandle", get_onInitializePotentialDragHandle, set_onInitializePotentialDragHandle);
		L.RegVar("onUpdateSelected", get_onUpdateSelected, set_onUpdateSelected);
		L.RegVar("onMove", get_onMove, set_onMove);
		L.RegVar("onSubmit", get_onSubmit, set_onSubmit);
		L.RegVar("onCancel", get_onCancel, set_onCancel);
		L.RegVar("onScroll", get_onScroll, set_onScroll);
		L.RegVar("onDeSelect", get_onDeSelect, set_onDeSelect);
		L.RegVar("onSelect", get_onSelect, set_onSelect);
		L.RegVar("onEndDrag", get_onEndDrag, set_onEndDrag);
		L.RegVar("onDrag", get_onDrag, set_onDrag);
		L.RegVar("onBeginDrag", get_onBeginDrag, set_onBeginDrag);
		L.RegVar("onDrop", get_onDrop, set_onDrop);
		L.RegVar("onExit", get_onExit, set_onExit);
		L.RegVar("onStrValueChange", get_onStrValueChange, set_onStrValueChange);
		L.RegVar("onIntValueChange", get_onIntValueChange, set_onIntValueChange);
		L.RegVar("onRectValueChange", get_onRectValueChange, set_onRectValueChange);
		L.RegVar("onFloatValueChange", get_onFloatValueChange, set_onFloatValueChange);
		L.RegVar("onBoolValueChange", get_onBoolValueChange, set_onBoolValueChange);
		L.RegVar("onEditEnd", get_onEditEnd, set_onEditEnd);
		L.RegVar("onInitializePotentialDrag", get_onInitializePotentialDrag, set_onInitializePotentialDrag);
		L.RegVar("onUpDetail", get_onUpDetail, set_onUpDetail);
		L.RegVar("onDownDetail", get_onDownDetail, set_onDownDetail);
		L.RegVar("onTableviewCellInit", get_onTableviewCellInit, set_onTableviewCellInit);
		L.RegVar("onEvent", get_onEvent, set_onEvent);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AttachListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUIMsgHandler obj = (UGUIMsgHandler)ToLua.CheckObject<UGUIMsgHandler>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.AttachListener(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnAttachListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUIMsgHandler obj = (UGUIMsgHandler)ToLua.CheckObject<UGUIMsgHandler>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.UnAttachListener(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveEventHandler(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUIMsgHandler obj = (UGUIMsgHandler)ToLua.CheckObject<UGUIMsgHandler>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveEventHandler(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onDown;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDown on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onUp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEnter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onEnter;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEnter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onInitializePotentialDragHandle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onInitializePotentialDragHandle;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onInitializePotentialDragHandle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUpdateSelected(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onUpdateSelected;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpdateSelected on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onMove(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onMove;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onMove on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSubmit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onSubmit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onSubmit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCancel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onCancel;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onCancel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onScroll;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onScroll on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDeSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onDeSelect;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDeSelect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onSelect;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onSelect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEndDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail ret = obj.onEndDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEndDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail ret = obj.onDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onBeginDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail ret = obj.onBeginDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onBeginDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onDrop;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDrop on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onExit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onExit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onExit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onStrValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			StrValueChangeAction ret = obj.onStrValueChange;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onStrValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onIntValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			IntValueChangeAction ret = obj.onIntValueChange;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onIntValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onRectValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			RectValueChangeAction ret = obj.onRectValueChange;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onRectValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onFloatValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			FloatValueChangeAction ret = obj.onFloatValueChange;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onFloatValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onBoolValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			BoolValueChangeAction ret = obj.onBoolValueChange;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onBoolValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEditEnd(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			StrValueChangeAction ret = obj.onEditEnd;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEditEnd on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onInitializePotentialDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler ret = obj.onInitializePotentialDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onInitializePotentialDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUpDetail(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail ret = obj.onUpDetail;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpDetail on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDownDetail(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail ret = obj.onDownDetail;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDownDetail on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onTableviewCellInit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UnityEngine.UI.Extensions.UITableView.OnCellInitEvent ret = obj.onTableviewCellInit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onTableviewCellInit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEvent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			System.Action<string> ret = obj.onEvent;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEvent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onDown = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDown on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onUp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEnter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onEnter = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEnter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onInitializePotentialDragHandle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onInitializePotentialDragHandle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onInitializePotentialDragHandle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUpdateSelected(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onUpdateSelected = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpdateSelected on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onMove(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onMove = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onMove on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSubmit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onSubmit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onSubmit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCancel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onCancel = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onCancel on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onScroll = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onScroll on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDeSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onDeSelect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDeSelect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onSelect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onSelect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEndDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail arg0 = (UIDragEventHandlerDetail)ToLua.CheckDelegate<UIDragEventHandlerDetail>(L, 2);
			obj.onEndDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEndDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail arg0 = (UIDragEventHandlerDetail)ToLua.CheckDelegate<UIDragEventHandlerDetail>(L, 2);
			obj.onDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onBeginDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail arg0 = (UIDragEventHandlerDetail)ToLua.CheckDelegate<UIDragEventHandlerDetail>(L, 2);
			obj.onBeginDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onBeginDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onDrop = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDrop on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onExit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onExit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onExit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onStrValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			StrValueChangeAction arg0 = (StrValueChangeAction)ToLua.CheckDelegate<StrValueChangeAction>(L, 2);
			obj.onStrValueChange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onStrValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onIntValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			IntValueChangeAction arg0 = (IntValueChangeAction)ToLua.CheckDelegate<IntValueChangeAction>(L, 2);
			obj.onIntValueChange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onIntValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onRectValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			RectValueChangeAction arg0 = (RectValueChangeAction)ToLua.CheckDelegate<RectValueChangeAction>(L, 2);
			obj.onRectValueChange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onRectValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onFloatValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			FloatValueChangeAction arg0 = (FloatValueChangeAction)ToLua.CheckDelegate<FloatValueChangeAction>(L, 2);
			obj.onFloatValueChange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onFloatValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onBoolValueChange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			BoolValueChangeAction arg0 = (BoolValueChangeAction)ToLua.CheckDelegate<BoolValueChangeAction>(L, 2);
			obj.onBoolValueChange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onBoolValueChange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEditEnd(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			StrValueChangeAction arg0 = (StrValueChangeAction)ToLua.CheckDelegate<StrValueChangeAction>(L, 2);
			obj.onEditEnd = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEditEnd on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onInitializePotentialDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIEventHandler arg0 = (UIEventHandler)ToLua.CheckDelegate<UIEventHandler>(L, 2);
			obj.onInitializePotentialDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onInitializePotentialDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUpDetail(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail arg0 = (UIDragEventHandlerDetail)ToLua.CheckDelegate<UIDragEventHandlerDetail>(L, 2);
			obj.onUpDetail = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpDetail on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDownDetail(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UIDragEventHandlerDetail arg0 = (UIDragEventHandlerDetail)ToLua.CheckDelegate<UIDragEventHandlerDetail>(L, 2);
			obj.onDownDetail = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDownDetail on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onTableviewCellInit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			UnityEngine.UI.Extensions.UITableView.OnCellInitEvent arg0 = (UnityEngine.UI.Extensions.UITableView.OnCellInitEvent)ToLua.CheckDelegate<UnityEngine.UI.Extensions.UITableView.OnCellInitEvent>(L, 2);
			obj.onTableviewCellInit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onTableviewCellInit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEvent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUIMsgHandler obj = (UGUIMsgHandler)o;
			System.Action<string> arg0 = (System.Action<string>)ToLua.CheckDelegate<System.Action<string>>(L, 2);
			obj.onEvent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEvent on a nil value");
		}
	}
}

