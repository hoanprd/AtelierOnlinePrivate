using CharaMotion;
using UnityEngine;

public class Game_Chara_FacialAnime : MonoBehaviour
{
	private Material m_targetMaterial_Face;

	private bool m_waitSec_Blink_Open;

	private float m_waitSec_Blink_Now;

	private float m_waitSec_Blink_Close_Min;

	private float m_waitSec_Blink_Close_Max;

	private float m_waitSec_Blink_Open_Min;

	private float m_waitSec_Blink_Open_Max;

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

	private Material GetMaterial(GameObject target)
	{
		return null;
	}
}
