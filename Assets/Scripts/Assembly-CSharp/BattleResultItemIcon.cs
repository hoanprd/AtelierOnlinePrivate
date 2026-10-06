using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BattleResultItemIcon : MonoBehaviour
{
	public enum EBoxKind
	{
		eNONE = 0,
		eNORMAL = 1,
		eRARE = 2
	}

	public Animation m_sAnim;

	public UISprite[] m_asBox;

	public GameObject m_goRareEffect;

	public Transform m_trItemBarRoot;

	public Transform m_trDetailRoot;

	private AnimationState m_sAnimState;

	private ItemBar m_sDetail;

	private int m_skillRate;

	private InventoryInfo m_sInventoryInfo;

	private int m_iWealth;

	private ItemDetailWindow m_sDetailWindow;

	private void Awake()
	{
	}

	public void Init(InventoryInfo dropItem, int boxKind, int rate = 1)
	{
	}

	public void InitWealth(int df, int num, int boxKind)
	{
	}

	private void OnDetail(ItemBar target)
	{
	}

	public void AnimStart()
	{
	}

	public void AnimEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator End()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
