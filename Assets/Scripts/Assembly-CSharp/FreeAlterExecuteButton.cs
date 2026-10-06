using UnityEngine;

public class FreeAlterExecuteButton : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sGuideWord;

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private GameObject m_goEnableIcon;

	[SerializeField]
	private UILabel m_sUserName;

	[SerializeField]
	private UISprite m_sUserIcon;

	[SerializeField]
	private UITweenReset m_sExecuteAnim;

	[SerializeField]
	private AlterExecuteResultIcon m_sResultIcon;

	private bool m_bHost;

	public bool EnableExecute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(MultiPlay_AlchemyData data)
	{
	}

	public void Execute(InventoryInfo result)
	{
	}
}
