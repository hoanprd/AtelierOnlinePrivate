using System;

namespace migrate
{
	public class AuthenticationManager
	{
		public enum ProcessType
		{
			None = 0,
			Auth = 1,
			Linkage = 2,
			ReleaseLinkage = 3,
			Restore = 4
		}

		public enum AuthType
		{
			NONE = -1,
			FACEBOOK = 2,
			GOOGLE = 4,
			GUEST = 14,
			SIWA = 20,
			TWITTER = 24
		}

		private static ProcessType m_process_type;

		private static AuthType m_auth_type;

		private static Action<bool> m_auth_callback;

		private const string KEY_PP_AUTH_TYPE = "HSP_AUTH_TYPE";

		private const string KEY_PP_AUTH_VER = "Auth_Ver";

		private const int AUTH_VERSION = 1;

		public static string ID
		{
			get
			{
				return null;
			}
		}

		public static ProcessType Process
		{
			get
			{
				return ProcessType.None;
			}
			set
			{
			}
		}

		public static AuthType GetAuthType()
		{
			return (AuthType)0;
		}

		public static AuthType GetSavedAuthType()
		{
			return (AuthType)0;
		}

		public static void SaveAuthType()
		{
		}

		public static void RestoreAuthType()
		{
		}

		public static void Failed(AuthType auth_type, Action callback)
		{
		}

		public static bool IsLatestAuthVersion()
		{
			return false;
		}

		public static void OldVersionSupport(Action<bool> auth_callback)
		{
		}

		public static void Authenticate(Action<bool> auth_callback)
		{
		}

		private static IAuthentication GetInterface(AuthType auth_type)
		{
			return null;
		}

		private static void AdviceOtherAuthenticate(Action<bool> auth_callback)
		{
		}

		private static void RestoreAuthenticate(Action<bool> auth_callback)
		{
		}

		public static void AuthenticateLinkageID(AuthType auth_type, Action<bool> auth_callback)
		{
		}

		public static void AuthenticateReleaseLinkageID(Action<bool> auth_callback)
		{
		}

		public static void LoginCallback(bool is_success, string id)
		{
		}

		public static string GetAuthTypeString(AuthType auth_type)
		{
			return null;
		}

		private static void DialogClearAuthentication(AuthType clear_type, Action<EButtonKind> dialog_callback)
		{
		}

		public static void TemporaryAuthenticate()
		{
		}
	}
}
