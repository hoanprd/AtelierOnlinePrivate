using UnityEngine;

public class Game_UI_GateMap_WarpPoint : Game_UI_GateMap_GateButton_Base
{
	private enum eColorObj
	{
		Diamond = 0,
		EnumMax = 1
	}

	private enum eMarkSprite
	{
		Normal = 0,
		Academy = 1,
		EnumMax = 2
	}

	private static readonly string[] sc_strMarkNameAry;

	private bool m_bNameActiveLog;

	private bool m_bIsAcademy;

	[SerializeField]
	private UISprite[] m_scrColor;

	[SerializeField]
	private UISprite m_scrPointMark;

	[SerializeField]
	private GameObject m_goMyAreaObj;

	[SerializeField]
	private UITexture m_scrMyFace;

	[SerializeField]
	private UILabel m_scrGateName;

	[SerializeField]
	private UITweenReset m_scrNameTweenR;

	[SerializeField]
	private GameObject m_goNextMark;

	[SerializeField]
	private GameObject m_goAcademyMark;

	[SerializeField]
	private GameObject m_goDungeonMark;

	[SerializeField]
	private GameObject m_goActivateRoot;

	protected override void AwakeSub()
	{
	}

	protected void Start()
	{
	}

	private void ChangeColor(Color cColor)
	{
	}

	private void SetActiveMyAreaObj(bool bActive)
	{
	}

	private void SetWarpPointMark(eMarkSprite eKind)
	{
	}

	public void SetInfo(int iArea, int iStage, int iSpawnNo, string strGateName, string strDialogName, bool bDungeon)
	{
	}

	public void SetActiveNextMark(bool bActive)
	{
	}

	public void SetActiveGateName(bool bActive)
	{
	}

	public void SetActiveWarpPoint(bool bActive)
	{
	}
}
