using UnityEngine;

public class Game_UI_LifeGauge_Manager : MonoBehaviour
{
	public enum eGaugeKind
	{
		Player_Normal = 0,
		Enemy_Normal = 1,
		Enemy_Boss = 2
	}

	public enum eIconKind
	{
		My_Player = 0,
		Other_Player = 1,
		NPC_Player = 2,
		Enemy = 3
	}

	public GameObject m_lifeGauge_Player;

	public GameObject m_lifeGauge_Enemy;

	public GameObject MakeLifeGauge(eGaugeKind gaugeKind, eIconKind iconKind, int turnNum, MultiPlay_BattleMemberData data, int colorNum)
	{
		return null;
	}

	public GameObject MakeLifeGauge(MultiPlay_BattleMemberData data)
	{
		return null;
	}
}
