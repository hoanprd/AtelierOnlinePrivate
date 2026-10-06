namespace Photon.Chat
{
	public class AuthenticationValues
	{
		private CustomAuthenticationType authType;

		public CustomAuthenticationType AuthType
		{
			get
			{
				return CustomAuthenticationType.Custom;
			}
			set
			{
			}
		}

		public string AuthGetParameters { get; set; }

		public object AuthPostData { get; private set; }

		public string Token { get; set; }

		public string UserId { get; set; }

		public AuthenticationValues()
		{
		}

		public AuthenticationValues(string userId)
		{
		}

		public virtual void SetAuthPostData(string stringData)
		{
		}

		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		public virtual void AddAuthParameter(string key, string value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
