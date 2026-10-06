using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss = 0,
			SgxGauss = 1
		}

		public int downsample;

		public float blurSize;

		public int blurIterations;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		public void OnDisable()
		{
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
