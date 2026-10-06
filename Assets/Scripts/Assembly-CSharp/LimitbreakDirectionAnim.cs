using System;
using UnityEngine;

public class LimitbreakDirectionAnim : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	private Action m_sMoveFowardEvent;

	private Action m_sAddStarEvent;

	private Action m_sFinishEvent;

	public void Init()
	{
	}

	public void PlayInAnim()
	{
	}

	public void PlayOutAnim(GameObject target, string endEvent)
	{
	}

	public void AddEvent(Action moveFoward, Action addStar, Action onFinish)
	{
	}

	private void OnMoveFowardEvent()
	{
	}

	private void OnAddStarEvent()
	{
	}

	private void OnFinishEvent()
	{
	}
}
