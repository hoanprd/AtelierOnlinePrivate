using UnityEngine;

public class QuestCharaListItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sLV;

	[SerializeField]
	private GameObject m_goClearMark;

	[SerializeField]
	private GameObject m_goORderMark;

	[SerializeField]
	private GameObject m_goLockMark;

	public void Init(int chara, MasterChara.Qst target)
	{
	}
}
