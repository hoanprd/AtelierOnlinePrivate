public static class GameDefine
{
	public const string csBundleVersion = "3.15.3";

	public const string IOS_BUILD_NUMBER = "104";

	public const int AOS_BUNDLE_VERSION_CODE = 104;

	public const int ciVESION = 31503;

	public const string IOS_DEPLOYMENT_TARGET = "9.0";

	public const int ciSELECT_MAX = 20;

	public const string sKEY_USERID = "USERID";

	public const string sKEY_USERNAME = "USERNAME";

	public const string sKEY_UUID = "UUID";

	public const string sKEY_CUSTOMERID = "CUSTOMERID";

	public const string sKEY_GATEMAP = "GATEMAP";

	public const string sKEY_STRATEGY_KIND = "STRATEGYKIND";

	public const string sKEY_TIMESCALE = "TIMESCALE";

	public const string sKEY_CONTROLER = "CONTROLER";

	public const string sKEY_RAREANIM = "RAREANIM";

	public const string sKEY_AUTOPICK_BOMB = "AUTOPICK_BOMB";

	public const string sKEY_USE_CONTAINER_ITEM = "USE_CONTAINER_ITEM";

	public const string sKEY_IGNORE_TUTORIAL = "IGNORE_TUTORIAL";

	public const string sKEY_RESOLUTION = "RESOLUTION_LEVEL";

	public const string sKEY_ALL_ASSET_DOWNLOAD = "ASSET_ALL_DOWNLOAD";

	public const string sKEY_DISASSEMBLE_VALUE = "DISASSEMBLE_VALUE";

	public const string sKEY_AGREE_TERMS = "AGREE_TERMS";

	public const string sKEY_AGREE_KTG_TERMS = "AGREE_KTG_TERMS";

	public const string sKEY_LOGINBONUS_INFO = "LOGIN_BONUS_INFO";

	public const string sKEY_NEED_CHARAMAKE = "CHARA_MAKE";

	public const string sKEY_FIRST_GEN_CHOOSED = "FIRST_GEN_CHOOSED";

	public const string sKEY_FREE_QUEST_SORT_ORDER = "FREE_QUEST_SORT_ORDER";

	public const string sKEY_FREE_QUEST_SORT = "FREE_QUEST_SORT";

	public const string sKEY_FREE_QUEST_REWARD_FILTER = "FREE_QUEST_REWARD_FILTER";

	public const string sKEY_FREE_QUEST_TYPE_FILTER = "FREE_QUEST_TYPE_FILTER";

	public const string sKEY_FREE_QUEST_CONDITION_FILTER = "FREE_QUEST_CONDITION_FILTER";

	public const string sKEY_HSP_SNO = "HSP_SNO";

	private static readonly string[] sPHOTON_HASHKEY;

	public static string sBASE_URL;

	public static readonly string sROOM_ID;

	public static string sAPI_URL;

	public static string sWEB_URL;

	public static string sASSET_URL;

	public const int iPLAYER_MAX = 4;

	public const int iPARTY_MAX = 4;

	public const int iQUEST_MAX = 5;

	public const int iEVENT_QUEST_MAX = 5;

	public const int iDISP_LIMITBREAK_STAR = 6;

	public const int iSYNC_ITEM_MAX = 20;

	public const int iSYNC_ITEM_FILL = 10;

	public const int DEFAULT_ROOM_QUEST_ID = 0;

	public const int ACADEMY_AREA_ID = -1;

	public const int ACADEMY_STAGE_ID = -1;

	public const int DEFAULT_SPAWN_ID = 0;

	public const int SAFETY_LIMIT_5 = 5;

	public const int SAFETY_LIMIT_10 = 10;

	public static readonly string sExtraQuestRoomGroup;

	public const int EXQ_ROOM_MEMBER_MAX = 4;

	public static string SERVER_NAME_KEY;

	public static int QualityLimit;

	public static string AssetURL
	{
		get
		{
			return null;
		}
	}

	public static string AssetCommonURL
	{
		get
		{
			return null;
		}
	}

	public static bool IsiPhoneX()
	{
		return false;
	}

	public static bool IsUnsupportedDevice()
	{
		return false;
	}

	public static EPlatformKind GetPlatformKind()
	{
		return EPlatformKind.eUNKNOWN;
	}

	public static string GetPhotonHashKey(EPhotonHashKey key)
	{
		return null;
	}

	public static string GetRoomIndexHashKey(int playerId)
	{
		return null;
	}

	public static ENavMeshArea GetNavMeshArea(int mask)
	{
		return ENavMeshArea.Walkable;
	}

	public static bool IsAllAssetDL()
	{
		return false;
	}

	public static string GetCurrentBaseURL()
	{
		return null;
	}
}
