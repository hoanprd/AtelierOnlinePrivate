using System;

namespace migrate
{
	internal class GooglePlayAuthentication : PhonePlatformAuthentication
	{
		private static GooglePlayAuthentication s_instance;

		public override string ID
		{
			get
			{
				return null;
			}
		}

		private GooglePlayAuthentication()
		{
		}

		public static GooglePlayAuthentication GetInstance()
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
