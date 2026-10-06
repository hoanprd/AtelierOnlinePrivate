using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShopGachaList : UIListViewBase<ShopGachaListItem>
{
	[SerializeField]
	private UIScrollListArrow m_sArrow;

	[SerializeField]
	private UIScrollView m_sScrollView;

	[SerializeField]
	private ShopGachaDetail m_sDetail;

	private GachaInfoList m_sInfo;

	private Dictionary<int, ShopGachaShow> m_vShowList;

	private ShopGachaListItem m_sCenterObj;

	public ShopGachaListItem SelectItem
	{
		get
		{
			return null;
		}
	}

	private void OnDisable()
	{
	}

	public void UpdatePrice()
	{
	}

	public void Init(GachaInfoList info)
	{
	}

	public void OnSelect(ShopGachaListItem target)
	{
	}

	private void UpdateDetail()
	{
	}

	[DebuggerHidden]
	private IEnumerator DispDetail()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator TutorialWait()
	{
		return null;
	}

	private void ReceiveDetailInfo(ShopGachaShowResponse res)
	{
	}
}
