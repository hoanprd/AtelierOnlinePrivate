using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		public float blurAmount;

		public bool extraBlur;

		private RenderTexture accumTexture;

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
