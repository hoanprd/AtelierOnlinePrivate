using System.Collections.Generic;
using UnityEngine;

public class GachaDirBase : MonoBehaviour
{
	[SerializeField]
	protected Animation m_sAnim;

	[SerializeField]
	protected GachaDirButton m_sButton;

	[SerializeField]
	protected Transform m_trDetailRoot;

	protected bool m_bNext;

	protected ItemDetailWindow m_sDetailWindow;

	public virtual void OnNext()
	{
	}

	public virtual List<ShopGachaLot.LotResult> GetDecomposeList()
	{
		return null;
	}
}
