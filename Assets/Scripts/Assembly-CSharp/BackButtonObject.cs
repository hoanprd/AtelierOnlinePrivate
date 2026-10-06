using UnityEngine;

public class BackButtonObject : MonoBehaviour
{
	private int m_iPriority;

	private bool m_bRecursion;

	private UIButton m_sButton;

	public bool IsRecursion
	{
		get
		{
			return false;
		}
	}

	public bool IsEnable()
	{
		return false;
	}

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Regist(int prio)
	{
	}

	public void Click()
	{
	}

	public static int Compare(BackButtonObject x, BackButtonObject y)
	{
		return 0;
	}
}
