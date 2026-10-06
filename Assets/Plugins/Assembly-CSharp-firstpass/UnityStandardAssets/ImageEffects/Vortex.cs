using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class Vortex : ImageEffectBase
	{
		public Vector2 radius;

		public float angle;

		public Vector2 center;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
