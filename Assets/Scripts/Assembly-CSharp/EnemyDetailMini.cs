using UnityEngine;

public class EnemyDetailMini : MonoBehaviour
{
	private EnemyDetailMiniEvent m_sSelectEvent;

	private EnemyDetailMiniEvent m_sDetailEvent;

	private int m_iDF;

	public UILabel m_sName;

	public UITexture m_sTex;

	public UILongTapButton m_sSelectButton;

	public int DF
	{
		get
		{
			return 0;
		}
	}

	public void Init(int iDF, string strName, string strTexPath, EnemyDetailMiniEvent OnSelect)
	{
	}

	public void SetEnableClick(bool sw)
	{
	}

	public void SetEnableLongTap(bool sw)
	{
	}

	public void OnDetail()
	{
	}

	public void OnSelect()
	{
	}

	public static EnemyDetailMini Create(Transform parent)
	{
		return null;
	}
}
