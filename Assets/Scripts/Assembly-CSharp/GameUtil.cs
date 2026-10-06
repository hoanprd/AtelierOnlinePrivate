using System;
using System.Collections.Generic;
using UnityEngine;

public static class GameUtil
{
	public static readonly int[] aiQUALITY_THRESHOLD;

	public static readonly int[] aiQUALITY_THRESHOLD2;

	public static IDictionary<int, int> QualityStarMap;

	public static string MakeUserName()
	{
		return null;
	}

	public static EQuality GetQualityRank(int quarity)
	{
		return EQuality.eNONE;
	}

	public static int GetLimitBreakQualityRank(int quarity)
	{
		return 0;
	}

	public static int GetQualityStarNum(EQuality quality)
	{
		return 0;
	}

	public static int GetQualityStarNum(int quality)
	{
		return 0;
	}

	public static string GetCharacterName(int df)
	{
		return null;
	}

	public static CharaDetail RemoveCannotEquip(CharaDetail detail, List<InventoryInfo> inventories, out bool cannot)
	{
		cannot = default(bool);
		return null;
	}

	public static MultiPlay_CharaMemberData ConvertFromMakeCharaData(MultiPlay_CharaMemberData multiplay, MakeCharaData data)
	{
		return null;
	}

	public static MakeCharaData ConvertFromMuliplayChara(MultiPlay_CharaMemberData multiplay)
	{
		return null;
	}

	public static MakeCharaData ConvertFromEquipData(int[] equip)
	{
		return null;
	}

	public static AppearanceInfo ConvertFromMakeCaraData(MakeCharaData mk)
	{
		return null;
	}

	public static MakeCharaData ConvertFromCharaDetail(CharaDetail detail, List<InventoryInfo> inventory)
	{
		return null;
	}

	public static MakeCharaData ConvertFromCharaDetail(PartyMember member, List<InventoryInfo> inventory)
	{
		return null;
	}

	public static MakeCharaData ConvertFromEquipData(EquipData equip, EquipData visual, int[] disp, List<InventoryInfo> inventory)
	{
		return null;
	}

	public static int GetAccessoryModelID(ESubCategory categ, int[] ids)
	{
		return 0;
	}

	public static int GetAccessoryModelID(ESubCategory categ, int id)
	{
		return 0;
	}

	public static ESubCategory GetAccessoryKind(long id, List<InventoryInfo> inventory)
	{
		return ESubCategory.eALL;
	}

	public static int GetAccessoryModelID(ESubCategory categ, long[] ids, List<InventoryInfo> inventory)
	{
		return 0;
	}

	public static int GetModelID(int id)
	{
		return 0;
	}

	public static int GetModelID(long inventoryID, List<InventoryInfo> inventory)
	{
		return 0;
	}

	public static bool IsEquip(ECategory categ)
	{
		return false;
	}

	public static bool IsMaterial(ECategory categ)
	{
		return false;
	}

	public static List<ActiveSkill> GetCharaSkillList(int charaDF, int charaLV)
	{
		return null;
	}

	public static List<ActiveSkill> GetCharaBlazeArtsSkillList(CharaDetail charaDetail)
	{
		return null;
	}

	public static List<ActiveSkill> GetSkillList(int charaDF, int charaLV, EquipData equip, List<InventoryInfo> invList)
	{
		return null;
	}

	public static List<ActiveSkill> GetEquipSkillList(EquipData equip, List<InventoryInfo> invList)
	{
		return null;
	}

	public static IEnumerable<MultiPlay_InventoryInfo> GetLowQualityItemList(IEnumerable<InventoryInfo> invList, int itemDF, int num)
	{
		return null;
	}

	public static ResponseData<T> GetDummyResponse<T>(string path)
	{
		return null;
	}

	public static T GetDummyResponse2<T>(string path)
	{
		return default(T);
	}

	public static ResponseDataCommon GetDummyResponse(string path)
	{
		return null;
	}

	public static string GetConvertString(string org)
	{
		return null;
	}

	public static bool IsMultiplayRoom(string roomID)
	{
		return false;
	}

	public static bool IsLayer_NGUI(int layerId)
	{
		return false;
	}

