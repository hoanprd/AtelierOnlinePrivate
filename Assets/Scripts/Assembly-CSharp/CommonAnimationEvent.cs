using System;
using UnityEngine;

public class CommonAnimationEvent : MonoBehaviour
{
	[SerializeField]
	private Action<eSoundID> m_sNotify;

	public void Init(Action<eSoundID> target)
	{
	}

	public void PlaySE(eSoundID id)
	{
	}
}
