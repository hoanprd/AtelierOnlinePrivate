using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesScore : IScore
	{
		private string mLbId;

		private long mValue;

		private ulong mRank;

		private string mPlayerId;

		private string mMetadata;

		private DateTime mDate;

		public string leaderboardID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long value
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public DateTime date
		{
			get
			{
				return default(DateTime);
			}
		}

		public string formattedValue
		{
			get
			{
				return null;
			}
		}

		public string userID
		{
			get
			{
				return null;
			}
		}

		public int rank
		{
			get
			{
				return 0;
			}
		}

		public string metaData
		{
			get
			{
				return null;
			}
		}

		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		public void ReportScore(Action<bool> callback)
		{
		}
	}
}
