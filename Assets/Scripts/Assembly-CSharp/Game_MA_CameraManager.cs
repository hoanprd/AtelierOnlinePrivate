using UnityEngine;

public class Game_MA_CameraManager : MonoBehaviour
{
	private static Game_MA_CameraManager m_inst;

	public const int m_cameraSpeed_Default = 31;

	public Camera[] m_cameraMain;

	public Vector3 m_cameraOffset;

	private bool m_positionLogInitFlag;

	private static readonly int m_positionLogNum;

	private Vector3[] m_positionLogArray;

	private int m_logIndex;

	private Vector3[] m_posLog;

	private float[] m_fovLog;

	private bool m_update;

	private float m_cameraFov_Now;

	public float m_cameraFov_Normal;

	public float m_cameraFov_PickUp;

	public float m_cameraFov_Talk;

	private float m_cameraFovTarget;

	private float m_waitSec_Direction;

	private bool m_directionFixed;

	private bool m_ignoreLimit;

	private int m_cameraChangeSpeed_Direction;

	private Transform m_targetTransform;

	private Vector3 m_shakeEffect_Dir;

	private float m_shakeEffect_Magnitude;

	private float m_shakeEffect_RestSec_Now;

	private float m_shakeEffect_RestSec_Max;

	private Color m_deafaultBGColor;

	private Transform m_trTarget;

	public Animation m_visitAnim;

	public static Game_MA_CameraManager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void CameraUpdate()
	{
	}

	public void SetSpeed(int speed = 31)
	{
	}

	public void SetDirection(float waitSec, bool ignoreLimit = false)
	{
	}

	public void SetDirection(bool fix, Transform target = null)
	{
	}

	public void SetTarget(Transform target)
	{
	}

	public void SetFOV(bool fix, float fov = 0f)
	{
	}

	private bool IsDirectionFOV()
	{
		return false;
	}

	public bool IsUpdate()
	{
		return false;
	}

	public void SetForceUpdate()
	{
	}

	public void SetBGColor(Color color)
	{
	}

	public void SetBGColor_Default()
	{
	}

	public void SetVisitAnimSpeed(float animSpeed)
	{
	}

	public void SetVisitAnim(bool start, float animSpeed = 1f)
	{
	}

	public bool IsVisitAnim()
	{
		return false;
	}

	public void SetShake(Vector3 shakeDir, float magnitude, float dirSec)
	{
	}

	public bool IsExistTalkTarget()
	{
		return false;
	}

	public bool IsDeafultSpeed()
	{
		return false;
	}

	public Vector3 GetNGUIScreenPos(Vector3 worldPos, Camera camUI = null)
	{
		return default(Vector3);
	}

	public Vector3 GetScreenPos(Vector3 worldPos)
	{
		return default(Vector3);
	}

	public Vector3 GetWorldPos(Vector3 nguiPos, float screenZ = 20f)
	{
		return default(Vector3);
	}

	public Vector3 GetScreenPosNGUI(Vector3 worldPos, Camera camUI = null)
	{
		return default(Vector3);
	}
}
