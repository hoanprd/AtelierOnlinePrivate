namespace GooglePlayGames.BasicApi
{
	public class ScorePageToken
	{
		private string mId;

		private object mInternalObject;

		private LeaderboardCollection mCollection;

		private LeaderboardTimeSpan mTimespan;

		private ScorePageDirection mDirection;

		public LeaderboardCollection Collection
		{
			get
			{
				return (LeaderboardCollection)0;
			}
		}

		public LeaderboardTimeSpan TimeSpan
		{
			get
			{
				return (LeaderboardTimeSpan)0;
			}
		}

		public ScorePageDirection Direction
		{
			get
			{
				return (ScorePageDirection)0;
			}
		}

		public string LeaderboardId
		{
			get
			{
				return null;
			}
		}

		internal object InternalObject
		{
			get
			{
				return null;
			}
		}

		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction)
		{
		}
	}
}
