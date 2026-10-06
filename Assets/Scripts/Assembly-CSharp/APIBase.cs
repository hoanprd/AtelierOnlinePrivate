using System;

public abstract class APIBase
{
	[Serializable]
	public class DebugBase
	{
		[Serializable]
		public class Detail
		{
			public string TIME;

			public int SEC;
		}

		[Serializable]
		public class View
		{
			public string FMT;
		}

		public Detail COM;

		public View VIEW;
	}

	public bool m_bAutoDispPop;

	public bool m_bAutoDispQuestAcheive;

	public virtual byte[] GetAPI<T>(T value)
	{
		return null;
	}

	public virtual byte[] GetAPI()
	{
		return null;
	}

	public virtual string GetActionName()
	{
		return null;
	}

	public abstract string Analysis(byte[] msgpack);

	public abstract void Notify();

	public abstract ResponseDataCommon GetCommonData();

	public virtual string GetDebug(string time, bool ignore_session)
	{
		return null;
	}

	public virtual bool IsRetry()
	{
		return false;
	}

	public virtual string GetDummyResponse()
	{
		return null;
	}

	public abstract void RegistError(string msg);

	public abstract void RegistError();

	public virtual void PostProcess()
	{
	}
}
