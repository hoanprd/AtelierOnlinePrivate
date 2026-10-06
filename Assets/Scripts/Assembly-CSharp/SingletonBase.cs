using UnityEngine;

public class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
{
	protected static T s_sInstance;

	public static T Instance
	{
		get
		{
			return null;
		}
	}

	public static bool IsExist
	{
		get
		{
			return false;
		}
	}

	protected virtual void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void OnDestroySub()
	{
	}
}
