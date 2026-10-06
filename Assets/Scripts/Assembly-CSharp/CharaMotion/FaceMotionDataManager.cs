namespace CharaMotion
{
	public class FaceMotionDataManager
	{
		private FaceMotionData[] faceDataArray;

		private int currentDataID;

		private float currentSec;

		private bool loopFlag;

		public FaceMotionDataManager(FaceMotionData[] dataArray, bool loopFlag = false)
		{
		}

		public bool UpdateMotion()
		{
			return false;
		}

		public FaceMotionData GetCurrentData()
		{
			return null;
		}
	}
}
