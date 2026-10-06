using CharaMotion;
using UnityEngine;

[ExecuteInEditMode]
public class Game_Enemy_FaceData : MonoBehaviour
{
	private class FaceData
	{
	}

	public Material m_targetMaterial;

	public Vector2[] m_UVOffset_Eye;

	public Vector2[] m_UVOffset_Mouth;

	private FaceMotionDataManager m_faceMotionData;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetFaceData(FaceMotionData[] dataArray, bool loopFlag = false)
	{
	}
}
