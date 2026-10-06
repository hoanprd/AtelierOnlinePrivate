using System.Collections.Generic;
using Town;
using UnityEngine;

public class Game_PaperMap_SpotData : MonoBehaviour
{
	private static readonly Vector3 s_buttonOffset;

	public int m_linkSpotId;

	public eSpot m_spotKind;

	public int m_NpcId;

	public string m_advName;

	public int m_npcScale;

	private int m_nowNpcId;

	private int m_reservNpcId;

	private Game_Chara_TM_Base m_npc;

	private GameObject m_button;

	private List<int> m_questDFList;

	private GameObject m_rootObj;

	private eLayerKind m_layer;

	public void Init(GameObject rootObj, eLayerKind layer)
	{
	}

	public void MakeSpot(GameObject rootObj, eLayerKind layer, int charaId)
	{
	}

	public void AddQuest(int df, int charaId)
	{
	}

	public void UpdateSpot()
	{
	}

	public void ClearQuestList()
	{
	}

	public List<int> GetQuestDFList()
	{
		return null;
	}

	public Game_Chara_TM_Base GetNPC()
	{
		return null;
	}

	public GameObject GetNGUIMark()
	{
		return null;
	}

	public string GetTalkFile(bool bDeafault, int iQuestDF = 0)
	{
		return null;
	}

	public void SetActive(bool active, bool onlyButton = false)
	{
	}

	private bool MakeNPC(GameObject rootObj, eLayerKind layer, int charaId)
	{
		return false;
	}

	private void OnMakeNPC()
	{
	}

	private void SetButton(Vector3 pos, int questDF)
	{
	}

	private bool IsDisp()
	{
		return false;
	}
}
