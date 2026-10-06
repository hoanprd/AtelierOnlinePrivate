namespace GooglePlayGames.BasicApi.Events
{
	internal class Event : IEvent
	{
		private string mId;

		private string mName;

		private string mDescription;

		private string mImageUrl;

		private ulong mCurrentCount;

		private EventVisibility mVisibility;

		public string Id
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
		}

		public string ImageUrl
		{
			get
			{
				return null;
			}
		}

		public ulong CurrentCount
		{
			get
			{
				return 0uL;
			}
		}

		public EventVisibility Visibility
		{
			get
			{
				return (EventVisibility)0;
			}
		}

		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility)
		{
		}
	}
}
