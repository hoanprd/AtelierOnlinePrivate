using System.Collections.Generic;
using UnityEngine;

public class Game_PaperMap_Manager : MonoBehaviour
{
	private enum eMainStep
	{
		Wait = 0,
		Anim_I = 1,
		Visible = 2,
		Anim_O = 3,
		EnumMax = 4
	}

	private eMainStep m_mainStep;

	private Camera m_mainCamera;

	private GameObject m_paperMapObj;

	private Animation m_paperMapAnim;

	private GameObject m_markParentObj;

	private List<GameObject> m_nguiMarkArray;

	private static readonly int m_paperMapId_None;

	private static int m_paperMapId_Req;

	private static readonly int m_clickedSpotId_None;

	private static int m_clickedSpotId_Req;

	public static void SetPaperMap(int paperMapId)
	{
	}

	public static void SetJumpSpotId(int spotId)
	{
	}

	private void Awake()
	{
	}

	public void ClearPaperMap()
	{
	}

	public void MakePaperMap()
	{
	}

	public Vector3 GetNGUIScreenPos(Vector3 worldPos)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	private void SetDrawNgui(bool flag)
	{
	}
}
