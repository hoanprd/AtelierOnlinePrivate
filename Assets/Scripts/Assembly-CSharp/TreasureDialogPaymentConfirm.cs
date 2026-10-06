using System;
using UnityEngine;

public class TreasureDialogPaymentConfirm : UIWindowBase
{
	[Serializable]
	public class PriceBase
	{
		public GameObject goRoot;

		public UILabel sPrice;

		public UILabel sHave;

		public UITexture txIcon;

		public virtual void Init(int df, int price)
		{
		}
	}

	[Serializable]
	public class Price : PriceBase
	{
		public UITexture txFaceIcon;

		public override void Init(int df, int price)
		{
		}
	}

	[Serializable]
	public class PriceCall : PriceBase
	{
		public UILabel sComp;

		public override void Init(int df, int price)
		{
		}
	}

	[SerializeField]
	private UILabel m_sRemainTime;

	[SerializeField]
	private UILabel m_sContent;

	[SerializeField]
	private PriceCall m_sCall;

	[SerializeField]
	private Price m_sPrice;

	private bool m_bDecide;

	private Action<bool> m_sOnResult;

	private GameObject m_goCollision;

	public void Init(HuntInfo hunt, int wealthKind, Action<bool> onResult)
	{
	}

	public override void OnClose()
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	protected override void OnCloseEnd()
	{
	}
}
