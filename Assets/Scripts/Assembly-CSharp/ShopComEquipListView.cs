using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ShopComEquipListView : ShopComListBase
{
	[SerializeField]
	private ShopModel m_sModel;

	[SerializeField]
	private ShopComEquipDetail m_sDetail;

	public override void Bringin()
	{
	}

	public override void Dismiss()
	{
	}

	public void Init(EShopComKind kind, ShopComInfo.Data[] list)
	{
	}

	protected override void UpdateDetail()
	{
	}

	protected override void ReceiveDetailInfo(ShopComItem detail)
	{
	}

	[DebuggerHidden]
	private IEnumerator DispDetail()
	{
		return null;
	}
}
