using UnityEngine;

public class ThrowMotion : StateMachineBehaviour
{
	public float createTime;

	public float throwTime;

	public GameObject makePrefab;

	private int m_step;

	private GameObject m_throwObject;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	private void OnDisable()
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	private void DestroyObject()
	{
	}
}
