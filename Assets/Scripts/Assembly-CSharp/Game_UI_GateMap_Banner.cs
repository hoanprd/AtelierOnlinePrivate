using UnityEngine;

public class Game_UI_GateMap_Banner : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private UITexture m_sBanner;

	[SerializeField]
	private Game_UI_GateMap_GateButton_Base m_sButton;

	[SerializeField]
	private GameObject m_goEffRoot;

	[SerializeField]
	private UITweenReset m_scrTween;

	public void SetActive(bool bActive)
	{
	}

	public void SetTexture(string sPath)
	{
	}

	public void SetArea(int iAreaId)
	{
	}

	public void SetActiveEffect(bool bActive)
	{
	}

	public void SetButtonEnable(bool bEnable)
	{
	}
}
