using System;

namespace migrate
{
	internal class GameCenterAuthentication : PhonePlatformAuthentication
	{
		private static GameCenterAuthentication s_instance;

		public override string ID
		{
			get
			{
				return null;
			}
		}

		private GameCenterAuthentication()
		{
		}

		public static GameCenterAuthentication GetInstance()
		{
			return null;
		}

		public override void Init()
		{
		}

		public override void Authenticate(Action<bool, string> action)
		{
		}

		protected override void AuthenticationCallback(bool success)
		{
		}
	}
}
