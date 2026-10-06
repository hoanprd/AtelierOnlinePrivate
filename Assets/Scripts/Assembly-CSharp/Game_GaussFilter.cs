using UnityEngine;

[ExecuteInEditMode]
public class Game_GaussFilter : MonoBehaviour
{
	private Material material;

	[SerializeField]
	private int resolution;

	public int Resolution
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private float[] CalcWeight(float dispersion, int count)
	{
		return null;
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
