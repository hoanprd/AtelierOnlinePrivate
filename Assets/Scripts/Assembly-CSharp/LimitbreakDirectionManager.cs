using UnityEngine;

public class LimitbreakDirectionManager : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UITexture m_txCharaPic;

	[SerializeField]
	private UILabel m_sNowLvMax;

	[SerializeField]
	private UILabel m_sNextLvMax;

	[SerializeField]
	private UIButton m_sOKButton;

	[SerializeField]
	private LimitbreakDirectionAnim m_sAnim;

	[SerializeField]
	private LimitbreakDirectionStar m_sStar;

	[SerializeField]
	private LimitbreakDirectionStar m_sStar_over7;

	[SerializeField]
	private LimitbreakDirectionStar m_sBigStar;

	private bool m_bAddBigStar;

	private int m_iStarNum;

	private int m_iBigStarNum;

	private int m_iCharaID;

	public void Init()
	{
	}

	public void Play(int charaDF, int nowLVMax, int nextLVMax, int nowStar, int nextStar)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnMoveFoward()
	{
	}

	private void OnAddStar()
	{
	}

	private void OnAnimFinish()
	{
	}
}
