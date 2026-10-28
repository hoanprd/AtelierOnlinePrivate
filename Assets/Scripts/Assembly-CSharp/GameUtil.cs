using System;
using System.Collections.Generic;
using UnityEngine;

public static class GameUtil
{
	public static readonly int[] aiQUALITY_THRESHOLD;

	public static readonly int[] aiQUALITY_THRESHOLD2;

	public static IDictionary<int, int> QualityStarMap;

	static GameUtil()
	{
		aiQUALITY_THRESHOLD = new int[] { 20, 40, 60, 80 };
		aiQUALITY_THRESHOLD2 = new int[] { 101, 105, 110, 115, 120 };
		QualityStarMap = new Dictionary<int, int>
		{
			{ 0, 1 },
			{ 1, 2 },
			{ 2, 3 },
			{ 3, 4 },
			{ 4, 5 }
		};
	}

	public static string MakeUserName()
	{
		string[] names = new string[]
		{
			"ガレット",
			"ジスト",
			"アクア",
			"ダイア",
			"エル",
			"パル",
			"ルビ",
			"ドット",
			"サイファ",
			"パオル",
			"パーズ",
			"コイズ",
			"パウド",
			"タルト",
			"エクア",
			"マカル",
			"ムース",
			"スフレ",
			"プッツェル",
			"ドロップ",
			"タフィー",
			"ドラジェ",
			"チョコ",
			"アイス"
		};
		return Util.ArrayRand(names);
	}

	public static EQuality GetQualityRank(int quarity)
	{
		for (int i = aiQUALITY_THRESHOLD.Length - 1; i >= 0; i--)
		{
			if (quarity >= aiQUALITY_THRESHOLD[i])
			{
				return (EQuality)(i + 2);
			}
		}
		return EQuality.eD;
	}

	public static int GetLimitBreakQualityRank(int quarity)
	{
		int rank = 0;
		for (int i = 0; i < aiQUALITY_THRESHOLD2.Length; i++)
		{
			if (quarity >= aiQUALITY_THRESHOLD2[i])
			{
				rank = i + 1;
			}
		}
		return rank;
	}

	public static int GetQualityStarNum(EQuality quality)
	{
		int key = Mathf.Clamp((int)quality - 1, 0, 4);
		int stars;
		if (QualityStarMap != null && QualityStarMap.TryGetValue(key, out stars))
		{
			return stars;
		}
		return 1;
	}

	public static int GetQualityStarNum(int quality)
	{
		return GetQualityStarNum(GetQualityRank(quality));
	}

	public static string GetCharacterName(int df)
	{
		if (df == 1 || df == 2)
		{
			return PlayerPrefs.GetString("USERNAME", MakeUserName());
		}
		if (MasterData.Chara != null)
		{
			MasterChara chara = MasterData.Chara.Load(df);
			if (chara != null && !string.IsNullOrEmpty(chara.NAME))
			{
				return chara.NAME;
			}
		}
		return string.Empty;
	}

	public static CharaDetail RemoveCannotEquip(CharaDetail detail, List<InventoryInfo> inventories, out bool cannot)
	{
		cannot = false;
		return detail;
	}

	public static MultiPlay_CharaMemberData ConvertFromMakeCharaData(MultiPlay_CharaMemberData multiplay, MakeCharaData data)
	{
		return multiplay;
	}

	public static MakeCharaData ConvertFromMuliplayChara(MultiPlay_CharaMemberData multiplay)
	{
		return new MakeCharaData();
	}

	public static MakeCharaData ConvertFromEquipData(int[] equip)
	{
		return new MakeCharaData();
	}

	public static AppearanceInfo ConvertFromMakeCaraData(MakeCharaData mk)
	{
		return new AppearanceInfo();
	}

	public static MakeCharaData ConvertFromCharaDetail(CharaDetail detail, List<InventoryInfo> inventory)
	{
		return new MakeCharaData();
	}

	public static MakeCharaData ConvertFromCharaDetail(PartyMember member, List<InventoryInfo> inventory)
	{
		return new MakeCharaData();
	}

	public static MakeCharaData ConvertFromEquipData(EquipData equip, EquipData visual, int[] disp, List<InventoryInfo> inventory)
	{
		return new MakeCharaData();
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
		return categ == ECategory.eWEAPON || categ == ECategory.eSHIELD || categ == ECategory.eHELM || categ == ECategory.eARMOR || categ == ECategory.eACCESSORY;
	}

	public static bool IsMaterial(ECategory categ)
	{
		return categ == ECategory.eMATERIAL;
	}

	public static List<ActiveSkill> GetCharaSkillList(int charaDF, int charaLV)
	{
		return new List<ActiveSkill>();
	}

	public static List<ActiveSkill> GetCharaBlazeArtsSkillList(CharaDetail charaDetail)
	{
		return new List<ActiveSkill>();
	}

	public static List<ActiveSkill> GetSkillList(int charaDF, int charaLV, EquipData equip, List<InventoryInfo> invList)
	{
		return new List<ActiveSkill>();
	}

	public static List<ActiveSkill> GetEquipSkillList(EquipData equip, List<InventoryInfo> invList)
	{
		return new List<ActiveSkill>();
	}

	public static IEnumerable<MultiPlay_InventoryInfo> GetLowQualityItemList(IEnumerable<InventoryInfo> invList, int itemDF, int num)
	{
		return new List<MultiPlay_InventoryInfo>();
	}

	public static ResponseData<T> GetDummyResponse<T>(string path)
	{
		TextAsset textAsset = Resources.Load<TextAsset>(path);
		if (textAsset != null && !string.IsNullOrEmpty(textAsset.text))
		{
			return JsonUtility.FromJson<ResponseData<T>>(textAsset.text);
		}
		return new ResponseData<T>();
	}

