using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	internal class GlobalFog : PostEffectsBase
	{
		public bool distanceFog;

		public bool excludeFarPixels;

		public bool useRadialDistance;

		public bool heightFog;

		public float height;

		public float heightDensity;

		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}
	}
}
