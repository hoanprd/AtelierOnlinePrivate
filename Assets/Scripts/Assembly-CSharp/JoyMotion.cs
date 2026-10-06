using UnityEngine;

public class JoyMotion : StateMachineBehaviour
{
	public float m_fEffectTime;

	private bool m_bEffect;

	private GameObject m_goEffect;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
