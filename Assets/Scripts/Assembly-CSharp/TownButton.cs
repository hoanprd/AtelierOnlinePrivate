using Town;
using UnityEngine;

public class TownButton : NGUI_ClickButton
{
	public int m_iSpotId;

	public eSpot m_eSpotKind;

	public UISprite m_scrIcon;

	public UITweenReset m_scrAnim;

	public QuestCategoryMark m_scrQuest;

	public GameObject m_goQuestMarkRoot;

	protected override void AwakeSub()
	{
	}

	protected override void OnEnable_Sub()
	{
	}

	public void SetData(Vector3 v3Pos, int iSpotId, eSpot eSpotKind, int iQuestDF)
	{
	}

	public void SetAnim()
	{
	}

	protected override void DecideButton()
	{
	}
}
