using UnityEngine;

public class Debug_FpsCounter : Debug_Base
{
	private enum eTextKind
	{
		FrameNum_Now = 0,
		DeltaTime_Now = 1,
		DeltaTime_Ave = 2,
		DeltaTime_Max = 3,
		MemorySize_Now = 4,
		MemorySize_Max = 5,
		EnumMax = 6
	}

	public TextMesh[] m_textMeshArray;

	private static readonly int sc_iDeltaTimeLog_Max;

	private float[] m_fDeltaTimeLog;

	private int m_iDeltaTimeLog_Now;

	private int m_iCounter_Frame;

	private float m_fCounter_Sec;

	private float m_memSize_Max;

	private float m_timeScale_Log;

	private bool m_drawActiveFlag;

	private int m_framePerSecID;

	private int[] m_framePerSecArray;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
