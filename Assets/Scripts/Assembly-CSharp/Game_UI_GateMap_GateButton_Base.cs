public class Game_UI_GateMap_GateButton_Base : NGUI_ClickButton
{
	protected int m_iArea;

	protected int m_iStage;

	protected int m_iSpawnNo;

	protected string m_strDialogName;

	public virtual void SetInfo(int iArea, int iStage, int iSpawnNo, string strGateName)
	{
	}

	protected override void DecideButton()
	{
	}
}
