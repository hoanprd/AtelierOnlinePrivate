using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_Item_PickUp_Base : Game_Item_Base
{
	public enum ePickUpItemKind
	{
		Grass = 0,
		Egg = 1,
		Kinoko = 2,
		Stone = 3,
		Flower = 4,
		Fishing = 5,
		CatchNet = 6,
		RainWater = 7,
		Tree = 8,
		FrogOil = 9,
		Grape = 10,
		Bird = 11,
		Rabbit = 12,
		Carriage = 13,
		TreeS = 14,
		FlowerN = 15,
		StoneN = 16,
		Quest = 17,
		EnumMax = 18
	}

	public static readonly PickUpItemData[] m_pickUpItemDataArray;

	public static readonly FindItemData[] m_findItemDataArray;

	public static readonly float[] m_waitSec_PickUp_SE;

	private ePickUpItemKind m_pickUpItemKind;

	private PickUpItemData m_myItemData;

	private List<AnimalColorDataLog> m_changeMaterialList;

	public Renderer m_mainRenderer;

	private Animation m_animation;

	private int m_itemNum;

	private bool m_fadeFlag;

	private bool m_isFadeIn;

	private bool m_isCapturing;

	private float m_waitSec_Now;

	private float m_waitSec_Max;

	private FX_GameTime_ParticleRate m_particleRateManager;

	private bool[] m_activeTimeArray;

	private bool[] m_activeWeatherArray;

	private bool m_isTutorial;

	private bool m_picked;

	private GameObject m_raderMarker;

	private GameObject m_lightObj;

	private Game_Animal_ItemDrop m_animal;

	public GameObject m_modelRoot;

	public GameObject m_disableObj;

	public GameObject m_goPickableEffect;

	private bool m_isAssetLoaded;

	private bool m_isAssetSuccess;

	public Game_Animal_ItemDrop Animal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void Start()
	{
	}

	public void RotateModelRoot()
	{
	}

	public override void UpdateSpotInfo()
	{
	}

	[DebuggerHidden]
	private IEnumerator AddRareParticleScript(GameObject obj)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator AddTimeParticleScript(GameObject obj)
	{
		return null;
	}

	private void SetChangeMaterialList(GameObject tempObj)
	{
	}

	public void SetActive(bool active)
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected void UpdateFadeIO(bool bIn)
	{
	}

	private void SetAlpha(float alpha)
	{
	}

	private void SetFXEnable(bool enable)
	{
	}

	protected override void SetHitEffect()
	{
	}

	public int GetItemSpotNo()
	{
		return 0;
	}

	public ePickUpItemKind GetItemKind()
	{
		return ePickUpItemKind.Grass;
	}

	public PickUpItemData GetItemData()
	{
		return null;
	}

	public void SetItemKind(ePickUpItemKind kind, Texture mainTex = null, Texture subTex = null, bool editor = false)
	{
	}

	protected bool IsOnlyMorning()
	{
		return false;
	}

	protected bool IsOnlyAfterRain()
	{
		return false;
	}

	protected bool IsExistCondition()
	{
		return false;
	}

	protected bool IsTimeCondition()
	{
		return false;
	}

	protected bool IsWeatherCondition()
	{
		return false;
	}

	public bool IsPickUpOK()
	{
		return false;
	}

	public override bool IsEnable()
	{
		return false;
	}

	public bool IsPicked()
	{
		return false;
	}

	public void SetPickOK(bool ok)
	{
	}

	public void LoadEffect()
	{
	}

	[DebuggerHidden]
	private IEnumerator AssetReload()
	{
		return null;
	}

	public bool IsLoadEffect()
	{
		return false;
	}

	public bool IsSuccessEffect()
	{
		return false;
	}

	public void StartCaputure()
	{
	}

	public void SetCaptured_First()
	{
	}

	[DebuggerHidden]
	public IEnumerator MakeCaptureEffect()
	{
		return null;
	}

	public void SetCaptured_PickUp()
	{
	}

	public void SetCaptured_Last()
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public ePickUpToolKind GetPickUpToolKind()
	{
		return ePickUpToolKind.None;
	}

	public int[] GetToolDF()
	{
		return null;
	}

	public Vector3 GetRootPosition()
	{
		return default(Vector3);
	}

	public void SetMarker(GameObject marker)
	{
	}
}
