using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopComListItem : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txImage;

	[SerializeField]
	private UITexture m_txItemIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sLimitTime;

	[SerializeField]
	private GameObject m_goSaleMark;

	[SerializeField]
	private UILabel m_sFreeBuyCountBadge;

	[SerializeField]
	private UITweenReset m_sSelectAnim;

	[SerializeField]
	private GameObject m_goSelectMark;

	[SerializeField]
	private GameObject m_goSoldOut;

	[SerializeField]
	private GameObject m_goEvent;

	[SerializeField]
	private UIGrid m_sLimitGrid;

	[SerializeField]
	private GameObject m_goLimitPrefab;

	private List<GameObject> m_vLimitList;

	private ShopComInfo.Data m_sInfo;

	public bool IsEtherShopItem
	{
		get
		{
			return false;
		}
	}

	public ShopComInfo.Data Info
	{
		get
		{
			return null;
		}
	}

	public bool IsTimeSale
	{
		get
		{
			return false;
		}
	}

	public DateTime NowDateTime
	{
		get
		{
			return default(DateTime);
		}
	}

	public DateTime CloseDateTime
	{
		get
		{
			return default(DateTime);
		}
	}

	public void Init(ShopComInfo.Data info, EShopComKind kind = EShopComKind.eEQUIP)
	{
	}

	private void InitLimit()
	{
	}

	public void Select(bool select, bool immidiate = false)
	{
	}

	private void Update()
	{
	}
}
