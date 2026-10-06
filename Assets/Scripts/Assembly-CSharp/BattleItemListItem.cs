using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BattleItemListItem : UIBase
{
	public enum EItemGaugeStep
	{
		Accept = 0,
		ReserveWait = 1,
		Reserve = 2
	}

	private MultiPlay_BattleCharaData m_battleCharaData;

	private MultiPlay_BattleData m_battleData;

	private int m_number;

	private int m_count;

	private List<InventoryInfo> m_RckList;

	[SerializeField]
	private UILabel count;

	[SerializeField]
	private UISlider slider;

	private bool m_sliderPause;

	[SerializeField]
	private UISprite m_buttonColor;

	[SerializeField]
	private GameObject m_maxEffctObj;

	[SerializeField]
	private GameObject m_tapEffctObj;

	private UITweenReset m_longTapOuttweens;

	private bool m_grayFlag;

	private MasterItem m_itemData;

	private float m_cutRate;

	[SerializeField]
	private Color m_defaultColor;

	[SerializeField]
	private Color m_grayColor;

	private GameObject m_longTapObj;

	private List<GameObject> m_LongEffectObjList;

	private EItemGaugeStep m_step;

	public void Init(ManualItemInfo ItemData, ResponseDataCommon commonResponse)
	{
	}

	public void Use(bool costdown, bool gaugeTakeOver, long itemID)
	{
	}

	public void UseInterrupt(bool costdown, long itemID)
	{
	}

	public void Fill()
	{
	}

	public void SetGauge(float value)
	{
	}

	public void SetGaugePause(bool pause)
	{
	}

	public void SetGrayFlag(bool flag)
	{
	}

	private void Update()
	{
	}

	private void DidTapItem()
	{
	}

	private bool IsPartyActive()
	{
		return false;
	}

	private void OnLongTapStart()
	{
	}

	private void OnLongTapFinished()
	{
	}

	private void OnOutFinished()
	{
	}

	public int GetDF()
	{
		return 0;
	}

	public void ChangeStep(EItemGaugeStep step)
	{
	}

	public void Delete()
	{
	}

	private void GetItemText()
	{
	}

	private IEnumerable<MultiPlay_InventoryInfo> GetUsableItem()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator ItemTexture()
	{
		return null;
	}
}
