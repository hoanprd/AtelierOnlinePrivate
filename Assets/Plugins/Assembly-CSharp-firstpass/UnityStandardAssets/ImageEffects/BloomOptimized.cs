using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low = 0,
			High = 1
		}

		public enum BlurType
		{
			Standard = 0,
			Sgx = 1
		}

		public float threshold;

		public float intensity;

		public float blurSize;

		private Resolution resolution;

		public int blurIterations;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
