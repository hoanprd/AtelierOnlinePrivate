using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class ADVMoveObj : MonoBehaviour
{
	public enum eSimpleMove
	{
		First = 0,
		Rotate_Init = 1,
		Rotate_Wait = 2,
		Start = 3,
		FullSpeed = 4,
		Last = 5,
		End = 6
	}

	public enum eObjKind
	{
		Other = 0,
		NPC = 1,
		Enemy = 2
	}

	public enum eState
	{
		None = 0,
		Walk = 1,
		Dash = 2
	}

	public enum eCallBack
	{
		Walk = 0,
		Dash = 1,
		End = 2
	}

	private static readonly float sr_fDashSpeed;

	private static readonly float sr_fDecelTime;

	private static readonly float sr_fRotTime;

	private static readonly float sr_fAutoMag;

	private eObjKind m_eObjKind;

	private Vector3 m_v3Target;

	private bool m_bAutoMove;

	private bool m_bUseAgent;

	private eState m_eState;

	private bool m_bFirstFull;

	private bool m_bEndFull;

	private Action m_acOnWalk;

	private Action m_acOnDash;

	private Action m_acOnEnd;

	private bool m_bEndWarp;

	private bool m_bForceReset;

	private Coroutine m_cCoroutine;

	private bool m_bRotate;

	private bool m_bAutoPlay_Log;

	private float m_fOrgSpeed;

	private float m_fNowDashSpeed;

	private bool m_bADVObj;

	private NavMeshAgent m_scrAgent;

	private float m_fAccelOrg;

	private eSimpleMove m_eSimpleStep;

	private Vector3 m_v3MoveVec;

	private float m_fFullSpeed;

	private float m_fNowSpeed;

	protected void Update()
	{
	}

	private void CheckAutoPlay()
	{
	}

	protected void CallBack(eCallBack eKind)
	{
	}

	public void SetADVObj(bool bADV)
	{
	}

	public void SetAutoMove(Vector3 target, float speed, bool useNavmesh, bool firstFull, bool endFull, bool rotate, eObjKind eKind, Action acOnWalk, Action acOnDash, Action acOnEnd)
	{
	}

	[DebuggerHidden]
	private IEnumerator SetAutoMove_(Vector3 target, float speed, bool useNavmesh, bool firstFull, bool endFull, bool rotate, eObjKind eKind, Action acOnWalk, Action acOnDash, Action acOnEnd)
	{
		return null;
	}

	public bool IsAutoMoveEnd()
	{
		return false;
	}

	public void ForceEnd()
	{
	}

	public void SetAgent(NavMeshAgent scrAgent)
	{
	}

	public bool IsMove()
	{
		return false;
	}
}
