using System.Collections.Generic;
using UnityEngine;

public class Game_MapArea_Base : System_Mover_Base
{
	private enum CheckDir
	{
		Left = 0,
		Up = 1,
		Right = 2,
		Down = 3,
		EnumMax = 4
	}

	private enum CheckData
	{
		X = 0,
		Y = 1,
		EnumMax = 2
	}

	[SerializeField]
	public List<Transform> m_playerSpawnPosList;

	public Vector2 m_cameraLimitPos_Min;

	public Vector2 m_cameraLimitPos_Max;

	private Vector2 m_cameraLimitPosEx_Min;

	private Vector2 m_cameraLimitPosEx_Max;

	private bool m_isCameraLimitEx;

	public GameObject m_navGridCheckArea;

	public GameObject m_navGridFloorCollision;

	public bool m_navGridDebugDraw;

	private static readonly int[][] m_checkDirArray;

	[HideInInspector]
	public int m_navGridSizeX;

	[HideInInspector]
	public int m_navGridSizeY;

	[HideInInspector]
	public float m_navGridScale;

	[HideInInspector]
	public Vector3 m_navGridOffset;

	[HideInInspector]
	public bool[] m_navGridArrayBake;

	private bool[,] m_navGridArray;

	private bool m_navGridTouchLogDraw;

	private Vector3 m_navGridTouchLogPos;

	public Vector2 m_cameraLimitNow_Min
	{
		get
		{
			return default(Vector2);
		}
	}

	public Vector2 m_cameraLimitNow_Max
	{
		get
		{
			return default(Vector2);
		}
	}

	public Transform GetSpawnPos(int id = 0)
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected void UpdateNavGrid()
	{
	}

	public int GetGridX(float posX)
	{
		return 0;
	}

	public int GetGridY(float posZ)
	{
		return 0;
	}

	public Vector3 GetGridPos(int iX, int iY)
	{
		return default(Vector3);
	}

	public bool IsNavGridEnableFloor(Vector3 checkPos)
	{
		return false;
	}

	public void OnDrawGizmos()
	{
	}

	public void SetNavGridTouchLog(Vector3 touchPos)
	{
	}

	public Vector3 GetNavGridMoveDir(Vector3 myPos, Vector3 targetPos)
	{
		return default(Vector3);
	}

	private NavGridResult GetNavGridResult(Vector3 myPos, Vector3 targetPos)
	{
		return null;
	}

	public int GetAreaID()
	{
		return 0;
	}

	public int GetStageID()
	{
		return 0;
	}

	public void SetCameraLimitEx(Vector2 min, Vector2 max)
	{
	}

	public void RemoveCameraLimitEx()
	{
	}
}
