using System.Collections.Generic;
using UnityEngine;

public class Game_UI_Chat_Window_Log : MonoBehaviour
{
	private static readonly Vector3 sr_v3MakeOffsetPos;

	private static readonly int sr_iLogMax;

	private bool m_bInitialized;

	private Vector3 m_v3MyPos_Log;

	private bool m_bReading;

	private bool m_bActiveTable_Log;

	private Queue<GameObject> m_goLogQueue;

	[SerializeField]
	private GameObject m_goPlayerBase_L;

	[SerializeField]
	private GameObject m_goPlayerBase_R;

	[SerializeField]
	private GameObject m_goSystemBase;

	[SerializeField]
	private UIScrollView m_scrScrollView;

	[SerializeField]
	private UITable m_scrTable;

	[SerializeField]
	private UIScrollListArrow m_scrArrow;

	[SerializeField]
	private UIScrollBar m_scrBar;

	private void Awake()
	{
	}

	private void OnReposition()
	{
	}

	private GameObject MakeChild(GameObject goChild, MultiPlay_ChatData clsChat)
	{
		return null;
	}

	public void Init()
	{
	}

	public void AddLog(MultiPlay_ChatData clsChat)
	{
	}

	public void Reset()
	{
	}

	public void SetScrollBar(UIScrollBar scrBar)
	{
	}
}
