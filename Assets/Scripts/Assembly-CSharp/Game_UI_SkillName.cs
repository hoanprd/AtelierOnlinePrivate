using UnityEngine;

public class Game_UI_SkillName : MonoBehaviour
{
	private enum ETweenKind
	{
		eBRINGIN = 1,
		eDISMISS = 2
	}

	public UILabel m_sName;

	public UISprite m_sElementIcon;

	public UITweenReset m_sTween;

	private bool m_bFinish;

	public bool IsFinished
	{
		get
		{
			return false;
		}
	}

	public void SetInfo(string skillName)
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void OnFinished()
	{
	}

	private void Awake()
	{
	}

	private void StartTween(ETweenKind kind)
	{
	}
}
