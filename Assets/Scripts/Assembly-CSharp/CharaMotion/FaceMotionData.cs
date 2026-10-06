using UnityEngine;

namespace CharaMotion
{
	public class FaceMotionData
	{
		public static readonly int waitFrame_Per;

		private int[] expKind;

		public int waitFrame;

		public static readonly Vector2[] m_faceExpUVDataArray_Eye;

		public static readonly Vector2[] m_faceExpUVDataArray_Mouth;

		public static readonly Vector2[][] m_faceExpUVDataArray_All;

		public FaceMotionData(int frame, eExpKind_Eye eye, eExpKind_Mouth mouth)
		{
		}

		public Vector2 GetExpKind(ePartsKind parts, Vector2[][] data = null)
		{
			return default(Vector2);
		}

		public float GetWaitSec()
		{
			return 0f;
		}
	}
}
