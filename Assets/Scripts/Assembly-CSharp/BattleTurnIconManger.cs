using System.Collections.Generic;
using UnityEngine;

public class BattleTurnIconManger : MonoBehaviour
{
	public enum ECharaKind
	{
		ePARTY = 0,
		eENEMY = 1,
		eLEADER = 2,
		eEnumMax = 3
	}

	public Transform[] m_atrIconRoot;

	public GameObject m_goIconPrefab;

	public GameObject m_countPrefab;

	private List<BattleTurnIcon_MultiPlay> m_targetIconList_Multi;

	private List<MultiPlay_BattleData.MultiPlay_BattleActionTurnData> BattleActionTurnList;

	public static readonly int playerNum;

	public Color[] m_acBackgroundColor;

	public Color[] m_acMarkColor;

	public static ECharaKind GetColorIndex(BattleCharaData data)
	{
		return ECharaKind.ePARTY;
	}

	private void Awake()
	{
	}

	public void SetDrawEnable(bool enableFlag)
	{
	}

	public void UpdateCountRPC(int id, int count)
	{
	}

	public void UpdateCount(int count)
	{
	}

	public void Move(List<MultiPlay_BattleData.MultiPlay_BattleActionTurnData> BattleActionTurnList)
	{
	}
}
