using System;
using System.Collections.Generic;

[Serializable]
public class ResponseDataCommon
{
	public int ERR;

	public List<PopupInfo> POP;

	public ServerInfo SVR;

	public Session SES;

	public UserInfo USER;

	public PartyInfo PTY;

	public QuestSummary QST;

	public WealthList WTH;

	public UnlockGateList GT;

	public PresentList PNT;

	public AlchemyUserInfo ALC;

	public TutorialStatusList TUTO;

	public UnlockAreaList REG;

	public InventoryList INV;

	public InventoryList INV_ADD;

	public DailyMissionInfo DMS;

	public List<PopupInfo> GetPopup()
	{
		return null;
	}

	public void RegistErrorPopup(string msg)
	{
	}

	public void RegistError(int error)
	{
	}

	public void RegistPopup(string msg)
	{
	}

	public ResponseDataCommon Clone()
	{
		return null;
	}
}
