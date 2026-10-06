using System;

[Serializable]
public class NPCTalkInfo
{
	public int iPosID;

	public ENPCPlace ePlace;

	public int iCharaID;

	public string strDefaultADV;

	public int iNO;

	public bool IsMatch(int iPosID, ENPCPlace ePlace)
	{
		return false;
	}
}
