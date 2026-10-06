using System.Collections.Generic;
using UnityEngine;

public class MasterExtraQuestData : ScriptableObject
{
	public List<ExtraQuestData> List;

	public ExtraQuestData Find(int questDf)
	{
		return null;
	}

	public int GetPosID(int fieldDf = 0, int questDf = 0)
	{
		return 0;
	}

	public int GetPosID(int id)
	{
		return 0;
	}

	public bool CheckCoodinateData(int posID, int fieldDF)
	{
		return false;
	}

	public int GetMutchKeyChara(int questDF, List<int> charaDfList)
	{
		return 0;
	}

	public string GetClearEventADV(int questDF, int keyCharaNum)
	{
		return null;
	}

	public int GetDungeonID(int posID, int fieldDF, int questDF)
	{
		return 0;
	}
}
