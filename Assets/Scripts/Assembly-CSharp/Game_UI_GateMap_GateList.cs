using System;
using UnityEngine;

public class Game_UI_GateMap_GateList : SingletonBase<Game_UI_GateMap_GateList>
{
	public enum eButton
	{
		Bar = 0,
		Close = 1,
		Detail = 2,
		Academy = 3,
		EnumMax = 4
	}

	private eButton m_eClickedButton;

	private Game_UI_GateMap_GateListAreaDetail m_scrDetail;

	private ItemDetailWindow m_scrItemDetail;

	private bool m_bItemDetail;

	private Action m_dCloseCB;

	[SerializeField]
	private UITweenReset m_scrTween;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private Game_UI_GateMap_GateListAreaBarList m_scrAreaList;

	[SerializeField]
	private GameObject m_goDetailRoot;

	[SerializeField]
	private GameObject m_goDetailPrefab;

	[SerializeField]
	private GameObject m_goAcademyButton;

	[SerializeField]
	private GameObject m_goItemDetailRoot;

	private void MakeObject()
	{
	}

	private void OnEndDismiss()
	{
	}

	private void OnEndDetail()
	{
	}

	public void KillChild()
	{
	}

	public void Open(Action dCloseCB)
	{
	}

	public void ClickedButton(eButton eKind, params int[] iParam)
	{
	}

	public void ClearClickedButton()
	{
	}

	public void Close(bool bImmidiate = false)
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public void OnItemDetail(ItemBar sItem)
	{
	}

	public void OnEnemyDetail(EnemyDetailMini sDetail)
	{
	}

	public void OnCloseItemDetail(InventoryList sAddInv, int iUpdateFav, int iGotoAlter)
	{
	}

	public void OnCloseEnemyDetail()
	{
	}

	public void SetActiveAllAreaList(bool active)
	{
	}

	public void SetActiveAllHardModeAreaList(bool active)
	{
	}
}
