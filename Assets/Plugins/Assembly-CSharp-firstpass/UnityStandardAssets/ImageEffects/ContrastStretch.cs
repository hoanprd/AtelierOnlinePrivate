using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		public float adaptationSpeed;

		public float limitMinimum;

		public float limitMaximum;

		private RenderTexture[] adaptRenderTex;

		private int curAdaptIndex;

		public Shader shaderLum;

		private Material m_materialLum;

		public Shader shaderReduce;

		private Material m_materialReduce;

		public Shader shaderAdapt;

		private Material m_materialAdapt;

		public Shader shaderApply;

		private Material m_materialApply;

		protected Material materialLum
		{
			get
			{
				return null;
			}
		}

		protected Material materialReduce
		{
			get
			{
				return null;
			}
		}

		protected Material materialAdapt
		{
			get
			{
				return null;
			}
		}

		protected Material materialApply
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void CalculateAdaptation(Texture curTexture)
		{
		}
	}
}
