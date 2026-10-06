using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
	public enum EStep
	{
		eNONE = 0,
		eGETINFO = 1,
		eBRINGIN = 2,
		eWAIT = 3,
		eDISMISS = 4,
		eOUT = 5,
		eEND = 6
	}

	public UICurveLabel m_sCharaName;

	public UILabel m_sCharaCount;

	public GameObject[] m_agoPage;

	public GameObject m_goCharaUI;

	public GameObject m_goChangeCharaButton;

	public UILabel m_sEditStat;

	public GameObject m_goSwitchEditMode;

	public GameObject m_goSelectDecideButton;

	public EquipmentTitle m_sTitle;

	public EquipmentStatus m_sStatus;

	public EquipmentList m_sEquipList;

	public EquipmentSelect m_sEquipSelect;

	public EquipmentFavorite m_sFavorite;

	public EquipmentModel m_sModel;

	public EquipmentVisualSetting m_sVisual;

	public UIButton m_sFavButton;

	public EquipmentAutoDialog m_sAutoDialog;

	public GameObject m_goDisplayModeRoot;

	public UITweenReset m_sDisplayButtonTween;

	public UILabel m_sDisplayText;

	private int m_iCharaID;

	private int m_iCharacterNum;

	private int m_iCharaIndex;

	private EEquipUIStatus m_eStat;

	private EEquipUIStatus m_eRequestStat;

	private EEquipWindowKind m_eEnableWindow;

	private bool m_bVisualMode;

	private bool m_bDisplayUIMode;

	private int m_iChangeParts;

	private EquipmentWindow[] m_asWindowList;

	private EStep m_eStep;

	private CharaDetail m_sSelectCharacter;

	private PartyEditRequest m_sRequest;

	private CharaDetail m_sSendData;

	private int m_iSelectIndex;

	private InventoryInfo m_sSelectInventory;

	private bool m_bInitComplete;

	private ResponseDataCommon m_sChangeResponse;

	private PartyEquipFavoListResponse m_sFavoriteResponse;

	private bool m_bRequestNow;

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public void Init(PartyInfo party, PartyMemberShow first, List<InventoryInfo> inv, PartyEditRequest req)
	{
	}

	private void OnDisable()
	{
	}

	public void OnChangeEquip(EquipmentListItem target)
	{
	}

	public void OnChangeSubEquip(EquipmentSubListItem target)
	{
	}

	public void OnChangeCharaLeft()
	{
	}

	public void OnChangeCharaRight()
	{
	}

	public void OnSwitchVisualMode()
	{
	}

	public void OnSwitchDisplayUIMode()
	{
	}

	public void OnRecommended()
	{
	}

	private void ChangeEquip(CharaDetail chara, EEquipKind tabKind)
	{
	}

	public void OnFavorite()
	{
	}

	private void EquipFavo(CharaDetail chara)
	{
	}

	public void OnClear()
	{
	}

	public void OnDecideSelect(CharaDetail data)
	{
	}

	public void OnDecideSelectExecute(CharaDetail data)
	{
	}

	public void UpdateVisual(ResponseDataCommon res)
	{
	}

	public void OnSwitchVisualOnOff(EquipmentVisualItem target)
	{
	}

	private void OnEquipComplete(ResponseDataCommon res)
	{
	}

	private void InitChara(CharaDetail detail)
	{
	}

	private void ChangeMember(int charaID, MsgPackResponse<PartyMemberShowResponse> callback)
	{
	}

	private void ReflectChangeMember(PartyMemberShowResponse res)
	{
	}

	private void ReflectChangeMemberInit(PartyMemberShowResponse res)
	{
	}

	private void ReflectMember(CharaDetail chara)
	{
	}

	private ECategory GetSelectCategory(EEquipPart part)
	{
		return ECategory.eNONE;
	}

	private List<PartyMember> GetEditableMemberList()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator DetectAnimationEnd()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void WindownInOut(EEquipWindowKind kind, bool bringin)
	{
	}

	private void RightWindowInOut(bool bringin)
	{
	}

	private bool IsWindowAnimationEnd()
	{
		return false;
	}

	private void Dismiss()
	{
	}

	private void Bringin()
	{
	}

	private void InitScene(bool reset = false)
	{
	}

	public void DataInit()
	{
	}

	public void OnBack()
	{
	}

	private void OnClose()
	{
	}
}
