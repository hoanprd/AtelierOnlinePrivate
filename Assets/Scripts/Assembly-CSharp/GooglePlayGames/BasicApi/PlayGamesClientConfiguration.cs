using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;

namespace GooglePlayGames.BasicApi
{
	public struct PlayGamesClientConfiguration
	{
		public class Builder
		{
			private bool mEnableSaveGames;

			private List<string> mScopes;

			private bool mHidePopups;

			private bool mRequestAuthCode;

			private bool mForceRefresh;

			private bool mRequestEmail;

			private bool mRequestIdToken;

			private string mAccountName;

			private InvitationReceivedDelegate mInvitationDelegate;

			private MatchDelegate mMatchDelegate;

			public Builder EnableSavedGames()
			{
				return null;
			}

			public Builder EnableHidePopups()
			{
				return null;
			}

			public Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			public Builder RequestEmail()
			{
				return null;
			}

			public Builder RequestIdToken()
			{
				return null;
			}

			public Builder SetAccountName(string accountName)
			{
				return null;
			}

			public Builder AddOauthScope(string scope)
			{
				return null;
			}

			public Builder WithInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
			{
				return null;
			}

			public Builder WithMatchDelegate(MatchDelegate matchDelegate)
			{
				return null;
			}

			public PlayGamesClientConfiguration Build()
			{
				return default(PlayGamesClientConfiguration);
			}

			internal bool HasEnableSaveGames()
			{
				return false;
			}

			internal bool IsRequestingAuthCode()
			{
				return false;
			}

			internal bool IsHidingPopups()
			{
				return false;
			}

			internal bool IsForcingRefresh()
			{
				return false;
			}

			internal bool IsRequestingEmail()
			{
				return false;
			}

			internal bool IsRequestingIdToken()
			{
				return false;
			}

			internal string GetAccountName()
			{
				return null;
			}

			internal string[] getScopes()
			{
				return null;
			}

			internal MatchDelegate GetMatchDelegate()
			{
				return null;
			}

			internal InvitationReceivedDelegate GetInvitationDelegate()
			{
				return null;
			}
		}

		public static readonly PlayGamesClientConfiguration DefaultConfiguration;

		private readonly bool mEnableSavedGames;

		private readonly string[] mScopes;

		private readonly bool mRequestAuthCode;

		private readonly bool mForceRefresh;

		private readonly bool mHidePopups;

		private readonly bool mRequestEmail;

		private readonly bool mRequestIdToken;

		private readonly string mAccountName;

		private readonly InvitationReceivedDelegate mInvitationDelegate;

		private readonly MatchDelegate mMatchDelegate;

		public bool EnableSavedGames
		{
			get
			{
				return false;
			}
		}

		public bool IsHidingPopups
		{
			get
			{
				return false;
			}
		}

		public bool IsRequestingAuthCode
		{
			get
			{
				return false;
			}
		}

		public bool IsForcingRefresh
		{
			get
			{
				return false;
			}
		}

		public bool IsRequestingEmail
		{
			get
			{
				return false;
			}
		}

		public bool IsRequestingIdToken
		{
			get
			{
				return false;
			}
		}

		public string AccountName
		{
			get
			{
				return null;
			}
		}

		public string[] Scopes
		{
			get
			{
				return null;
			}
		}

		public InvitationReceivedDelegate InvitationDelegate
		{
			get
			{
				return null;
			}
		}

		public MatchDelegate MatchDelegate
		{
			get
			{
				return null;
			}
		}

		private PlayGamesClientConfiguration(Builder builder)
		{
			mEnableSavedGames = false;
			mScopes = null;
			mRequestAuthCode = false;
			mForceRefresh = false;
			mHidePopups = false;
			mRequestEmail = false;
			mRequestIdToken = false;
			mAccountName = null;
			mInvitationDelegate = null;
			mMatchDelegate = null;
		}

		public static bool operator ==(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return false;
		}

		public static bool operator !=(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
