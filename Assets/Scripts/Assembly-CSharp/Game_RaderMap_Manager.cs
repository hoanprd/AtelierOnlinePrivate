using UnityEngine;

public class Game_RaderMap_Manager : MonoBehaviour
{
	private static Game_RaderMap_Manager m_inst;

	private int m_waitFrame_Init;

	public GameObject m_cameraPos_LD;

	public GameObject m_cameraPos_RU;

	public UITexture m_mapTex;

	private Camera m_mainCamera;

	private GameObject m_raderMask;

	private GameObject m_jammingMask;

	private bool m_allMap;

	private Bounds m_wholeSize;

	public Camera m_NGUICamra;

	public static bool IsAllMap
	{
		get
		{
			return false;
		}
	}

	public static Game_RaderMap_Manager GetInst()
	{
		return null;
	}

	protected void Awake()
	{
	}

	public static GameObject MakeRaderMarker(Transform target, Game_RaderMap_Marker.eMarkerKind markerKind, int roomIndex = 0)
	{
		return null;
	}

	public static void ChangeRaderMarker(GameObject raderMarker, Game_RaderMap_Marker.eMarkerKind markerKind, int roomIndex = 0)
	{
	}

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	public void SetJamming(bool enableFlag)
	{
	}

	public static void SetAllMap(bool on)
	{
	}

	private void SetAllMap_Loc(bool on)
	{
	}

	private void GetSize()
	{
	}
}
