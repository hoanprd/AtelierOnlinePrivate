using System;

namespace GooglePlayGames.BasicApi.SavedGame
{
	public struct SavedGameMetadataUpdate
	{
		public struct Builder
		{
			internal bool mDescriptionUpdated;

			internal string mNewDescription;

			internal bool mCoverImageUpdated;

			internal byte[] mNewPngCoverImage;

			internal TimeSpan? mNewPlayedTime;

			public Builder WithUpdatedDescription(string description)
			{
				return default(Builder);
			}

			public Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(Builder);
			}

			public Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(Builder);
			}

			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}
		}

		private readonly bool mDescriptionUpdated;

		private readonly string mNewDescription;

		private readonly bool mCoverImageUpdated;

		private readonly byte[] mNewPngCoverImage;

		private readonly TimeSpan? mNewPlayedTime;

		public bool IsDescriptionUpdated
		{
			get
			{
				return false;
			}
		}

		public string UpdatedDescription
		{
			get
			{
				return null;
			}
		}

		public bool IsCoverImageUpdated
		{
			get
			{
				return false;
			}
		}

		public byte[] UpdatedPngCoverImage
		{
			get
			{
				return null;
			}
		}

		public bool IsPlayedTimeUpdated
		{
			get
			{
				return false;
			}
		}

		public TimeSpan? UpdatedPlayedTime
		{
			get
			{
				return null;
			}
		}

		private SavedGameMetadataUpdate(Builder builder)
		{
			mDescriptionUpdated = false;
			mNewDescription = null;
			mCoverImageUpdated = false;
			mNewPngCoverImage = null;
			mNewPlayedTime = null;
		}
	}
}
