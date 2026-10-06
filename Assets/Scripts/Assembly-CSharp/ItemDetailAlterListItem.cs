using UnityEngine;

public class ItemDetailAlterListItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goLock;

	[SerializeField]
	private GameObject m_goUnlock;

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sStatus;

	[SerializeField]
	private UISprite m_sStatusBg;

	[SerializeField]
	private UILabel m_sHaveNum;

	[SerializeField]
	private GameObject m_goNewMark;

	[SerializeField]
	private UITexture m_txIcon;

	private int m_iRecipeID;

	public int RecipeID
	{
		get
		{
			return 0;
		}
	}

	public void Init(MasterItem master, bool unlock)
	{
	}
}
