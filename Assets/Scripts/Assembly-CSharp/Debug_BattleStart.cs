using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Debug_BattleStart : SingletonBase<Debug_BattleStart>
{
	public List<Debug_CharaMember> charaList;

	public List<Debug_EnemyMember> enemyList;

	public List<Debug_ManualItem> manualList;

	public List<Debug_AutoItem> autoList;

	public List<InventoryInfo> itemList;

	public MakeCharaData BeforeDebugBattleMakeCharaData;

	private int BeforePartyMemberCount;

	private bool[] m_bFlagAry;

	private eEnemyKind m_eEnemyKind;

	[HideInInspector]
	public bool m_dummyBattleFlag_1;

	[HideInInspector]
	public bool m_dummyBattleFlag_2;

	[HideInInspector]
	public bool m_dummyBattleFlag_3;

	private List<int> itemDFList;

	private Dictionary<string, int> itemDFMap;
}
