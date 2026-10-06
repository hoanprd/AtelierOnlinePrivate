using System.Collections.Generic;
using UnityEngine;

public class Game_Gimmick_QuestArea : Game_Gimmick_Base
{
	private QuestArea m_clsArea;

	private Game_UI_Talk m_scrQuestMark;

	private GameObject m_goEffect;

	protected override void OnDestroy()
	{
	}

	public override void UpdateSpotInfo()
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public List<int> GetQuestDFList()
	{
		return null;
	}
}
