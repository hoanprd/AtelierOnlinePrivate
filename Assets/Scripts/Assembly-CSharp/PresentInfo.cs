using System;

[Serializable]
public class PresentInfo
{
	public long ID;

	public string TTL;

	public string MSG;

	public int ICON;

	public string EPR;

	public string SND;

	public PresentItemInfo[] ITEM;

	public PresentWealthInfo[] WTH;

	public PresentCharaInfo[] CHR;
}
