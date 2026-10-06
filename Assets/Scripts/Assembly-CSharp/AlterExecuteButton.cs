using UnityEngine;

public class AlterExecuteButton : MonoBehaviour
{
	public UIButton m_sButton;

	public UILabel m_sName;

	public UILabel m_sAmount;

	public UITexture m_txPicture;

	public GameObject m_goEnable;

	public GameObject m_goEnable2;

	public UILabel m_sDisableInfo;

	public GameObject m_goLackEther;

	public GameObject m_goEnableAnim;

	public string ExecuteButtonName
	{
		get
		{
			return null;
		}
	}

	public void Init(MasterItem master, int have, EQuality quarity, bool enable, bool enableCost, bool enableSpoon, bool enableMaterial)
	{
	}
}
