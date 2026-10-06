namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCaptureState
	{
		private bool mIsCapturing;

		private VideoCaptureMode mCaptureMode;

		private VideoQualityLevel mQualityLevel;

		private bool mIsOverlayVisible;

		private bool mIsPaused;

		public bool IsCapturing
		{
			get
			{
				return false;
			}
		}

		public VideoCaptureMode CaptureMode
		{
			get
			{
				return VideoCaptureMode.File;
			}
		}

		public VideoQualityLevel QualityLevel
		{
			get
			{
				return VideoQualityLevel.SD;
			}
		}

		public bool IsOverlayVisible
		{
			get
			{
				return false;
			}
		}

		public bool IsPaused
		{
			get
			{
				return false;
			}
		}

		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
