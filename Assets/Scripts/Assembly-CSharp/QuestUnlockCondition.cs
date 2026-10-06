using UnityEngine;

public class QuestUnlockCondition : MonoBehaviour
{
	[SerializeField]
	protected UITexture m_txFaceIcon;

	[SerializeField]
	protected UITexture m_txDegreeIcon;

	[SerializeField]
	protected GameObject m_goNextLine;

	[SerializeField]
	protected UISprite m_sProgressMark;

	[SerializeField]
	protected GameObject m_goClearMark;

	public void Init(MasterQuestInfo.UnlockTitle title, DegreeMissionInfo[] progress, bool next = true)
	{
	}

	protected void InitProgress(int now, int max)
	{
	}
}
