using UnityEngine;

public class PresentListItem : MonoBehaviour
{
	[SerializeField]
	private UISprite[] m_asBackGround;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sNum;

	[SerializeField]
	private UISprite m_sCategoryIcon;

	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UILabel m_sMessage;

	[SerializeField]
	private UILabel m_sReceiveDate;

	[SerializeField]
	private UILabel m_sTimeLimit;

	[SerializeField]
	private UISprite m_sSelectMark;

	[SerializeField]
	private UITexture m_txCharaIcon;

	private PresentInfo m_sInfo;

	private bool m_bSelect;

	public long ID
	{
		get
		{
			return 0L;
		}
	}

	public string ReceiveDate
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

	public void Init(PresentInfo info)
	{
	}
}
