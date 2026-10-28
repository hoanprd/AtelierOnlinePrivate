using System;
using UnityEngine;

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

		private static ProcessType m_process_type = ProcessType.None;

		private static AuthType m_auth_type = AuthType.GUEST;

		private static Action<bool> m_auth_callback;

		private const string KEY_PP_AUTH_TYPE = "HSP_AUTH_TYPE";

		private const string KEY_PP_AUTH_VER = "Auth_Ver";

		private const int AUTH_VERSION = 1;

		public static string ID
		{
			get
			{
				return PlayerPrefs.GetString(GameDefine.sKEY_USERID, "10000001");
			}
		}

		public static ProcessType Process
		{
			get
			{
				return m_process_type;
			}
			set
			{
				m_process_type = value;
			}
		}

		public static AuthType GetAuthType()
		{
			if (m_auth_type == AuthType.NONE || (int)m_auth_type == 0)
			{
				m_auth_type = GetSavedAuthType();
			}
			return m_auth_type;
		}

		public static AuthType GetSavedAuthType()
		{
			int saved = PlayerPrefs.GetInt(KEY_PP_AUTH_TYPE, (int)AuthType.GUEST);
			if (saved <= 0)
			{
				return AuthType.GUEST;
			}
			return (AuthType)saved;
		}

		public static void SaveAuthType()
		{
			if (m_auth_type == AuthType.NONE || (int)m_auth_type == 0)
			{
				m_auth_type = AuthType.GUEST;
			}
			PlayerPrefs.SetInt(KEY_PP_AUTH_TYPE, (int)m_auth_type);
			PlayerPrefs.SetInt(KEY_PP_AUTH_VER, AUTH_VERSION);
			PlayerPrefs.Save();
		}

		public static void RestoreAuthType()
		{
			m_auth_type = GetSavedAuthType();
		}

		public static void Failed(AuthType auth_type, Action callback)
		{
			m_auth_type = AuthType.GUEST;
			SaveAuthType();
			if (callback != null)
			{
				callback();
			}
		}

		public static bool IsLatestAuthVersion()
		{
			return true;
		}

		public static void OldVersionSupport(Action<bool> auth_callback)
		{
			PlayerPrefs.SetInt(KEY_PP_AUTH_VER, AUTH_VERSION);
			PlayerPrefs.Save();
			if (auth_callback != null)
			{
				auth_callback(true);
			}
		}

		public static void Authenticate(Action<bool> auth_callback)
		{
			m_process_type = ProcessType.None;
			m_auth_type = AuthType.GUEST;
			SaveAuthType();
			m_auth_callback = null;
			if (auth_callback != null)
			{
				auth_callback(true);
			}
		}

		private static IAuthentication GetInterface(AuthType auth_type)
		{
			return null;
		}

		private static void AdviceOtherAuthenticate(Action<bool> auth_callback)
		{
			if (auth_callback != null)
			{
				auth_callback(true);
			}
		}

		private static void RestoreAuthenticate(Action<bool> auth_callback)
		{
			RestoreAuthType();
			if (auth_callback != null)
			{
				auth_callback(true);
			}
		}

		public static void AuthenticateLinkageID(AuthType auth_type, Action<bool> auth_callback)
		{
			m_auth_type = auth_type;
			SaveAuthType();
			if (auth_callback != null)
			{
				auth_callback(true);
			}
		}

		public static void AuthenticateReleaseLinkageID(Action<bool> auth_callback)
		{
			m_auth_type = AuthType.GUEST;
			SaveAuthType();
			if (auth_callback != null)
			{
				auth_callback(true);
			}
		}

		public static void LoginCallback(bool is_success, string id)
		{
			if (m_auth_callback != null)
			{
				Action<bool> cb = m_auth_callback;
				m_auth_callback = null;
				cb(is_success);
			}
		}

		public static string GetAuthTypeString(AuthType auth_type)
		{
			switch (auth_type)
			{
			case AuthType.FACEBOOK:
				return "Facebook";
			case AuthType.GOOGLE:
				return "Google";
			case AuthType.SIWA:
				return "Apple";
			case AuthType.TWITTER:
				return "Twitter";
			default:
				return "Guest";
			}
		}

		private static void DialogClearAuthentication(AuthType clear_type, Action<EButtonKind> dialog_callback)
		{
			if (dialog_callback != null)
			{
				dialog_callback(EButtonKind.eDECIDE);
			}
		}

		public static void TemporaryAuthenticate()
		{
			m_auth_type = AuthType.GUEST;
			SaveAuthType();
		}
	}
}