	public static GameObject GetADVTarget(int objKind, int objNo)
	{
		return null;
	}

	public static void KillADVTarget(int objKind, int objNo)
	{
	}

	public static List<VersionData> GetDownloadItemAssetList(int df)
	{
		return null;
	}

	public static List<VersionData> GetDownloadCharaAssetList(int df)
	{
		return null;
	}

	public static void SetWealthIcon(int wealth, UITexture icon, UITexture face)
	{
	}

	public static void LoadBanner(string path, UITexture target, bool loadIcon = true)
	{
	}

	public static bool IsEnableLevelup(int charaDF, int lv, int lvCap, int nowEXP)
	{
		return false;
	}

	public static bool IsEnableLimitbreak(int charaDF, int grd)
	{
		return false;
	}

	public static string GetLimitBreakSpriteName(int limitBreakNum, int index)
	{
		return null;
	}

	public static int GetNeedLimitBreakCount(int charaDF, int grd)
	{
		return 0;
	}

	public static bool IsEnableFood(int charaDF, int grd, int fdm)
	{
		return false;
	}

	public static bool IsGrowBadge(int charaDF)
	{
		return false;
	}

	public static bool IsGrowBadge()
	{
		return false;
	}

	public static bool IsEnableBlazeArtsLevelup(int charaDF, List<BlazeArtsStatus> baStat)
	{
		return false;
	}

	public static bool IsEnableBlazeArtsLevelup()
	{
		return false;
	}

	public static int GetBlazeArtsCost(int baLv)
	{
		return 0;
	}

	public static GameObject CreateTouchBlockCollision()
	{
		return null;
	}

	public static int GetTotalPower(long[] items)
	{
		return 0;
	}

	public static int GetTotalPower(List<InventoryInfo> items)
	{
		return 0;
	}

	public static List<int> GetHaveInventoryKind()
	{
		return null;
	}

	public static void LoadInventoryIcon(List<int> kindList)
	{
	}

	public static void UnLoadInventoryIcon(List<int> kindList)
	{
	}

	public static void CreateQuestOrderLimitConfirm(int questDF, Action<EButtonKind> onResult)
	{
	}

	public static void SetResolution(EResolutionLevel level)
	{
	}

	public static void SetResolution(float wid)
	{
	}

	public static void Shoot(GameObject goShootObj, Vector3 v3Target, float fAngle, Vector3? v3Gravity = null)
	{
	}

	private static Vector3 CalculateVelocity(GameObject goShootObj, Vector3 v3Target, float fAngle, Vector3 v3Gravity)
	{
		return default(Vector3);
	}

	private static void AddForce(GameObject goShootObj, Vector3 v3AddPower)
	{
	}

	public static void InitToggle(List<UIToggle> toggleList, int status)
	{
	}

	public static void InitBitFieldToggle(List<UIToggle> toggleList, int status)
	{
	}

	public static int SearchToggleOrder(List<UIToggle> toggleList, UIToggle target)
	{
		return 0;
	}

	public static CharaSpec GetTotalParam(CharaDetail chara, EquipData equip, List<SubEquip> sub, List<InventoryInfo> invList)
	{
		return null;
	}

	public static CharaSpec GetCharaParamRow(CharaDetail chara)
	{
		return null;
	}

	public static EquipRate GetCharaSkillParamRate(CharaDetail chara, EquipData equip, List<InventoryInfo> inv)
	{
		return null;
	}

	public static EquipParam GetCharaSkillParam(CharaDetail chara, EquipData equip, List<InventoryInfo> inv)
	{
		return null;
	}

	public static EquipParam GetEquipParamRow(EquipData equip, List<InventoryInfo> invList)
	{
		return null;
	}

	public static EquipParam GetEquipSubParamRow(List<SubEquip> sub, List<InventoryInfo> invList)
	{
		return null;
	}

	public static EquipParam GetSkillParam(EquipData equip, List<InventoryInfo> invList)
	{
		return null;
	}

	public static EquipRate GetSkillParamRate(EquipData equip, List<InventoryInfo> invList)
	{
		return null;
	}
}
