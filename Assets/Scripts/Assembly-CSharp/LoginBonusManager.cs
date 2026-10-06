using UnityEngine;

public class LoginBonusManager : SingletonBase<LoginBonusManager>
{
	[SerializeField]
	private GameObject m_LoginBonusUI;

	[SerializeField]
	private LoginBonus m_LoginBonus;

	[SerializeField]
	private bool m_LoginBonusSkip;

	public bool IsFinished()
	{
		return false;
	}

	public void Init(HomeEnter.LoginBonusResponse info)
	{
	}

	private void Update()
	{
	}

	public static bool DispLoginBonus()
	{
		return false;
	}

	public static bool IsEnd()
	{
		return false;
	}
}
