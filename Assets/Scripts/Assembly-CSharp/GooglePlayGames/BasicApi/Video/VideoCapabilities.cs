namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCapabilities
	{
		private bool mIsCameraSupported;

		private bool mIsMicSupported;

		private bool mIsWriteStorageSupported;

		private bool[] mCaptureModesSupported;

		private bool[] mQualityLevelsSupported;

		public bool IsCameraSupported
		{
			get
			{
				return false;
			}
		}

		public bool IsMicSupported
		{
			get
			{
				return false;
			}
		}

		public bool IsWriteStorageSupported
		{
			get
			{
				return false;
			}
		}

		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return false;
		}

		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
