using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace ADV
{
	public class Background : MonoBehaviour
	{
		public UITexture m_txPicture;

		public UILabel m_sPlaceName;

		public UILabel m_sPlaceName2;

		public UITweenReset m_sAnim;

		public UITweenReset m_sShakeAnim;

		private float m_fShakeTime;

		private int m_iShakeCount;

		public bool IsAnimEnd
		{
			get
			{
				return false;
			}
		}

		public static string GetImagePath(int picID)
		{
			return null;
		}

		public void Init()
		{
		}

		public void SetPicture(int picID)
		{
		}

		public void SetShake(float time, int count)
		{
		}

		public void StopShake()
		{
		}

		public void SetName(string main, string sub = "")
		{
		}

		public void Bringin()
		{
		}

		public void Dismiss()
		{
		}

		public void SetFinish()
		{
		}

		private void OnCloseEnd()
		{
		}

		[DebuggerHidden]
		private IEnumerator ShakePicture()
		{
			return null;
		}
	}
}
