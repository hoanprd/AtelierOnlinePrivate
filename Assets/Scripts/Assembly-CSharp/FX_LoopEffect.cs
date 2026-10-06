using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class FX_LoopEffect : MonoBehaviour
{
	private ParticleSystem m_sParticle;

	private void Awake()
	{
	}

	public void Stop()
	{
	}

	[DebuggerHidden]
	private IEnumerator CheckStop()
	{
		return null;
	}
}
