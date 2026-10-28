using System;
using System.IO;
using System.Reflection;
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

		// 1. Try AssetBundleManager (handles local cache & Resources)
		UnityEngine.Object[] objs = AssetBundleManager.Load(path);
		if (objs != null)
		{
			for (int i = 0; i < objs.Length; i++)
			{
				T candidate = objs[i] as T;
				if (candidate != null)
				{
					output = candidate;
					break;
				}
			}
		}

		// 2. Direct Resources.Load fallback
		if (output == null && !string.IsNullOrEmpty(path))
		{
			output = Resources.Load<T>(path);
			if (output == null)
			{
				string fileName = Path.GetFileNameWithoutExtension(path);
				if (!string.IsNullOrEmpty(fileName))
				{
					output = Resources.Load<T>("Master/" + fileName);
				}
			}
		}

		// 3. Preloaded ScriptableObject in memory (e.g. soundList.asset on Sound_Manager, tips.asset on LoadingManager)
		if (output == null)
		{
			T[] existing = Resources.FindObjectsOfTypeAll<T>();
			if (existing != null && existing.Length > 0)
			{
				output = existing[0];
			}
		}

		// 4. Offline Client Mode fallback: create safe non-null ScriptableObject instance so game never halts on missing remote bundles
		if (output == null)
		{
			output = ScriptableObject.CreateInstance<T>();
			InitializeCollectionFields(output);
		}

		InvokeMakeMap(output);
		return output != null;
	}

	private static void InitializeCollectionFields(object target)
	{
		if (target == null)
		{
			return;
		}
		FieldInfo[] fields = target.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		for (int i = 0; i < fields.Length; i++)
		{
			FieldInfo f = fields[i];
			if (f.GetValue(target) != null)
			{
				continue;
			}
			Type ft = f.FieldType;
			if (ft.IsArray)
			{
				Type elemType = ft.GetElementType();
				if (elemType != null)
				{
					f.SetValue(target, Array.CreateInstance(elemType, 0));
				}
			}
			else if (ft.IsGenericType)
			{
				Type genDef = ft.GetGenericTypeDefinition();
				if (genDef == typeof(System.Collections.Generic.List<>) || genDef == typeof(System.Collections.Generic.Dictionary<,>))
				{
					try
					{
						f.SetValue(target, Activator.CreateInstance(ft));
					}
					catch
					{
					}
				}
			}
		}
	}

	public static void LoadLocalAssetBundle()
	{
		ModelInfo = Resources.Load("Master/equip") as MasterModel;
		if (ModelInfo == null)
		{
			Load("Master/Equip/equip", out ModelInfo);
		}

		Item = Resources.Load("Master/item") as MasterItemList;
		if (Item != null)
		{
			InvokeMakeMap(Item);
		}
		else
		{
			Load("Master/Item/item", out Item);
		}

		Chara = Resources.Load("Master/chara") as MasterCharaList;
		if (Chara != null)
		{
			InvokeMakeMap(Chara);
		}
		else
		{
			Load("Master/Chara/chara", out Chara);
		}
	}

	private static void InvokeMakeMap<T>(T master) where T : ScriptableObject
	{
		if (master == null)
		{
			return;
		}
		MethodInfo method = master.GetType().GetMethod("MakeMap", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (method != null && method.GetParameters().Length == 0)
		{
			try
			{
				method.Invoke(master, null);
			}
			catch
			{
			}
		}
	}

	public static bool LoadAssetBundle()
	{
		bool ok = true;
		ok &= Load("Master/Wealth/wealth", out Wealth);
		ok &= Load("Master/Skill/skill", out Skill);
		ok &= Load("Master/Equip/equip", out ModelInfo);
		ok &= Load("Master/Map/mapInfo", out MapInfo);
		ok &= Load("Master/Field/Area/areaDetail", out AreaDetail);
		ok &= Load("Master/Field/fieldName", out FieldName);
		ok &= Load("Master/Field/Area/areaInfo", out AreaInfo);
		ok &= Load("Master/Field/CameraFilter/cameraFilterInfo", out CameraFilterInfo);
		ok &= Load("Master/NPC/npcTalk", out NPCTalk);
		ok &= Load("Master/Gate/gateInfo", out GateInfo);
		ok &= Load("Master/Tips/tips", out Tips);
		ok &= Load("Master/Sound/soundList", out Sound);
		ok &= Load("Master/AdventBattle/adventbattle", out AdventBattle);
		ok &= Load("Master/Quest/quest", out Quest);
		ok &= Load("Master/Degree/degree", out Degree);
		ok &= Load("Master/Item/item", out Item);
		ok &= Load("Master/Chara/chara", out Chara);
		ok &= Load("Master/Chara/chara_group", out CharaGroup);
		ok &= Load("Master/Shop/shop", out ShopCategory);
		ok &= Load("Master/WorldMap/mapFacility", out MapFacility);
		ok &= Load("Master/Room/roomPlan", out RoomPlan);
		ok &= Load("Master/Room/roomMemberNum", out RoomMemberNum);
		ok &= Load("Master/BlazeArts/blaze_arts", out BlazeArts);
		ok &= Load("Master/Treasure/treasure", out Treasure);
		ok &= Load("Master/HardMode/hardModeInfo", out OpenHardModeInfo);
		ok &= LoadAssetBundleField();
		return ok;
	}

	public static bool LoadAssetBundleField()
	{
		bool ok = true;
		ok &= Load("Master/Skill/activeskilldirection", out ActiveSkillDir);
		ok &= Load("Master/Skill/skilldirection", out SkillDir);
		ok &= Load("Master/Enemy/enemy", out Enemy);
		ok &= Load("Master/Field/Dungeon/dungeonInfo", out DungeonInfo);
		ok &= Load("Master/Field/Town/townInfo", out TownInfo);
		ok &= Load("Master/Field/Item/fieldItem", out FieldItem);
		ok &= Load("Master/State/abnormalstate", out AbnormalState);
		ok &= Load("Master/State/abnormalstateeffect", out AbnormalEffect);
		ok &= Load("Master/Chat/chat", out Chat);
		ok &= Load("Master/Field/fairyRoute", out FairyRoute);
		ok &= Load("Master/Zone/zone", out Zone);
		ok &= Load("Master/Zone/zoneeffect", out ZoneEffect);
		ok &= Load("Master/Quest/extraquest", out ExtraQuest);
		return ok;
	}

	public static void ReleaseField()
	{
		ActiveSkillDir = null;
		SkillDir = null;
		Enemy = null;
		DungeonInfo = null;
		TownInfo = null;
		FieldItem = null;
		AbnormalState = null;
		AbnormalEffect = null;
	}
}
