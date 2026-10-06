using System;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidSnapshotMetadata : ISavedGameMetadata
	{
		private AndroidJavaObject mJavaSnapshot;

		private AndroidJavaObject mJavaMetadata;

		private AndroidJavaObject mJavaContents;

		public AndroidJavaObject JavaSnapshot
		{
			get
			{
				return null;
			}
		}

		public AndroidJavaObject JavaMetadata
		{
			get
			{
				return null;
			}
		}

		public AndroidJavaObject JavaContents
		{
			get
			{
				return null;
			}
		}

		public bool IsOpen
		{
			get
			{
				return false;
			}
		}

		public string Filename
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

		public string CoverImageURL
		{
			get
			{
				return null;
			}
		}

		public TimeSpan TotalTimePlayed
		{
			get
			{
				return default(TimeSpan);
			}
		}

		public DateTime LastModifiedTimestamp
		{
			get
			{
				return default(DateTime);
			}
		}

		public AndroidSnapshotMetadata(AndroidJavaObject javaSnapshot)
		{
		}

		public AndroidSnapshotMetadata(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents)
		{
		}
	}
}
