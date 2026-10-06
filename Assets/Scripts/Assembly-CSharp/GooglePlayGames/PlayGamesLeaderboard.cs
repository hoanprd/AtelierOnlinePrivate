using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLeaderboard : ILeaderboard
	{
		private string mId;

		private UserScope mUserScope;

		private Range mRange;

		private TimeScope mTimeScope;

		private string[] mFilteredUserIds;

		private bool mLoading;

		private IScore mLocalUserScore;

		private uint mMaxRange;

		private List<PlayGamesScore> mScoreList;

		private string mTitle;

		public bool loading
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public string id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserScope userScope
		{
			get
			{
				return UserScope.Global;
			}
			set
			{
			}
		}

		public Range range
		{
			get
			{
				return default(Range);
			}
			set
			{
			}
		}

		public TimeScope timeScope
		{
			get
			{
				return TimeScope.Today;
			}
			set
			{
			}
		}

		public IScore localUserScore
		{
			get
			{
				return null;
			}
		}

		public uint maxRange
		{
			get
			{
				return 0u;
			}
		}

		public IScore[] scores
		{
			get
			{
				return null;
			}
		}

		public string title
		{
			get
			{
				return null;
			}
		}

		public int ScoreCount
		{
			get
			{
				return 0;
			}
		}

		public PlayGamesLeaderboard(string id)
		{
		}

		public void SetUserFilter(string[] userIDs)
		{
		}

		public void LoadScores(Action<bool> callback)
		{
		}

		internal bool SetFromData(LeaderboardScoreData data)
		{
			return false;
		}

		internal void SetMaxRange(ulong val)
		{
		}

		internal void SetTitle(string value)
		{
		}

		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		internal int AddScore(PlayGamesScore score)
		{
			return 0;
		}

		internal bool HasAllScores()
		{
			return false;
		}
	}
}
