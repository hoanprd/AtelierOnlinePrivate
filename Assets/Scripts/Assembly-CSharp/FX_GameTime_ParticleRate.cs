using System.Collections.Generic;
using UnityEngine;

public class FX_GameTime_ParticleRate : MonoBehaviour
{
	public bool updateChild;

	public int[] emissionNumArray;

	private float emissionNum_Original;

	private int emissionNum_Now;

	private int emissionNum_Prev;

	public float changeSec_Max;

	private float changeSec_Now;

	private List<ParticleSystem> targetParticleList;

	private bool initialized;

	private void Start()
	{
	}

	public void Initialize(bool checkChild)
	{
	}

	private void GetParticles(Transform parent, bool checkChild)
	{
	}

	private void Update()
	{
	}

	private void UpdateEmissionRate(bool forceUpdate)
	{
	}

	public float GetEmissionRate_Original()
	{
		return 0f;
	}

	public void SetEmissionRate(int time, float rate)
	{
	}

	public void SetEmissionRateAll(float rate)
	{
	}
}
