using UnityEngine;

public class PickupMotion : MonoBehaviour
{
	public float SpinSpeed;

	public float BobSpeed;

	public float BobDistance;

	private Vector3 positionOffset;

	protected virtual void Update()
	{
	}
}
public class PickUpMotion : StateMachineBehaviour
{
	public float startTime;

	public float endTime;

	private bool m_bTool;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
