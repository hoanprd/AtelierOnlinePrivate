using System;

[Serializable]
public class ProductInfo
{
	public int PLAT;

	public string PRD;

	public string NM;

	public int PRC;

	public int RWD;

	public int DSP;

	public int ICON;

	public int LMT;

	public string OPDT;

	public string CLDT;

	public RewardInfoExt[] rewards;

	public int limitType;

	public string limitStart;

	public string limitEnd;

	public int buyCnt;
}
