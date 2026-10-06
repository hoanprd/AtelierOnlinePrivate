using UnityEngine;

public class MasterData
{
	public static MasterSkill Skill;

	public static MasterItemList Item;

	public static MasterCharaList Chara;

	public static MasterCharaGroupList CharaGroup;

	public static MasterModel ModelInfo;

	public static MasterAreaDetail AreaDetail;

	public static MasterMapInfo MapInfo;

	public static MasterFieldName FieldName;

	public static MasterWealthList Wealth;

	public static MasterAreaInfo AreaInfo;

	public static MasterDegree Degree;

	public static MasterCameraFilterInfo CameraFilterInfo;

	public static MasterNPCTalk NPCTalk;

	public static MasterGateInfo GateInfo;

	public static MasterTipsList Tips;

	public static MasterSoundList Sound;

	public static MasterAdventBattle AdventBattle;

	public static MasterShopCategory ShopCategory;

	public static MasterMapFacility MapFacility;

	public static MasterBlazeArtsList BlazeArts;

	public static MasterHardModeInfo OpenHardModeInfo;

	public static MasterEnemy Enemy;

	public static MasterDungeonInfo DungeonInfo;

	public static MasterTownInfo TownInfo;

	public static MasterFieldItem FieldItem;

	public static MasterChat Chat;

	public static MasterFairyRoute FairyRoute;

	public static MasterExtraQuestData ExtraQuest;

	public static MasterActiveSkillDirection ActiveSkillDir;

	public static MasterSkillDirection SkillDir;

	public static MasterAbnormalState AbnormalState;

	public static MasterAbnormalStateEffect AbnormalEffect;

	public static MasterZone Zone;

	public static MasterZoneEffect ZoneEffect;

	public static MasterRoomPlan RoomPlan;

	public static MasterRoomMemberNum RoomMemberNum;

	public static MasterQuest Quest;

	public static MasterTreasure Treasure;

	private static bool Load<T>(string path, out T output) where T : ScriptableObject
	{
		output = null;
		return false;
	}

	public static void LoadLocalAssetBundle()
	{
	}

	private static void InvokeMakeMap<T>(T master) where T : ScriptableObject
	{
	}

	public static bool LoadAssetBundle()
	{
		return false;
	}

	public static bool LoadAssetBundleField()
	{
		return false;
	}

	public static void ReleaseField()
	{
	}
}
