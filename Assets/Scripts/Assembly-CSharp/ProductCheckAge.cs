using System;
using System.Collections.Generic;
using UnityEngine;

public class ProductCheckAge : UIWindowBase
{
	[SerializeField]
	private UIToggle m_sNeverAgain;

	[SerializeField]
	private UIGrid m_sAgeListGrid;

	[SerializeField]
	private List<ProductCheckAgeItem> m_vAgeList;

	private int m_iAgeClass;

	private Action<EButtonKind, int> m_sResult;

	private EButtonKind m_eResult;

	public void Init(List<ProductInfoList.AgeRange4Product> ageRangeList, Action<EButtonKind, int> resultEvent)
	{
	}

	public void OnSwitchNeverAgain()
	{
	}

	public void OnSelect(ProductCheckAgeItem target)
	{
	}

	private void RegisterResponse(ResponseDataCommon res)
	{
	}

	protected override void OnCloseEnd()
	{
	}
}
