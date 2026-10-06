using System.Threading;

public class AsyncLoadJsonFromFile<Type>
{
	public delegate void Callback(string filePath, string result, Type data);

	private Thread m_Thread;

	private string m_sError;

	private bool m_bComplete;

	private string m_sFilePath;

	private Type m_sData;

	private Callback m_sCallback;

	private int m_iLandSeed;

	public string FilePath
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

	public AsyncLoadJsonFromFile()
	{
	}

	public AsyncLoadJsonFromFile(string filePath, Callback callback = null)
	{
	}

	public void Start()
	{
	}

	public void Start(string filePath, Callback callback = null)
	{
	}

	public void Release()
	{
	}

	private void ThreadWorkSync()
	{
	}

	private void ThreadWork()
	{
	}
}
