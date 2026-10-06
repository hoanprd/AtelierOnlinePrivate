using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesUserProfile : IUserProfile
	{
		private string mDisplayName;

		private string mPlayerId;

		private string mAvatarUrl;

		private bool mImageLoading;

		private Texture2D mImage;

		public string userName
		{
			get
			{
				return null;
			}
		}

		public string id
		{
			get
			{
				return null;
			}
		}

		public string gameId
		{
			get
			{
				return null;
			}
		}

		public bool isFriend
		{
			get
			{
				return false;
			}
		}

		public UserState state
		{
			get
			{
				return UserState.Online;
			}
		}

		public Texture2D image
		{
			get
			{
				return null;
			}
		}

		public string AvatarURL
		{
			get
			{
				return null;
			}
		}

		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		[DebuggerHidden]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		private void setAvatarUrl(string avatarUrl)
		{
		}
	}
}
