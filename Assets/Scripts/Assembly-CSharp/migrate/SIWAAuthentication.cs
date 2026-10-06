using System;
using UnityEngine.SignInWithApple;

namespace migrate
{
	internal class SIWAAuthentication : PhonePlatformAuthentication
	{
		private static SIWAAuthentication s_instance;

		private string userId;

		private bool m_bBAuthFlg;

		public override string ID
		{
			get
			{
				return null;
			}
		}

		private SIWAAuthentication()
		{
		}

		public static SIWAAuthentication GetInstance()
		{
			return null;
		}

		public bool isAuth()
		{
			return false;
		}

		public void resetAuth()
		{
		}

		public override void Init()
		{
		}

		public override void Authenticate(Action<bool, string> action)
		{
		}

		private void OnLogin(SignInWithApple.CallbackArgs args)
		{
		}
	}
}
