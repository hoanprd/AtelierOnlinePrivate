using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentFavEditNameWindow : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UIInput m_sInput;

	private Action<EquipFavoList> m_sOnCloseEvent;

	private EEquipKind m_eSelectKind;

	private int m_iCharaDF;

	private int m_iFavoNo;

	private EquipData m_vFavoEquip;

	private List<SubEquip> m_vSubEquip;

	private EquipFavoList m_sUpdateFavList;

	private void Awake()
	{
	}

	public void Init(int charaDF, int no, string preEditName, EquipData favEquip, List<SubEquip> sub, EEquipKind kind, Action<EquipFavoList> onCloseEvent)
	{
	}

	public void OnClose()
	{
	}

	public void OnDecide()
	{
	}

	private void OnCloseEnd()
	{
	}
}
