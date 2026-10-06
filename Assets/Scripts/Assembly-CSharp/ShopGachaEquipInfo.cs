using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ShopGachaEquipInfo : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goItemRoot;

	[SerializeField]
	private UILabel m_sItemName;

	[SerializeField]
	private LimitBreakMark m_sItemLimitbreakMark;

	[SerializeField]
	private GameObject[] m_agoItemLimitbreakMarkLight;

	[SerializeField]
	private UIGrid m_sLightGrid;

	[SerializeField]
	private GameObject m_goCharaRoot;

	[SerializeField]
	private UILabel m_sCharaName;

	[SerializeField]
	private GameObject m_goCharaWarning;

	[SerializeField]
	private UILabel m_sCautionText;

	[SerializeField]
	private EquipAllStatus m_sStatus;

	[SerializeField]
	private ShopLineupWindow m_sLineupWindow;

	[SerializeField]
	private SpawnPrefabData m_sSkillWindow;

	[SerializeField]
	private ShopGachaCharaInfoWindow m_sCharaWarningWindow;

	private GachaInfo.Data m_sInfo;

	private ShopGachaShow.Item m_sDetail;

	private ShopGachaShow.Chara m_sChara;

	private void Awake()
	{
	}

	public void Init(GachaInfo.Data info, ShopGachaShow.Item item)
	{
	}

	public void Init(ShopGachaShow.Chara chara)
	{
	}

	public void Init(ShopGachaShow.Coordinate coord)
	{
	}

	public void OnDetail(EquipSkillItem target)
	{
	}

	[DebuggerHidden]
	private IEnumerator DispSkillDetail(DialogActiveSkill diag)
	{
		return null;
	}

	public void OnLineup()
	{
	}

	public void OnCharaInfoWarning()
	{
	}

	public void OnCharaSkill()
	{
	}
}
