using UnityEngine;

public class FX_FadeIO : MonoBehaviour
{
	public float waitSec_All;

	public float waitSec_Full;

	private float waitSec_Now;

	public float alphaPercent_Fade;

	public float alphaPercent_Max;

	public float alphaPercent_Min;

	private float alphaPercent_Now;

	private Renderer targetRenderer;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
