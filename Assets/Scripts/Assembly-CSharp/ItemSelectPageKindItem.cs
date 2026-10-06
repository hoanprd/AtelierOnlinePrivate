using System.Collections.Generic;
using UnityEngine;

public class ItemSelectPageKindItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goSelectMark;

	[SerializeField]
	private UITexture m_txItemPicture;

	[SerializeField]
	private GameObject m_goQualityRoot;

	[SerializeField]
	private GameObject[] m_agoQuality;

	[SerializeField]
	private UILabel m_sCount;

	[SerializeField]
	private UILongTapButton m_sSelectButton;

	private MasterItem m_sMaster;

	public MasterItem Master
	{
		get
		{
			return null;
		}
	}

	public bool Select
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void Init(int df, List<InventoryInfo> list)
	{
	}
}
