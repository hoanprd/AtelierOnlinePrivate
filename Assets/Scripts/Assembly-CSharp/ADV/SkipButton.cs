using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace ADV
{
	public class SkipButton : MonoBehaviour
	{
		public UIButton m_sButton;

		public UITweenReset m_sAnim;

		private bool m_bSkip;

		private bool m_bEnable;

		private bool m_bFade;

		private bool m_bDialog;

		private bool m_bButtonActive;

		public bool IsSkip
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDialog
		{
			get
			{
				return false;
			}
		}

		public bool IsActive
		{
			get
			{
				return false;
			}
		}

		public void Init()
		{
		}

		public void Bringin()
		{
		}

		public void Dismiss()
		{
		}

		private void OnDismissEnd()
		{
		}

		public void SetEnable(bool enable)
		{
		}

		public void SetSkip(bool skip)
		{
		}

		public void OnSkip()
		{
		}

		[DebuggerHidden]
		private IEnumerator ChangeSkipOn()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator ChangeSkipOff()
		{
			return null;
		}
	}
}
