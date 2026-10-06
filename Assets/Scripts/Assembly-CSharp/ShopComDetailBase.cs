using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShopComDetailBase : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_goSaleRoot;

	[SerializeField]
	protected UILabel m_sSaleRate;

	[SerializeField]
	protected UIGrid m_sPriceGrid;

	[SerializeField]
	protected ShopComPriceItem m_sPrefab;

	[SerializeField]
	protected ShopComLineup m_sLineup;

	[SerializeField]
	protected AnimationController m_sAnim;

	protected ShopComItem m_sDetail;

	protected List<ShopComPriceItem> m_vPriceItem;

	protected virtual void Awake()
	{
	}

	public virtual void Init(EShopComKind kind, ShopComItem detail)
	{
	}

	private void MakePriceList(IEnumerable<IGrouping<int, ShopComInfo.ShopSellInfo>> groups)
	{
	}

	public virtual void Init()
	{
	}

	protected virtual void Update()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public bool IsAnimationEnd()
	{
		return false;
	}

	public void SetAnimEnd()
	{
	}
}
