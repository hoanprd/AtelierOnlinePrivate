using System;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		internal PlayGamesPlatform mPlatform;

		private string emailAddress;

		private PlayerStats mStats;

		public IUserProfile[] friends
		{
			get
			{
				return null;
			}
		}

		public bool authenticated
		{
			get
			{
				return false;
			}
		}

		public bool underage
		{
			get
			{
				return false;
			}
		}

		public new string userName
		{
			get
			{
				return null;
			}
		}

		public new string id
		{
			get
			{
				return null;
			}
		}

		public new bool isFriend
		{
			get
			{
				return false;
			}
		}

		public new UserState state
		{
			get
			{
				return UserState.Online;
			}
		}

		public new string AvatarURL
		{
			get
			{
				return null;
			}
		}

		public string Email
		{
			get
			{
				return null;
			}
		}

		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
			: base(null, null, null)
		{
		}

		public void Authenticate(Action<bool> callback)
		{
		}

		public void Authenticate(Action<bool, string> callback)
		{
		}

		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		public void LoadFriends(Action<bool> callback)
		{
		}

		public string GetIdToken()
		{
			return null;
		}

		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}
	}
}
