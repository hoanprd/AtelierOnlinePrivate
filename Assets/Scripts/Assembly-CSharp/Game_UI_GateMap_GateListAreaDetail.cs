using System;
using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GateMap_GateListAreaDetail : MonoBehaviour
{
	public enum eMode
	{
		Item = 0,
		Enemy = 1,
		EnumMax = 2
	}

	private eMode m_eNowMode;

	private bool m_bChangedTgl;

	private bool m_bClose;

	private Action m_acCallback;

	[SerializeField]
	private UILabel m_scrAreaName;

	[SerializeField]
	private UILabel m_scrLvLabel;

	[SerializeField]
	private UIToggle[] m_scrToggleAry;

	[SerializeField]
	private UIScrollListArrow[] m_scrArrow;

	[SerializeField]
	private Game_UI_GateMap_GateListAreaDetailItemList m_scrItemList;

	[SerializeField]
	private Game_UI_GateMap_GateListAreaDetailEnemyList m_scrEnemyList;

	[SerializeField]
	private UIButton m_scrCloseButton;

	[SerializeField]
	private UITweenReset m_scrTween;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnClicekedClose()
	{
	}

	private void OnEndDismiss()
	{
	}

	private void OnToggleItem()
	{
	}

	private void OnToggleEnemy()
	{
	}

	public void SetData(string strAreaName, int iLevel, List<int> iItemIdList, List<int> iEnemyIdList, Action acCallback, ItemBarEvent OnItemDetail, EnemyDetailMiniEvent OnEnemyDetail)
	{
	}

	public void Close(bool bImmidiate = false)
	{
	}
}
