using System.Collections.Generic;
using UnityEngine;

public class PartyEditMemberList : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goPrefab;

	[SerializeField]
	private AnimationController[] m_asLocRootAnim;

	[SerializeField]
	private GameObject m_goSubMemberGrayOut;

	private List<PartyEditMemberInfo> m_vInfoList;

	private List<CharaDetail> m_vMemberDetail;

	public bool IsAnimEnd()
	{
		return false;
	}

	private void CreateMemberInfoList()
	{
	}

	public void Init(PartyInfo party)
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void DisableChara()
	{
	}

	private void OnDissmissEnd()
	{
	}

	private void OnDisable()
	{
	}
}
