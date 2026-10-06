using System.Collections.Generic;
using UnityEngine;

public class EquipmentAutoDialog : UIWindowBase
{
	public delegate void EquipmentAutoDecideEvent(CharaDetail chara, EEquipKind tabKind);

	[SerializeField]
	private List<UIToggle> m_vEquipKindToggle;

	[SerializeField]
	private List<EquipmentAutoStatusPriorityToggle> m_vStatusPriorityButton;

	private const string cs_STATUS_PRIORITY_KEY = "AUTO_STATUS_PRIORITY";

	private CharaDetail m_sSelectChara;

	private EEquipKind m_eSelectEquipKind;

	private EquipStatusEnum m_eSelectStatusPriority;

	private EquipmentAutoDecideEvent m_sDecideCallback;

	public void Init(CharaDetail selectChara, EEquipKind currentTab, EquipmentAutoDecideEvent callback)
	{
	}

	public void OnDecide()
	{
	}

	public void OnChangeEquipKind(UIToggle targetToggle)
	{
	}

	public void OnChangeStatusPriority(EquipStatusEnum targetStatusPriority)
	{
	}
}
