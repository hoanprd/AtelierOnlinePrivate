using Tutorial;

public class TutorialCommandQuestBoard : TutorialCommandBase
{
	private bool m_bAPIEnd;

	private void OnAPIQuestShow(QuestShowResponse clsRes)
	{
	}

	public override void Exec(Data clsData)
	{
	}

	public override bool IsEnd()
	{
		return false;
	}
}
