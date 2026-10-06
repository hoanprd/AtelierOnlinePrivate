using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		public float intensity;

		public float radius;

		public int blurIterations;

		public float blurFilterDistance;

		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
