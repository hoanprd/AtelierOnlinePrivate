using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
