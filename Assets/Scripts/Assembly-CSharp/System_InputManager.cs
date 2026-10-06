using System.Runtime.InteropServices;
using UnityEngine;

public class System_InputManager : MonoBehaviour
{
	public enum eTouchID
	{
		First = 0,
		Second = 1,
		Third = 2,
		Fourth = 3,
		EnumMax = 4
	}

	[StructLayout((LayoutKind)0, Size = 28)]
	public struct stFingerLogData
	{
		public bool bTouchFlag;

		public bool bIgnoreFlag;

		public int iPressCount;

		public Vector2 vecPosNow;

		public Vector2 vecPosFirst;

		public void Initialize()
		{
		}

		public Vector2 GetScreenPercent(Vector2 vecTemp)
		{
			return default(Vector2);
		}

		public Vector2 GetTouchPos_Now()
		{
			return default(Vector2);
		}

		public Vector2 GetTouchPos_First()
		{
			return default(Vector2);
		}

		public Vector2 GetTouchLength()
		{
			return default(Vector2);
		}
	}

	private static System_InputManager g_scrInst;

	private static readonly int sc_iTouchCountMax;

	private static readonly float sc_fDepthCheck_Max;

	private static readonly float sc_fAspectRatio_Default;

	private static float m_fAspectRatio_Now;

	private static float m_fHeight_MarginPercent;

	private static float m_fHeight_EnablePercent;

	private static float m_fWidth_MarginPercent;

	private static float m_fWidth_EnablePercent;

	private stFingerLogData[] m_stFingerLogData;

	private int m_iTouchCountNow;

	private int m_iTouchCountLog;

	private void Awake()
	{
	}

	public static System_InputManager GetInst()
	{
		return null;
	}

	public static Vector2 GetScreenPercent_SubMargin(Vector2 vecPos)
	{
		return default(Vector2);
	}

	public Vector2 GetScreenPercent_Enable()
	{
		return default(Vector2);
	}

	public Vector2 GetScreenPercent_Margin()
	{
		return default(Vector2);
	}

	public void Initialize()
	{
	}

	private void Update()
	{
	}

	private void UpdateFingerData()
	{
	}

	private void UpdateTouchData()
	{
	}

	private void MakeTouchEffect(eEffectKind eKind, Vector2 vecPos2D)
	{
	}

	private bool IsTouchLogOK(Vector2 vecPos)
	{
		return false;
	}

	private bool IsLayer_NGUI(int layerId)
	{
		return false;
	}

	private int GetFingerID(byte iTouchID)
	{
		return 0;
	}

	public int GetTouchFingerCount()
	{
		return 0;
	}

	public bool IsTouchTrigger()
	{
		return false;
	}

	public bool IsTouchTrigger(eTouchID eID)
	{
		return false;
	}

	public bool IsTouchPress(eTouchID eID)
	{
		return false;
	}

	public bool IsTouchOff()
	{
		return false;
	}

	private bool IsTouchPos_ReturnOK(eTouchID eID)
	{
		return false;
	}

	public Vector2 GetTouchPos_First(eTouchID eID)
	{
		return default(Vector2);
	}

	public Vector2 GetTouchPos_Now(eTouchID eID)
	{
		return default(Vector2);
	}

	public Vector2 GetTouchPos_Moved(eTouchID eID)
	{
		return default(Vector2);
	}

	public Vector3 GetTouchPos_3D(eTouchID eID)
	{
		return default(Vector3);
	}

	public void SetIgnoreAllTouch()
	{
	}

	public static void SetMultiTouch(bool bEnable)
	{
	}
}
