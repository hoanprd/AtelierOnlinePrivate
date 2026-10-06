using System.Collections.Generic;
using UnityEngine;

public class PartyEditCharaChange : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private GameObject m_goPrefab;

	[SerializeField]
	private UIGrid m_sRootGrid;

	[SerializeField]
	private UIButton m_sNextArrow;

	[SerializeField]
	private UIButton m_sPrevArrow;

	[SerializeField]
	private GameObject m_goListRoot;

	[SerializeField]
	private UILabel m_sPageNum;

	private int m_iPageMax;

	private int m_iPageIndex;

	private List<PartyEditMemberInfo> m_vInfoList;

	private List<PartyMember> m_vMemberList;

	private PartyInfo m_sPartyInfo;

	private const int ciDISPMAX = 3;

	private void CreateMemberInfoList()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void Dismiss()
	{
	}

	public void Bringin()
	{
	}

	public void Init(int target, PartyInfo party)
	{
	}

	public void OnNextPage()
	{
	}

	public void OnPrevPage()
	{
	}

	private void PageInit(int page)
	{
	}
}
