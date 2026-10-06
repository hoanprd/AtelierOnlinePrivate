using System.Collections.Generic;
using UnityEngine;

public class FX_GameTime_Color : MonoBehaviour
{
	public bool updateChild;

	public float[] alphaValArray;

	private float alphaVal_Now;

	private float changeSpeed;

	private List<Renderer> targetRendererList;

	private void Awake()
	{
	}

	private void GetRenderer(Transform parent, bool checkChild)
	{
	}

	private void Update()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	private bool IsDisp(float alpha)
	{
		return false;
	}
}
