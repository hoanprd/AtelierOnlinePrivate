using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace migrate
{
	internal class PhonePlatformAuthentication : IAuthentication
	{
		protected const int m_wait_time = 3;

		protected Action<bool, string> m_auth_callback;

		protected bool m_is_running;

		protected Coroutine m_timeout_coroutine;

		public virtual string ID
		{
			get
			{
				return null;
			}
		}

		public virtual void Init()
		{
		}

		public virtual void Authenticate(Action<bool, string> action)
		{
		}

		protected virtual void AuthenticationCallback(bool success)
		{
		}

		public void Failed(Action callback)
		{
		}

		protected void SetTimeout(int minutes)
		{
		}

		[DebuggerHidden]
		protected IEnumerator TimeoutObserver(int minutes)
		{
			return null;
		}

		protected void ResetTimeout()
		{
		}
	}
}
