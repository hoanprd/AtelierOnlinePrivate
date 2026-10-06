using System.Collections.Generic;
using System.Runtime.InteropServices;
using ADV;
using UnityEngine;

public static class UIDefine
{
	[StructLayout((LayoutKind)0, Size = 24)]
	public struct EquipParamInfo
	{
		public int iIconID;

		public string sName;

		public string sSubName;

		public EquipParamInfo(int icon, string name, string subName)
		{
			iIconID = 0;
			sName = null;
			sSubName = null;
		}
	}

	public static readonly Color[] asRARE_COLOR;

	public static readonly Color32[] asBALOON_COLOR;

	public static readonly Color32[] asPLAYERMARK_COLOR;

	public static readonly Dictionary<EParamKind, EquipParamInfo> cvPARAM_INFO;

	public static readonly Dictionary<EQuestGroup, string> cvQUEST_GROUP;

	public static readonly string scCompositeAddLvColor;

	public static readonly string scCompositeAddQualityColor;

	public static readonly string scWarningColorRed;

	public static readonly Color32 sccWarningColorRed;

	public static readonly Color32 sccColorWhite;

	public static string GetFloorName(int iFloor)
	{
		return null;
	}

	public static int GetCharaID(CharaDetail ch)
	{
		return 0;
	}

	public static int GetCharaID(int ch)
	{
		return 0;
	}

	public static string GetJobIconPath(int jobKind)
	{
		return null;
	}

	public static string GetFaceIconPath(int id, bool getCharaID = true)
	{
		return null;
	}

	public static string GetFaceIconPathMulti(int id)
	{
		return null;
	}

	public static string GetCharaImagePath(int id, EFeel emotion = EFeel.eDEFAULT)
	{
		return null;
	}

	public static string GetCharaRawImagePath(int id, EFeel emotion = EFeel.eDEFAULT)
	{
		return null;
	}

	public static string GetCharaBustupImagePath(int id)
	{
		return null;
	}

	public static string GetEnemeyImagePath(int kind, int category)
	{
		return null;
	}

	public static string GetEnemeyIconPath(int kind, int category)
	{
		return null;
	}

	public static string GetWealthIconPath(int icon)
	{
		return null;
	}

	public static string GetAreaIconPath(int icon)
	{
		return null;
	}

	public static string GetCategoryIconName(ESubCategory icon)
	{
		return null;
	}

	public static string GetCategoryIconName(int icon)
	{
		return null;
	}

	public static string GetItemPicturePath(int itemID)
	{
		return null;
	}

	public static string GetItemMiniPicturePath(int itemID)
	{
		return null;
	}

	public static string GetADVItemPicturePath(int itemID)
	{
		return null;
	}

	public static string GetEventBanner(int eventID)
	{
		return null;
	}

	public static Color GetRarityColor(ERarity rarity)
	{
		return default(Color);
	}

	public static string GetDegreeIconPath(MasterDegreeInfo master)
	{
		return null;
	}

	public static string GetActiveSkillIconPath(string fileName)
	{
		return null;
	}

	public static string GetQuestTypeMarkName(EQuestType type)
	{
		return null;
	}

	public static string QuestCategoryName(EQuestGroup group)
	{
		return null;
	}

	public static string GetRankingRankString(int rank)
	{
		return null;
	}

	public static string GetRankingScoreString(long score)
	{
		return null;
	}

	public static string GetRankingScoreTexPath(int type, int cycle)
	{
		return null;
	}

	public static string GetPriceText(int price)
	{
		return null;
	}

	public static string GetElementIcon(EElement elem)
	{
		return null;
	}

	public static string GetElementName(EElement elem)
	{
		return null;
	}
}
