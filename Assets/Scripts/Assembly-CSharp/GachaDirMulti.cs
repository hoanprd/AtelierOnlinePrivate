using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GachaDirMulti : GachaDirBase
{
	[SerializeField]
	private GachaDirSingle m_sSingleDir;

	[SerializeField]
	private GachaDirMultiItem[] m_asItem;

	[SerializeField]
	private SpawnPrefabData m_sSkillWindow;

	[SerializeField]
	private GachaMaterialList m_sMaterialListWindow;

	private GachaInfo.Data m_sInfo;

	private GachaInfo.SellInfo m_sPriceInfo;

	private ShopGachaLotResponse m_sResult;

	private bool m_bRetry;

	private bool m_bExit;

	public GachaInfo.SellInfo PriceInfo
	{
		get
		{
			return null;
		}
	}

	public bool IsRetry
	{
		get
		{
			return false;
		}
	}

	public void Awake()
	{
	}

	private void SetParameter(ShopGachaLotResponse data, List<EGachaResultKind> kind, GachaInfo.SellInfo price, GachaInfo.Data info)
	{
	}

	[DebuggerHidden]
	public IEnumerator Play(ShopGachaLotResponse data, List<EGachaResultKind> kind, GachaInfo.SellInfo price, GachaInfo.Data info)
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator PlayAfterDirection(ShopGachaLotResponse data, List<EGachaResultKind> resultKindList, GachaInfo.SellInfo price = null, GachaInfo.Data info = null)
	{
		return null;
	}

	protected void UpdatePrice()
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitingReceiveItem()
	{
		return null;
	}

	[DebuggerHidden]
	protected IEnumerator ReceiveConfirm()
	{
		return null;
	}

	public void Once()
	{
	}

	public override List<ShopGachaLot.LotResult> GetDecomposeList()
	{
		return null;
	}

	public void OnAllMaterial()
	{
	}

	public void OnAllEquip()
	{
	}

	public void OnDetail(GachaDirMultiItem target)
	{
	}
}
