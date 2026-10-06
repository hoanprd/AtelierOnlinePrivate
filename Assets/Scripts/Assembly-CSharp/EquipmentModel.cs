using System.Collections.Generic;
using UnityEngine;

public class EquipmentModel : MonoBehaviour
{
	public Camera m_sCamera;

	public Transform m_trScaleRoot;

	public Transform m_trRoot;

	public Animation m_sChangeAnimation;

	public GameObject m_goLoadingMark;

	public Vector3 m_vModelScale;

	private Game_Chara_Equip_Base m_sChara;

	private bool m_bLoading;

	private int m_iAnimID;

	private bool m_bOneShotAnim;

	private bool m_bKeyDown;

	private float m_fPos;

	private float m_fAngle;

	private float m_fScale;

	private float m_fPrevDistance;

	private const float cfMIN_SCALE = 1f;

	private const float cfMAX_SCALE = 1.5f;

	[SerializeField]
	private BoxCollider m_vRotateCollider;

	[SerializeField]
	private Vector3 m_vExpandedColliderSize;

	private Vector3 m_vDefalutColliderSize;

	public MakeCharaData MakeCharaData
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PlayChangeEffect()
	{
	}

	public void PlayExAnim(Game_Chara_Equip_Base.EExMotionKind id, bool oneshot = false)
	{
	}

	public void Init(CharaDetail chara, List<InventoryInfo> inv, bool force = false)
	{
	}

	public void Init(int part, InventoryInfo inventory)
	{
	}

	public void Init(MakeCharaData equip, bool force = false)
	{
	}

	public void DisableWeapon()
	{
	}

	public void UpdateModel(MakeCharaData equip)
	{
	}

	private void Update()
	{
	}

	private bool CheckPinchInOut()
	{
		return false;
	}

	public void OnCollisionDown()
	{
	}

	public void PlayAction()
	{
	}

	public void ExpandCollider(bool mode)
	{
	}
}
