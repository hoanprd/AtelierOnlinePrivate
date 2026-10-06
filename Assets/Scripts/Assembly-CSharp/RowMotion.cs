using UnityEngine;

public class RowMotion : StateMachineBehaviour
{
	[SerializeField]
	private float m_fMakeTime;

	[SerializeField]
	private GameObject m_goOarPrefab;

	private GameObject m_goMakeObj;

	private bool m_bMade;

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
