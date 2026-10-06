using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_Chara_BA_Base : Game_Chara_Base
{
	private List<ActiveSkill> m_activeSkillList;

	private List<int> m_itemList;

	private GameObject m_animeSetObj;

	private GameObject m_animeSetCharaObj;

	public void MakeCharaObject(MakeCharaData mk, bool springFlag, bool ignoreOptionParts, List<ActiveSkill> skillList, Dictionary<long, MultiPlay_InventoryInfo> itemList)
	{
	}

	[DebuggerHidden]
	public IEnumerator AnimLoad(int CharaID)
	{
		return null;
	}

	protected void SetBattleAnim(MakeCharaData data, GameObject bodyObj)
	{
	}

	protected override eCharaShaderGroupKind GetShaderGroupKind()
	{
		return eCharaShaderGroupKind.Normal;
	}

	protected override bool IsCulling()
	{
		return false;
	}

	protected override void InstantiateModel(MakeCharaData mk, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	protected override void InitAnim()
	{
	}

	public void SetAnime(int id)
	{
	}

	public void SetFace_Down(bool downFlag)
	{
	}
}
