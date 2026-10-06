using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PartyEditMemberInfo : MonoBehaviour
{
	public enum EButtonStatus
	{
		eNONE = 0,
		eDISP = 1,
		eSELECT = 2,
		eREMOVE = 3,
		eCHOOSE = 4
	}

	public enum ERole
	{
		eNONE = 0,
		eLEADER = 1,
		eMEMBER = 2,
		eOWNER = 3,
		eJOINMEMBER = 4
	}

	[SerializeField]
	private UILabel m_sPlayerName;

	[SerializeField]
	private UILabel m_sEtcInfo;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private TrainingLimitbreakMark m_sLimitbreak;

	[SerializeField]
	private UILabel m_sRoleName;

	[SerializeField]
	private UISprite m_sRoleColor;

	[SerializeField]
	private GameObject m_goUIRoot;

	[SerializeField]
	private GameObject m_goNoneMark;

	[SerializeField]
	private UILabel m_sLevel;

	[SerializeField]
	private UILabel m_sHP;

	[SerializeField]
	private UIToggle m_sUseItemToggle;

	[SerializeField]
	private PartyEditActiveSkillList m_sSkillList;

	[SerializeField]
	private GameObject m_goGrowMark;

	[SerializeField]
	private UIButton m_sGrowButton;

	[SerializeField]
	private LockMark m_sGrowLock;

	[SerializeField]
	private EquipWeaponElementInfo m_sWeaponInfo;

	[SerializeField]
	private Transform m_trModelRoot;

	[SerializeField]
	private GameObject m_goButtonRoot;

	private PartyMember m_sInfo;

	private Game_Chara_Equip_Base m_sModel;

	private readonly Color ccLEADER_COLOR;

	private readonly Color ccMEMBER_COLOR;

	[SerializeField]
	private MultiPlay_CharaData m_mpCharaData;

	public PartyMember Info
	{
		get
		{
			return null;
		}
	}

	public MultiPlay_CharaData MpCharaData
	{
		get
		{
			return null;
		}
	}

	private void OnDisable()
	{
	}

	private void OnClose()
	{
	}

	public void SetRole(ERole role)
	{
	}

	public void Init(List<InventoryInfo> inv, PartyMember member, FormationInfo form = null)
	{
	}

	public void Init_ExqMember(List<InventoryInfo> inv, PartyMember member = null, FormationInfo form = null, MultiPlay_CharaData mpChara = null)
	{
	}

	public void UpdateJoinMember(List<InventoryInfo> inv, PartyMember member = null)
	{
	}

	private bool IsUseItem()
	{
		return false;
	}

	public void Init(int charaID, FormationInfo form = null)
	{
	}

	public void Init_ExqRoom(PartyMember mem = null, FormationInfo form = null, MultiPlay_CharaData mpChara = null, List<InventoryInfo> inv = null)
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadModel(MakeCharaData mk)
	{
		return null;
	}
}
