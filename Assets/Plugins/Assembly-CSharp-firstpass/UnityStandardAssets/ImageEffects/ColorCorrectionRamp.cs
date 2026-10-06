using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		public Texture textureRamp;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
