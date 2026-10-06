using UnityEngine;

public class Game_UI_GateMap_AreaName : MonoBehaviour
{
	private static readonly int sr_iPinMax;

	[SerializeField]
	private UILabel m_scrAreaName;

	[SerializeField]
	private GameObject[] m_goPinL;

	[SerializeField]
	private GameObject[] m_goPinS;

	[SerializeField]
	private GameObject m_goPinRoot;

	[SerializeField]
	private UITexture m_scrCharaIcon;

	[SerializeField]
	private UITweenReset m_TweenRoot;

	private Transform[] childTransforms;

	public void SetInfo(int iArea, int iLv)
	{
	}

	public void SetActivePin(bool bActive)
	{
	}

	public void SetActiveAreaName(bool active)
	{
	}
}