	public static T GetDummyResponse2<T>(string path)
	{
		TextAsset textAsset = Resources.Load<TextAsset>(path);
		if (textAsset != null && !string.IsNullOrEmpty(textAsset.text))
		{
			return JsonUtility.FromJson<T>(textAsset.text);
		}
		return Activator.CreateInstance<T>();
	}

	public static ResponseDataCommon GetDummyResponse(string path)
	{
		TextAsset textAsset = Resources.Load<TextAsset>(path);
		if (textAsset != null && !string.IsNullOrEmpty(textAsset.text))
		{
			return JsonUtility.FromJson<ResponseDataCommon>(textAsset.text);
		}
		return new ResponseDataCommon();
	}

	public static string GetConvertString(string org)
	{
		if (string.IsNullOrEmpty(org))
		{
			return string.Empty;
		}
		return org.Replace("{USERNAME}", PlayerPrefs.GetString("USERNAME", "レスナ"));
	}

	public static bool IsMultiplayRoom(string roomID)
	{
		return !string.IsNullOrEmpty(roomID);
	}

	public static bool IsLayer_NGUI(int layerId)
	{
		string layerName = LayerMask.LayerToName(layerId);
		if (string.IsNullOrEmpty(layerName))
		{
			return false;
		}
		return layerName.StartsWith("GUI") || layerName.Contains("UI") || layerName == "System";
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
		return new List<VersionData>();
	}

	public static List<VersionData> GetDownloadCharaAssetList(int df)
	{
		return new List<VersionData>();
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
		return string.Empty;
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
		UnityEngine.Object prefab = Resources.Load("UI/Common/Collision_TouchBlock");
		if (prefab != null)
		{
			return UnityEngine.Object.Instantiate(prefab) as GameObject;
		}
		GameObject fallback = new GameObject("TouchBlockCollision");
		return fallback;
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
		return new List<int>();
	}

	public static void LoadInventoryIcon(List<int> kindList)
	{
	}

	public static void UnLoadInventoryIcon(List<int> kindList)
	{
	}

	public static void CreateQuestOrderLimitConfirm(int questDF, Action<EButtonKind> onResult)
	{
		if (onResult != null)
		{
			onResult(EButtonKind.eDECIDE);
		}
	}

	public static void SetResolution(EResolutionLevel level)
	{
	}

	public static void SetResolution(float wid)
	{
	}

	public static void Shoot(GameObject goShootObj, Vector3 v3Target, float fAngle, Vector3? v3Gravity = null)
	{
		if (goShootObj == null)
		{
			return;
		}
		Vector3 gravity = v3Gravity.HasValue ? v3Gravity.Value : Physics.gravity;
		Vector3 velocity = CalculateVelocity(goShootObj, v3Target, fAngle, gravity);
		AddForce(goShootObj, velocity);
	}

	private static Vector3 CalculateVelocity(GameObject goShootObj, Vector3 v3Target, float fAngle, Vector3 v3Gravity)
	{
		if (goShootObj == null)
		{
			return Vector3.zero;
		}
		Vector3 dir = v3Target - goShootObj.transform.position;
		return dir;
	}

	private static void AddForce(GameObject goShootObj, Vector3 v3AddPower)
	{
		if (goShootObj == null)
		{
			return;
		}
		Rigidbody rb = goShootObj.GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.AddForce(v3AddPower, ForceMode.VelocityChange);
		}
	}

	public static void InitToggle(List<UIToggle> toggleList, int status)
	{
		if (toggleList == null)
		{
			return;
		}
		for (int i = 0; i < toggleList.Count; i++)
		{
			if (toggleList[i] != null)
			{
				toggleList[i].value = (i == status);
			}
		}
	}

	public static void InitBitFieldToggle(List<UIToggle> toggleList, int status)
	{
		if (toggleList == null)
		{
			return;
		}
		for (int i = 0; i < toggleList.Count; i++)
		{
			if (toggleList[i] != null)
			{
				toggleList[i].value = ((status & (1 << i)) != 0);
			}
		}
	}

	public static int SearchToggleOrder(List<UIToggle> toggleList, UIToggle target)
	{
		if (toggleList == null || target == null)
		{
			return -1;
		}
		return toggleList.IndexOf(target);
	}

	public static CharaSpec GetTotalParam(CharaDetail chara, EquipData equip, List<SubEquip> sub, List<InventoryInfo> invList)
	{
		return new CharaSpec();
	}

	public static CharaSpec GetCharaParamRow(CharaDetail chara)
	{
		return new CharaSpec();
	}

	public static EquipRate GetCharaSkillParamRate(CharaDetail chara, EquipData equip, List<InventoryInfo> inv)
	{
		return new EquipRate();
	}

	public static EquipParam GetCharaSkillParam(CharaDetail chara, EquipData equip, List<InventoryInfo> inv)
	{
		return new EquipParam();
	}

	public static EquipParam GetEquipParamRow(EquipData equip, List<InventoryInfo> invList)
	{
		return new EquipParam();
	}

	public static EquipParam GetEquipSubParamRow(List<SubEquip> sub, List<InventoryInfo> invList)
	{
		return new EquipParam();
	}

	public static EquipParam GetSkillParam(EquipData equip, List<InventoryInfo> invList)
	{
		return new EquipParam();
	}

	public static EquipRate GetSkillParamRate(EquipData equip, List<InventoryInfo> invList)
	{
		return new EquipRate();
	}
}
