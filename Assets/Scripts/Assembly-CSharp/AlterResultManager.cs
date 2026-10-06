using System;
using UnityEngine;

public class AlterResultManager : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private Transform m_trDetailRoot;

	[SerializeField]
	private UISprite[] m_asLimitBreak;

	[SerializeField]
	private AlterResultText[] m_asText;

	[SerializeField]
	private GameObject m_goEquipBlackFilter;

	[SerializeField]
	private GameObject m_goItemBlackFilter;

	[SerializeField]
	private UILabel m_sGetPoint;

	[SerializeField]
	private UILabel m_sTotalPoint;

	[SerializeField]
	private UIButton m_sGotoRuckButton;

	[SerializeField]
	private UIButton m_sGotoEquipButton;

	[SerializeField]
	private UIButton m_sOKButton;

	private ItemDetailWindow m_sDetailWindow;

	private Action m_sOnClose;

	private bool m_bClose;

	public bool IsAnim
	{
		get
		{
			return false;
		}
	}

	public void Init(InventoryInfo inv, int alterLV, long totalPoint, Action onClose = null)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void Update()
	{
	}
}
