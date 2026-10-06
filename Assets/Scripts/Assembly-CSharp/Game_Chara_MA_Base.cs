using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class Game_Chara_MA_Base : Game_Chara_Base
{
	protected enum eFootEffPos
	{
		Main = 0,
		Sub = 1,
		EnumMax = 2
	}

	protected static readonly float m_soundDistNear;

	protected static readonly float m_soundFistFar;

	public float m_addPos_Scale;

	protected float m_waitSec_DashEffect_Now;

	protected float m_waitSec_DashEffect_Max;

	protected float m_addPosZ_Now;

	protected float m_animationSpeed_Now;

	protected NavMeshAgent m_agent;

	public static readonly float m_flyingPosY;

	public static readonly float m_boader_IdleToWalk;

	public static readonly float m_boader_WalkToRun;

	protected bool m_autoMove_EnableFlag;

	protected Vector3 m_autoMove_TargetPos;

	protected Vector3 m_autoMove_PosLog;

	protected float m_autoMove_StopSec_Now;

	private Coroutine m_emoteCoroutine;

	protected const float m_moveSpeedMagDef = 1f;

	protected float m_moveSpeedMag;

	protected Vector2 m_moveSpeedMagDir;

	protected bool m_activeFlag;

	protected Rigidbody m_rigidbody;

	protected Collider m_collider;

	protected eFootSoundKind m_footSE;

	protected eFootSoundKind m_footSE_Navmesh;

	protected eEffectKind m_footEffKind;

	protected GameObject m_footEffObj;

	protected GameObject m_footEffObjSub;

	protected ParticleSystem m_footEffect;

	protected ParticleSystem m_footEffectSub;

	protected eFootEffPos m_footEffPos;

	protected NavMeshHit m_navmeshHit;

	protected eFootSoundKind NowFootSE
	{
		get
		{
			return eFootSoundKind.Default;
		}
	}

	protected eEffectKind NowFootEffect
	{
		get
		{
			return eEffectKind.Touch_Hit;
		}
	}

	public bool AutoMove_EnableFlag
	{
		get
		{
			return false;
		}
	}

	public Collider Collider
	{
		get
		{
			return null;
		}
	}

	public Rigidbody Rigidbody
	{
		get
		{
			return null;
		}
	}

	public void SetFootSoundKind(eFootSoundKind kind, bool navMesh)
	{
	}

	public void SetFootEffectKind(eEffectKind kind, bool navMesh)
	{
	}

	public void UseGravity(bool enable)
	{
	}

	public float GetSpeed()
	{
		return 0f;
	}

	protected override void Awake()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override Vector3 GetBillboardRot()
	{
		return default(Vector3);
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected virtual void InitMove()
	{
	}

	protected virtual void CheckMove()
	{
	}

	protected virtual void UpdateMove()
	{
	}

	public override void StartRotate(Vector3 target, float rotTime = 0.2f)
	{
	}

	protected void SetDrawObjects()
	{
	}

	protected void SetActiveFootEffect(bool active)
	{
	}

	protected GameObject GetSoundListener()
	{
		return null;
	}

	protected virtual void SetAnimator()
	{
	}

	protected override void InitAnim()
	{
	}

	public void Rebind()
	{
	}

	public bool IsFlying()
	{
		return false;
	}

	public void SetOverHeadIcon(eOverHeadPos pos, eOverHeadIcon eIcon, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
	}

	public GameObject SetOverHeadIcon(bool flag, eOverHeadPos pos, eOverHeadIcon icon = eOverHeadIcon.EnumMax, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
		return null;
	}

	public virtual GameObject SetOverHeadEmote(bool flag, eOverHeadPos pos, EEmoticon emote = EEmoticon.eNONE, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
		return null;
	}

	public void RemoveOverHeadIcon(eOverHeadPos pos)
	{
	}

	public void SetOverHeadEmote(EEmoticon emote, float time)
	{
	}

	[DebuggerHidden]
	private IEnumerator StartEmote(EEmoticon emote, float time)
	{
		return null;
	}

	public override void MakeCharaObject(MakeCharaData data, bool springFlag, bool ignoreOptionParts = false, eAnimator anim = eAnimator.EnumMax)
	{
	}

	public void SetAnimeMotionStep(int stepId)
	{
	}

	public void SetAnimeTrigger_Adventure(int kind, float loopNum = 0f)
	{
	}

	public virtual void SetAnimeFlag(eFlagMotion kind, bool flag)
	{
	}

	public virtual bool IsAdventureAnim()
	{
		return false;
	}

	public virtual void ForceAddPos(float value = 0f)
	{
	}

	public void SetSpeedZ(float addPosZ)
	{
	}

	public virtual void SetAgent(bool enable = true)
	{
	}

	public void SetAvoidancePriority(int priority)
	{
	}

	public void SetEnableAgent(bool enable)
	{
	}

	public bool IsExistAgentPath()
	{
		return false;
	}

	public bool IsAgentHasPass()
	{
		return false;
	}

	public NavMeshAgent GetAgent()
	{
		return null;
	}

	public NavMeshPath CalcNevmeshPath(Vector3 pos)
	{
		return null;
	}

	public bool IsOnNavmesh()
	{
		return false;
	}

	public bool IsAutoMove()
	{
		return false;
	}

	public void SetMoveSpeedMag(float mag = 1f)
	{
	}

	public void SetMoveSpeedMagDir(Vector2 dir)
	{
	}

	public virtual void SetActive(bool active)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void UpdateFootArea()
	{
	}

	public static Quaternion GetRotation(float rotationY)
	{
		return default(Quaternion);
	}

	public static float GetRotationY(Quaternion rotation)
	{
		return 0f;
	}
}
