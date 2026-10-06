using System.Threading;

public class AsyncLoadJson<Type>
{
	public delegate void Callback(string json, string result, Type data);

	private Thread m_Thread;

	private string m_sError;

	private bool m_bComplete;

	private string m_sJson;

	private Type m_sData;

	private Callback m_sCallback;

	public string Json
	{
		get
		{
			return null;
		}
	}

	public Type Data
	{
		get
		{
			return default(Type);
		}
	}

	public bool IsComplete
	{
		get
		{
			return false;
		}
	}

	public string Error
	{
		get
		{
			return null;
		}
	}

	public AsyncLoadJson()
	{
	}

	public AsyncLoadJson(string json, Callback callback = null)
	{
	}

	public void Start()
	{
	}

	public void Start(string json, Callback callback = null)
	{
	}

	public void Release()
	{
	}

	private void ThreadWork()
	{
	}
}
