using System;
using System.Collections.Generic;

[Serializable]
public class HomeEnter
{
	[Serializable]
	public class EnableState
	{
		public int NO;

		public string NA;
	}

	[Serializable]
	public class PresetnInfo
	{
		public int CNT;
	}

	[Serializable]
	public class LevelLimit
	{
		public int MIN_LV;

		public int MAX_LV;
	}

	[Serializable]
	public class LoginBonusResponse
	{
		public List<LoginBonus> loginBonusList;
	}

	[Serializable]
	public class LoginBonus
	{
		public int bonusId;

		public int type;

		public int isRepeat;

		public string open;

		public string close;

		public List<LoginBonusSheetInfo> sheetInfos;

		public int sheetIdNow;

		public int dayCntNow;

		public ShopBanner banner;
	}

	[Serializable]
	public class LoginBonusSheetInfo
	{
		public int sheetId;

		public List<LoginBonusDailyInfo> dailyInfos;
	}

	[Serializable]
	public class LoginBonusDailyInfo
	{
		public int dayCnt;

		public List<RewardInfoExt> rewards;

		public string adv;

		public int charaDf;
	}

	[Serializable]
	public class GachaBadgeInfo
	{
		public int IS_UPDT;

		public Dictionary<string, List<GachaInfo.SellInfo>> GI;
	}

	public List<EnableState> MIN;

	public PresetnInfo PNT;

	public int MVD;

	public Formula EXP_COEF;

	public LevelLimit LV_LIMIT;

	public LoginBonusResponse LOGIN_BONUS;

	public List<ShopBanner> BNRS;

	public GachaBadgeInfo GB;

	public ShopGachaLot GACHA_RESULT;

	public MiniRankingInfo MMRI;

	public DegreeInfo TTL;
}
