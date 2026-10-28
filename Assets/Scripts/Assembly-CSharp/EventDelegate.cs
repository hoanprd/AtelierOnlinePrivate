using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		private object mValue;

		[NonSerialized]
		public Type expectedType = typeof(void);

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public object value
		{
			get
			{
				if (mValue != null)
				{
					return mValue;
				}
				if (!cached)
				{
					cached = true;
					fieldInfo = null;
					propInfo = null;
					if (obj != null && !string.IsNullOrEmpty(field))
					{
						Type t = obj.GetType();
						propInfo = t.GetProperty(field);
						if (propInfo == null)
						{
							fieldInfo = t.GetField(field);
						}
					}
				}
				if (propInfo != null)
				{
					return propInfo.GetValue(obj, null);
				}
				if (fieldInfo != null)
				{
					return fieldInfo.GetValue(obj);
				}
				if (obj != null)
				{
					return obj;
				}
				if (expectedType != null && expectedType.IsValueType)
				{
					return null;
				}
				return Convert.ChangeType(null, expectedType);
			}
			set
			{
				mValue = value;
			}
		}

		public Type type
		{
			get
			{
				if (mValue != null)
				{
					return mValue.GetType();
				}
				if (obj == null)
				{
					return typeof(void);
				}
				return obj.GetType();
			}
		}

		public Parameter()
		{
		}

		public Parameter(UnityEngine.Object obj, string field)
		{
			this.obj = obj;
			this.field = field;
		}

		public Parameter(object val)
		{
			mValue = val;
		}
	}

	public delegate void Callback();

	[SerializeField]
	private MonoBehaviour mTarget;

	[SerializeField]
	private string mMethodName;

	[SerializeField]
	private Parameter[] mParameters;

	public bool oneShot;

	[NonSerialized]
	private Callback mCachedCallback;

	[NonSerialized]
	private bool mRawDelegate;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private MethodInfo mMethod;

	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	private object[] mArgs;

	private static int s_Hash = "EventDelegate".GetHashCode();

	public MonoBehaviour target
	{
		get
		{
			return mTarget;
		}
		set
		{
			mTarget = value;
			mCachedCallback = null;
			mRawDelegate = false;
			mCached = false;
			mMethod = null;
			mParameterInfos = null;
			mParameters = null;
		}
	}

	public string methodName
	{
		get
		{
			return mMethodName;
		}
		set
		{
			mMethodName = value;
			mCachedCallback = null;
			mRawDelegate = false;
			mCached = false;
			mMethod = null;
			mParameterInfos = null;
			mParameters = null;
		}
	}

	public Parameter[] parameters
	{
		get
		{
			if (!mCached)
			{
				Cache();
			}
			return mParameters;
		}
	}

	public bool isValid
	{
		get
		{
			if (!mCached)
			{
				Cache();
			}
			return (mRawDelegate && mCachedCallback != null) || (mTarget != null && !string.IsNullOrEmpty(mMethodName));
		}
	}

	public bool isEnabled
	{
		get
		{
			if (!mCached)
			{
				Cache();
			}
			if (mRawDelegate && mCachedCallback != null)
			{
				return true;
			}
			if (mTarget == null)
			{
				return false;
			}
			MonoBehaviour mb = mTarget;
			return mb == null || mb.enabled;
		}
	}

	public EventDelegate()
	{
	}

	public EventDelegate(Callback call)
	{
		Set(call);
	}

	public EventDelegate(MonoBehaviour target, string methodName)
	{
		Set(target, methodName);
	}

	private static string GetMethodName(Callback callback)
	{
		return callback != null ? callback.Method.Name : null;
	}

	private static bool IsValid(Callback callback)
	{
		return callback != null && callback.Method != null;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return !isValid;
		}
		if (obj is Callback)
		{
			Callback cb = obj as Callback;
			if (cb.Equals(mCachedCallback))
			{
				return true;
			}
			MonoBehaviour mb = cb.Target as MonoBehaviour;
			return mTarget == mb && string.Equals(mMethodName, GetMethodName(cb));
		}
		if (obj is EventDelegate)
		{
			EventDelegate del = obj as EventDelegate;
			if (mRawDelegate && del.mRawDelegate)
			{
				return Equals(mCachedCallback, del.mCachedCallback);
			}
			return mTarget == del.mTarget && string.Equals(mMethodName, del.mMethodName);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return s_Hash;
	}

	private void Set(Callback call)
	{
		Clear();
		if (call != null && IsValid(call))
		{
			mTarget = call.Target as MonoBehaviour;
			if (mTarget == null)
			{
				mRawDelegate = true;
				mCachedCallback = call;
				mMethodName = null;
			}
			else
			{
				mMethodName = GetMethodName(call);
				mRawDelegate = false;
				mCachedCallback = call;
				mCached = true;
			}
		}
	}

	public void Set(MonoBehaviour target, string methodName)
	{
		Clear();
		mTarget = target;
		mMethodName = methodName;
	}

	private void Cache()
	{
		mCached = true;
		if (mRawDelegate)
		{
			return;
		}
		if ((mCachedCallback == null || (mCachedCallback.Target as MonoBehaviour) != mTarget || GetMethodName(mCachedCallback) != mMethodName) && mTarget != null && !string.IsNullOrEmpty(mMethodName))
		{
			Type type = mTarget.GetType();
			mMethod = null;
			while (type != null)
			{
				try
				{
					mMethod = type.GetMethod(mMethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (mMethod != null)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
				type = type.BaseType;
			}
			if (mMethod == null)
			{
				return;
			}
			mParameterInfos = mMethod.GetParameters();
			if (mParameterInfos.Length == 0 && mMethod.ReturnType == typeof(void))
			{
				mCachedCallback = (Callback)Delegate.CreateDelegate(typeof(Callback), mTarget, mMethod, false);
				mArgs = null;
				mParameters = null;
				return;
			}
			mCachedCallback = null;
			if (mParameters != null && mParameters.Length != mParameterInfos.Length)
			{
				mParameters = null;
			}
			if (mParameters == null)
			{
				mParameters = new Parameter[mParameterInfos.Length];
				for (int i = 0; i < mParameters.Length; i++)
				{
					mParameters[i] = new Parameter();
				}
			}
			for (int j = 0; j < mParameters.Length; j++)
			{
				mParameters[j].expectedType = mParameterInfos[j].ParameterType;
			}
		}
	}

	public bool Execute()
	{
		if (!mCached)
		{
			Cache();
		}
		if (mCachedCallback != null)
		{
			mCachedCallback();
			return true;
		}
		if (mMethod != null)
		{
			if (mParameters == null || mParameters.Length == 0)
			{
				mMethod.Invoke(mTarget, null);
			}
			else
			{
				if (mArgs == null || mArgs.Length != mParameters.Length)
				{
					mArgs = new object[mParameters.Length];
				}
				for (int i = 0; i < mParameters.Length; i++)
				{
					mArgs[i] = mParameters[i].value;
				}
				try
				{
					mMethod.Invoke(mTarget, mArgs);
				}
				catch (ArgumentException)
				{
				}
				for (int j = 0; j < mArgs.Length; j++)
				{
					if (mParameterInfos[j].IsIn || mParameterInfos[j].IsOut)
					{
						mParameters[j].value = mArgs[j];
					}
					mArgs[j] = null;
				}
			}
			return true;
		}
		return false;
	}

	public void Clear()
	{
		mTarget = null;
		mMethodName = null;
		mRawDelegate = false;
		mCachedCallback = null;
		mParameters = null;
		mCached = false;
		mMethod = null;
		mParameterInfos = null;
		mArgs = null;
	}

	public override string ToString()
	{
		if (mTarget != null)
		{
			string typeName = mTarget.GetType().ToString();
			int dot = typeName.LastIndexOf('/');
			if (dot > 0)
			{
				typeName = typeName.Substring(dot + 1);
			}
			if (!string.IsNullOrEmpty(mMethodName))
			{
				return typeName + "/" + mMethodName;
			}
			return typeName + "/[delegate]";
		}
		return mRawDelegate ? "[delegate]" : null;
	}

	public static void Execute(List<EventDelegate> list)
	{
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count;)
		{
			EventDelegate del = list[i];
			if (del != null)
			{
				try
				{
					del.Execute();
				}
				catch (Exception ex)
				{
					Debug.LogException(ex);
				}
				if (i >= list.Count)
				{
					break;
				}
				if (list[i] != del)
				{
					continue;
				}
				if (del.oneShot)
				{
					list.RemoveAt(i);
					continue;
				}
			}
			i++;
		}
	}

	public static bool IsValid(List<EventDelegate> list)
	{
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				EventDelegate del = list[i];
				if (del != null && del.isValid)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		if (list != null)
		{
			EventDelegate del = new EventDelegate(callback);
			list.Clear();
			list.Add(del);
			return del;
		}
		return null;
	}

	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
		if (list != null)
		{
			list.Clear();
			list.Add(del);
		}
	}

	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return Add(list, callback, false);
	}

	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				EventDelegate existing = list[i];
				if (existing != null && existing.Equals(callback))
				{
					return existing;
				}
			}
			EventDelegate del = new EventDelegate(callback);
			del.oneShot = oneShot;
			list.Add(del);
			return del;
		}
		return null;
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
		Add(list, ev, ev != null && ev.oneShot);
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
		if (ev == null || list == null)
		{
			return;
		}
		if (ev.mRawDelegate || ev.target == null || string.IsNullOrEmpty(ev.methodName))
		{
			Add(list, ev.mCachedCallback, oneShot);
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			EventDelegate existing = list[i];
			if (existing != null && existing.Equals(ev))
			{
				return;
			}
		}
		EventDelegate copy = new EventDelegate(ev.target, ev.methodName);
		copy.oneShot = oneShot;
		if (ev.mParameters != null && ev.mParameters.Length > 0)
		{
			copy.mParameters = new Parameter[ev.mParameters.Length];
			for (int j = 0; j < ev.mParameters.Length; j++)
			{
				copy.mParameters[j] = ev.mParameters[j];
			}
		}
		list.Add(copy);
	}

	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				EventDelegate del = list[i];
				if (del != null && del.Equals(callback))
				{
					list.RemoveAt(i);
					return true;
				}
			}
		}
		return false;
	}

	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				EventDelegate del = list[i];
				if (del != null && del.Equals(ev))
				{
					list.RemoveAt(i);
					return true;
				}
			}
		}
		return false;
	}
}
