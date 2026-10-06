using System.Collections.Generic;
using UnityEngine;

public class Game_BA_CameraManager : MonoBehaviour
{
	public enum eCameraSize
	{
		Small = 0,
		Medium = 1,
		Large = 2
	}

	public enum eCameraMode
	{
		First = 0,
		Normal = 1,
		Stalk = 2
	}

	public enum eStalkDataKind
	{
		Camera = 0,
		Target = 1,
		EnumMax = 2
	}

	private static Game_BA_CameraManager m_inst;

	private eCameraMode m_cameraMode_Now;

	private eCameraMode m_cameraMode_Req;

	[SerializeField]
	private List<CameraSize> m_sizeList;

	private CameraMoveData[] m_stalkDataArray;

	public Camera[] m_cameraMain;

	private Transform m_cameraParent;

	public Animation m_cameraAnimation;

	private float m_cameraFov_Now;

	private float m_cameraFov_Req;

	private static readonly float m_cameraFov_Skill;

	private float m_cameraFov_Default;

	private bool m_stalkCameraReq_CutFlag;

	private Vector3 m_shakeEffect_Dir;

	private float m_shakeEffect_Magnitude;

	private float m_shakeEffect_RestSec_Now;

	private float m_shakeEffect_RestSec_Max;

	private Vector3 m_slideEffect_AddCamPos_Log;

	private Vector3 m_slideEffect_AddCamPos_Now;

	private Vector3 m_slideEffect_AddCamPos_Add;

	private float m_slideEffect_RestSec_Now;

	private float m_slideEffect_RestSec_Max;

	private float m_normalRotY_Now;

	public float m_normalRotY_Default;

	public float m_normalRotY_RotPerSec;

	private float m_waitSec_Now;

	private Vector3 m_centerPosition;

	private Vector3 m_normal_Child_Pos;

	public Vector3 m_normal_Child_Rot;

	public float m_cameraAreaHigh;

	public float m_cameraAreaLow;

	public float m_normal_Child_Length;

	public bool IsPauseUpdate;

	public bool repositionNow;

	private Vector3 m_cameraPosition;

	private Vector3 m_lookatPosition;

	private bool m_bState;

	private GameObject m_gDummyParentObj;

	private GameObject m_gDummyChildObj;

	public GameObject AnimationCameraObject
	{
		get
		{
			return null;
		}
	}

	public static Game_BA_CameraManager GetInst()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public Camera GetEnableCamera()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Initialize()
	{
	}

	public void CameraUpdate(float scale = 1.2f)
	{
	}

	public void ResetCamera()
	{
	}

	public void SetCameraMode(eCameraMode mode)
	{
	}

	public void SetCameraMode_Stalk(CameraMoveData camPos = null, CameraMoveData tgtPos = null)
	{
	}

	public void SetStalkCameraData(eStalkDataKind kind, CameraMoveData data)
	{
	}

	public CameraMoveData GetStalkCameraData(eStalkDataKind kind)
	{
		return null;
	}

	public void SetStalkCamera_Fov(float fov)
	{
	}

	public void SetStalkCamera_CutFlag(bool flag)
	{
	}

	public void SetShake(Vector3 shakeDir, float magnitude, float dirSec)
	{
	}

	public void SetSlide(Vector3 slidePos, float dirSecFade, float dirSecMax)
	{
	}

	public void SetFieldOfView(float view)
	{
	}

	public Vector3 GetNGUIScreenPos(Vector3 worldPos, Camera camUI = null)
	{
		return default(Vector3);
	}

	public Vector3 GetWorldPos(Vector3 nguiPos, float screenZ = 20f)
	{
		return default(Vector3);
	}
}
