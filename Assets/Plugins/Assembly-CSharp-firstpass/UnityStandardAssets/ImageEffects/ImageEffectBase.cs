using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material
		{
			get
			{
				return null;
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
