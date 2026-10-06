using CharaMotion;
using UnityEngine;

public class Game_Chara_MA_NPC : Game_Chara_MA_Base
{
	private Vector3 m_moveTarget;

	private bool m_move;

	private bool m_targetChara;

	private bool m_autoRotation;

	private float m_rotation;

	private float m_addPosZ;

	private bool m_agentRotation;

	protected override eCharaShaderGroupKind GetShaderGroupKind()
	{
		return eCharaShaderGroupKind.Normal;
	}

	protected override void Initialize()
	{
	}

	public void SetRotation(float rot)
	{
	}

	public void SetEnableAgentRotation(bool enable)
	{
	}

	public bool IsMove()
	{
		return false;
	}

	public bool IsMotionEnd(eMotionKind kind)
	{
		return false;
	}

	protected override void InitMove()
	{
	}

	protected override void CheckMove()
	{
	}

	protected override void UpdateMove()
	{
	}

	protected override void MoverUpdate_Pause()
	{
	}

	public override void ForceAddPos(float value = 0f)
	{
	}

	public override void SetAgent(bool enable = true)
	{
	}
}
