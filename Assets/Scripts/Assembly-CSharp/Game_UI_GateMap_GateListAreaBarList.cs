using System.Collections.Generic;

public class Game_UI_GateMap_GateListAreaBarList : UIListViewBase<Game_UI_GateMap_GateListAreaBar>
{
	private int m_iLookingBarIndex;

	private int m_hardiLookingBarIndex;

	private float m_fGridWidth;

	private List<Game_UI_GateMap_GateListAreaBar> m_AreaList;

	public void MakeObject(Dictionary<int, List<MasterQuestInfo>> clsQuestListDic, int iPriQuestDF)
	{
	}

	public void OnReposition()
	{
	}

	public void OnRepositionhard()
	{
	}

	public void SetActiveAllAreaList(bool active)
	{
	}

	public void SetActiveAllHardModeAreaList(bool active)
	{
	}
}
