using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_GateListAreaBar : MonoBehaviour
{
	private int m_iArea;

	[SerializeField]
	private UILabel m_scrAreaName;

	[SerializeField]
	private UISprite m_scrAreaSprite;

	[SerializeField]
	private Game_UI_GateMap_GateListGateBarList m_scrGateList;

	[SerializeField]
	private Game_UI_GateMap_GateListAreaDetailButton m_scrDetailButton;

	[SerializeField]
	private GameObject m_goNoneObj;

	[SerializeField]
	private UITexture m_scrMyFace;

	private void MakeObject(List<MasterQuestInfo> clsQuestList)
	{
	}

	private void OnMadeObject(int iMadeCount)
	{
	}

	public void SetInfo(int iArea, List<MasterQuestInfo> clsQuestList)
	{
	}

	public int GetAreaID()
	{
		return 0;
	}
}
