using System.Collections.Generic;
using UnityEngine;

public class Game_Animal_Gull : Game_Animal_Bird
{
	public enum eMode
	{
		Clawl = 0,
		Soar = 1
	}

	private static readonly float sr_fXScale;

	private static readonly float sr_fYScale;

	private static readonly float sr_fZScale;

	private static readonly float sr_fXCycle;

	private static readonly float sr_fYCycle;

	private static readonly float sr_fZCycle;

	private static readonly float sr_fCycleDelta;

	private eMode m_eMode;

	private float m_fCycleTime;

	private Transform m_trSoarRoot;

	private List<Game_Animal_Gull> m_sPartyList;

	private bool m_bPartyTouched;

	public GameObject[] m_goPartyPos;

	protected override float m_waitSec_Min
	{
		get
		{
			return 0f;
		}
	}

	protected override float m_waitSec_Max
	{
		get
		{
			return 0f;
		}
	}

	public void SetParty(Game_Animal_Gull sMember)
	{
	}

	public void SetMode(eMode eKind, bool bParty = true)
	{
	}

	public void MakeParty()
	{
	}

	public override void InitializeAnimal()
	{
	}

	protected override List<Transform> GetOffsetChildList()
	{
		return null;
	}

	protected override void MoveOK_Init()
	{
	}

	protected override bool MoveOK_Fade()
	{
		return false;
	}

	protected override void MoveOK_Wait()
	{
	}

	protected void Soaring(float fCycleMulti = 1f)
	{
	}

	protected override void MoveOKWait_Animator()
	{
	}

	protected override bool IsMoveOKtoNG()
	{
		return false;
	}

	protected override void OnTouched()
	{
	}

	public void TouchedParty()
	{
	}
}
