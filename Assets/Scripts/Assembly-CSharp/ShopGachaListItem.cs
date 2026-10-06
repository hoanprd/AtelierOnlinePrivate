using UnityEngine;

public class ShopGachaListItem : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txBanner;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sLimitTime;

	[SerializeField]
	private GameObject m_goEvent;

	[SerializeField]
	private UITweenReset m_sSelectAnim;

	[SerializeField]
	private GameObject m_goSelectMark;

	private GachaInfo.Data m_sInfo;

	public GachaInfo.Data Info
	{
		get
		{
			return null;
		}
	}

	public void Init(GachaInfo.Data info)
	{
	}

	public void Select(bool select, bool immidiate = false)
	{
	}
}
