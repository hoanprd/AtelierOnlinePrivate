using System;
using System.Collections.Generic;
using UnityEngine;

public class PartyTopManager : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private SpawnPrefabData m_sPartyEdit;

	[SerializeField]
	private SpawnPrefabData m_sItemSet;

	[SerializeField]
	private SpawnPrefabData m_sTraining;

	[SerializeField]
	private SpawnPrefabData m_sEquipment;

	[SerializeField]
	private Transform m_trDetailRoot;

	private List<EPartyMode> m_vModeTree;

	private Action m_sOnClose;

	private int m_iTargetCharaDF;

	private List<PartyMember> m_vPrevMember;

	private ExqRoomRequest m_sRequestExqRoom;

	private EExqRoomMode m_sExqRoomMode;

	private string m_sRoomName;

	private void CopyMemberInfo()
	{
	}

	public void Init(Action onClose, EPartyMode defaultMode = EPartyMode.eEDIT)
	{
	}

	public void OnBack()
	{
	}

	public void OnRequest(EPartyMode next, int charaDF)
	{
	}

	public void SetRequest(ExqRoomRequest req, EExqRoomMode mode, string roomName)
	{
	}

	private void OnDisable()
	{
	}

	private void SetMode(EPartyMode mode)
	{
	}

	private void RegistMode(EPartyMode mode)
	{
	}

	private void UpdateMultiMember()
	{
	}
}
