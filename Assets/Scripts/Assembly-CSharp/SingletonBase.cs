using UnityEngine;

public class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
{
	protected static T s_sInstance;

	public static T Instance
	{
		get
		{
			if (s_sInstance == null && Application.isPlaying)
			{
				T existing = Object.FindAnyObjectByType<T>(FindObjectsInactive.Include);
				if (existing != null)
				{
					s_sInstance = existing;
				}
				else
				{
					GameObject go = new GameObject();
					s_sInstance = go.AddComponent<T>();
					go.name = s_sInstance.GetType().Name;
				}
			}
			return s_sInstance;
		}
	}

	public static bool IsExist
	{
		get
		{
			return s_sInstance != null;
		}
	}

	protected virtual void Awake()
	{
		if (s_sInstance != null && s_sInstance != this)
		{
			Destroy(gameObject);
			return;
		}
		s_sInstance = this as T;
		if (transform.parent == null)
		{
			DontDestroyOnLoad(gameObject);
		}
	}

	private void OnDestroy()
	{
		if (s_sInstance == this)
		{
			OnDestroySub();
			s_sInstance = null;
		}
	}

	protected virtual void OnDestroySub()
	{
	}
}
