using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ShopModel : MonoBehaviour
{
	public Vector3 m_vModelScale;

	public float m_fAutoRotation;

	public float m_fRotWaitTime;

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private Camera m_sCamera;

	[SerializeField]
	private Transform[] m_trRoot;

	[SerializeField]
	private Transform m_trModellRoot;

	private GachaModel m_sMannequin;

	[SerializeField]
	private Transform m_trEquipRoot;

	private GameObject m_goEquipModel;

	private bool m_bKeyDown;

	private float m_fPos;

	private float m_fAngle;

	private float m_fWait;

	public float m_fScaleSpeed;

	private float m_fMaxScale;

	private void Start()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	private void OnDismiss()
	{
	}

	public void SetEnable(bool sw)
	{
	}

	public void Init(ShopGachaShow.Item item)
	{
	}

	public void Init(MasterItem master)
	{
	}

	public void Init(ShopGachaShow.Chara master)
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadCharaModel(MakeCharaData mk)
	{
		return null;
	}

	private void Init(int category, int gen, int modelID)
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadSingleModel(string path)
	{
		return null;
	}

	public void Init(ShopGachaShow.Coordinate coordinate)
	{
	}

	public void InitModel(MasterItem master, int quality)
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadCharaModel(MakeCharaData mk, EWeaponKind weaponKind, int[] ignoreSilhouetteList)
	{
		return null;
	}

	private void ResetModel()
	{
	}

	private void InitCharaModel(EWeaponKind weaponKind, int[] ignoreSilhouetteList)
	{
	}

	public MakeCharaData ConvertFromCoordinate(ShopGachaShow.Coordinate coordnate)
	{
		return null;
	}

	private MakeCharaData GetDefaultMannequin(int gender)
	{
		return null;
	}

	private int GetModelID(ECategory categ, int df)
	{
		return 0;
	}

	private void InitRotation(float angle)
	{
	}

	[DebuggerHidden]
	private IEnumerator ScaleUp(GameObject obj)
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnCollisionDown()
	{
	}
}
