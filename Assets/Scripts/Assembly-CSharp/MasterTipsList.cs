using System.Collections.Generic;
using UnityEngine;

public class MasterTipsList : ScriptableObject
{
	public List<MasterTips> LOADING_LIST = new List<MasterTips>();

	public List<MasterTips> BATTLE_LIST = new List<MasterTips>();

	public MasterTips GetLoading()
	{
		if (LOADING_LIST != null && LOADING_LIST.Count > 0)
		{
			return LOADING_LIST[Random.Range(0, LOADING_LIST.Count)];
		}
		return new MasterTips
		{
			iID = 1,
			sTitle = "TIPS",
			sContent = "アトリエオンラインへようこそ！"
		};
	}

	public MasterTips GetBattle()
	{
		if (BATTLE_LIST != null && BATTLE_LIST.Count > 0)
		{
			return BATTLE_LIST[Random.Range(0, BATTLE_LIST.Count)];
		}
		return new MasterTips
		{
			iID = 1,
			sTitle = "TIPS",
			sContent = "バトルに勝利しよう！"
		};
	}
}
