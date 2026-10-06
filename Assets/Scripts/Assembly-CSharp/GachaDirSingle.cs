using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GachaDirSingle : GachaDirBase
{
	[Serializable]
	public class CommonInfo
	{
		public UISprite sCategoryIcon;

		public UITexture txCharaFaceIcon;

		public UILabel sName;

		public GameObject goRarityMarkRoot;

		public GameObject[] agoRarityMark;

		public GameObject goNewMark;

		public void Init(ShopGachaLot.LotResult data)
		{
		}
	}

	[Serializable]
	public class ItemInfo
	{
		public GameObject goRoot;

		public GameObject goRoot2;

		public UITexture txIcon;

		public UIGrid sItemBarGrid;

		public List<ItemBar> vItemBarList;

		public GameObject goSkillRoot;

		public SkillMark sSkillMark;

		public EquipSkillList sSkillList;

		public EquipParamList sParamList;
	}

	[Serializable]
	public class CharaInfo
	{
		public GameObject goInfoRoot;

		public UITexture txCharaAll;

		public GameObject go3DRoot;

		public Transform trModelRoot;

		public GameObject goModelPrefab;

		public GachaModel sModel;

		public GameObject goLimitbreakItemRoot;

		public UITexture txLimitbreakItem;

		public UILabel sLimitbreakNum;
	}

	[SerializeField]
	private CommonInfo m_sCommon;

	[SerializeField]
	private ItemInfo m_sItem;

	[SerializeField]
	private CharaInfo m_sChara;

	[SerializeField]
	private GameObject[] m_agoRareEffect;

	[SerializeField]
	private GameObject[] m_agoRareEffect2;

	[SerializeField]
	private GameObject[] m_agoRareEffectUzu;

	[SerializeField]
	private Animation m_sCertainAnim;

	private bool m_bCertain;

	private int m_iUzuKind;

	private ShopGachaLotResponse m_sResult;

	private ShopGachaLot.LotResult m_sData;

	private bool m_bDecompose;

	private bool m_bDirectionOnly;

	private bool m_bRare;

	private List<GameObject> m_vgoDefaultDisableObj;

	private List<GameObject> m_vgoDefaultEnableObj;

	private string m_sDebugLog;

	public bool IsDecompose
	{
		get
		{
			return false;
		}
	}

	public bool IsInitAnimEnd
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	[DebuggerHidden]
	public IEnumerator PlayDirection(ShopGachaLotResponse data, ShopGachaLot.LotResult result, EGachaResultKind kind)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator Play(ShopGachaLotResponse data, ShopGachaLot.LotResult result, EGachaResultKind kind)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator PlayAfterDirection(ShopGachaLotResponse data, ShopGachaLot.LotResult result, EGachaResultKind kind)
	{
		return null;
	}

	private void Init(ShopGachaLotResponse data, ShopGachaLot.LotResult result, EGachaResultKind kind, bool certainDisable = false)
	{
	}

	private void InitItem()
	{
	}

	private void InitChara()
	{
	}

	[DebuggerHidden]
	private IEnumerator Play(float animationStartPoint = 0f)
	{
		return null;
	}

	public void OnSwitchMaterial()
	{
	}

	public void OnCertainty()
	{
	}

	public override List<ShopGachaLot.LotResult> GetDecomposeList()
	{
		return null;
	}

	public void PlayUzuSound()
	{
	}

	public void OnDetail(ItemBar target)
	{
	}
}
