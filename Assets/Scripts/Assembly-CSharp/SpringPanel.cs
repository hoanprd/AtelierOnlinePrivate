using System;
using UnityEngine;

public class SpringPanel : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPanel current;

	public Vector3 target;

	public float strength;

	public OnFinished onFinished;

	[NonSerialized]
	private UIPanel mPanel;

	[NonSerialized]
	private Transform mTrans;

	[NonSerialized]
	private UIScrollView mDrag;

	[NonSerialized]
	private float mDelta;

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected virtual void AdvanceTowardsPosition()
	{
	}

	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	public static SpringPanel Stop(GameObject go)
	{
		return null;
	}
}
