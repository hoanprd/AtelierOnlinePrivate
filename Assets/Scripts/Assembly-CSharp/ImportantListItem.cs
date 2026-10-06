using UnityEngine;

public class ImportantListItem : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sHaveNum;

	[SerializeField]
	private UILabel m_sDetail;

	[SerializeField]
	private GameObject m_goCallRoot;

	[SerializeField]
	private UILabel m_sFreeNum;

	[SerializeField]
	private UILabel m_sCompensationNum;

	[SerializeField]
	private UISprite m_sBackground;

	public void Init(int kind)
	{
	}
}
