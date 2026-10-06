using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_PlayerInfo : MonoBehaviour
{
	private static readonly string[] sc_strDebugName;

	private static readonly int sc_iChildMax;

	private List<Game_UI_GateMap_PlayerInfoChild> m_scrChildList;

	[SerializeField]
	private GameObject m_goChildBase;

	[SerializeField]
	private UIGrid m_scrGrid;

	public void SetInfo()
	{
	}

	public void SetInfo(int iNum, Vector2 v2OffSet, Vector2 v2Size)
	{
	}

	public void KillChild()
	{
	}
}
