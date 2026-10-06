using System;
using UnityEngine;

public class GachaDirMultiItem : MonoBehaviour
{
	[Serializable]
	public class ItemInfo
	{
		public GameObject goRoot;

		public UITexture txIcon;

		public SkillMark sSkillMark;

		public LimitBreakMark sLimitBreakMark;
	}

	[Serializable]
	public class CharaInfo
	{
		public GameObject goRoot;

		public UITexture txCharaAll;

		public GameObject goLimitbreakRoot;

		public UITexture txLimitbreakItem;

		public LimitBreakMark sLimitBreakMark;

		public UILabel candyNumLab;
	}

	[SerializeField]
	private Animation m_sAnim;

	[SerializeField]
	private CommonAnimationEvent m_sAnimEvent;

	[SerializeField]
	private UIButton m_sDetailButton;

	[SerializeField]
	private ItemInfo m_sItem;

	[SerializeField]
	private CharaInfo m_sChara;

	[SerializeField]
	private GameObject m_goNewMark;

	[SerializeField]
	private GameObject[] m_agoRareEffect;

	[SerializeField]
	private GameObject[] m_agoRareEffectUzu;

	[SerializeField]
	private Animation m_sCertainAnim;

	[SerializeField]
	private GameObject m_goItemInfo;

	[SerializeField]
	private GameObject m_goCertain;

	[SerializeField]
	private ParticleSystem m_sPanParticle;

	[SerializeField]
	private UIToggle m_sDecomposeToggle;

	[SerializeField]
	private UIToggledObjects m_sDecomposeToggleObj;

	private bool m_bCertain;

	private int m_iUzuKind;

	private ShopGachaLot.LotResult m_sData;

	private bool m_bDecompose;

	private EGachaResultKind m_eResultKind;

	private bool m_bRare;

	private Sound_OneShot m_sCertainVoice;

	public UIButton DetailButton
	{
		get
		{
			return null;
		}
	}

	public EGachaResultKind ResultKind
	{
		get
		{
			return EGachaResultKind.eNORMAL;
		}
	}

	public bool IsDecompose
	{
		get
		{
			return false;
		}
	}

	public ShopGachaLot.LotResult Data
	{
		get
		{
			return null;
		}
	}

	public bool IsCertainAnimEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsInAnimEnd
	{
		get
		{
			return false;
		}
	}

	public void SkipCertainAnim()
	{
	}

	public void SetEnableButton(bool sw)
	{
	}

	private void Start()
	{
	}

	public void Init(ShopGachaLot.LotResult data, EGachaResultKind kind)
	{
	}

	public bool CertainPlay()
	{
		return false;
	}

	public void Play()
	{
	}

	public void SetAnimEnd()
	{
	}

	public void OnSwitchMaterial()
	{
	}

	public void OnCertainty()
	{
	}

	public void SetDecompose(bool sw)
	{
	}

	public void PlayUzuSound(eSoundID defSound)
	{
	}
}
