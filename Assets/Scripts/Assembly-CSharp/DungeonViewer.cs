using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DunGen;
using UnityEngine;
using UnityEngine.AI;

public class DungeonViewer : MonoBehaviour
{
	private static readonly float s_fErrorTime;

	private List<MakeCharaData> m_vCharaList;

	private Game_Chara_MA_Player m_scrPlayer;

	private bool m_bDispDebugLog;

	private bool m_bLoadedMaster;

	private bool m_bDispDebug;

	private float m_fErrorTime;

	private Coroutine m_cGenerateCoroutine;

	private Coroutine m_cCharaCoroutine;

	private int m_iNowDungeonId;

	private int m_iNowFloor;

	public RuntimeDungeon m_scrDungeonGenerator;

	public NavMeshSurface m_scrNavmeshSurface;

	public UILabel m_scrErrorLabel;

	public int m_iSeed;

	private DungeonInfo m_clsDispDungeon;

	private int m_iDebugButtonHeight;

	private int m_iDebugButtonWidth;

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadMasterData()
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator Generate(DungeonInfo clsDungeon, int iFloor)
	{
		return null;
	}

	private void OnGenerationStatusChanged(DungeonGenerator scrGenerator, GenerationStatus eStatus)
	{
	}

	private void DispError(bool bActive, string strMessage = "")
	{
	}

	[DebuggerHidden]
	private IEnumerator MakeChara(bool bResetPosition)
	{
		return null;
	}

	private void PlayRandomMusic()
	{
	}

	private void PlayRandomSound()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void OnGUI_SelectButton()
	{
	}

	private void OnGUI_Dungeon()
	{
	}

	private void OnGUI_Floor()
	{
	}
}
