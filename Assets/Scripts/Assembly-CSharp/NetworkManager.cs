using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Network;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
	private bool m_bIgnoreSession;

	private List<APIBase> m_vRequestQueue = new List<APIBase>();

	private NetworkRequest m_sReq;

	private static bool s_bInit;

	private static NetworkManager s_sInstance;

	private int m_iOfflinePending;

	public static NetworkManager Instance
	{
		get
		{
			if (s_sInstance == null)
			{
				s_sInstance = UnityEngine.Object.FindAnyObjectByType<NetworkManager>();
				if (s_sInstance == null)
				{
					GameObject go = new GameObject("NetworkManager");
					UnityEngine.Object.DontDestroyOnLoad(go);
					s_sInstance = go.AddComponent<NetworkManager>();
				}
			}
			return s_sInstance;
		}
	}

	public int RequestNum
	{
		get
		{
			return ((m_vRequestQueue != null) ? m_vRequestQueue.Count : 0) + m_iOfflinePending;
		}
	}

	private static long GetLocalUserId()
	{
		string s = PlayerPrefs.GetString(GameDefine.sKEY_USERID, "10000001");
		if (long.TryParse(s, out long id) && id > 0)
		{
			return id;
		}
		return 10000001L;
	}

	private static string GetLocalUserName()
	{
		string name = PlayerPrefs.GetString(GameDefine.sKEY_USERNAME, string.Empty);
		if (string.IsNullOrEmpty(name))
		{
			name = "ロロナ";
		}
		return name;
	}

	private static void FillCommon(ResponseDataCommon res)
	{
		if (res == null)
		{
			return;
		}
		res.ERR = 0;
		if (res.POP == null)
		{
			res.POP = new List<PopupInfo>();
		}
		if (res.SVR == null)
		{
			res.SVR = new ServerInfo
			{
				MODE = 0,
				TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
				NTC = new List<NoticeInfo>()
			};
		}
		if (res.SES == null)
		{
			res.SES = new Session
			{
				ID = 1,
				CNT = 1,
				CV = GameDefine.ciVESION
			};
		}
		if (res.USER == null)
		{
			res.USER = new UserInfo
			{
				ID = GetLocalUserId(),
				CD = GetLocalUserId().ToString(),
				NA = GetLocalUserName(),
				PASS = string.Empty,
				URL = string.Empty
			};
		}
	}

	private static T CreateOfflineResponse<T>() where T : ResponseDataCommon, new()
	{
		T res = new T();
		FillCommon(res);
		FieldInfo apiField = typeof(T).GetField("API", BindingFlags.Instance | BindingFlags.Public);
		if (apiField != null && apiField.GetValue(res) == null)
		{
			try
			{
				object apiObj = Activator.CreateInstance(apiField.FieldType);
				InitializeNestedFields(apiObj, 0);
				apiField.SetValue(res, apiObj);
			}
			catch
			{
			}
		}
		return res;
	}

	private static void InitializeNestedFields(object obj, int depth)
	{
		if (obj == null || depth > 2)
		{
			return;
		}
		FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public);
		for (int i = 0; i < fields.Length; i++)
		{
			FieldInfo f = fields[i];
			if (f.GetValue(obj) != null)
			{
				continue;
			}
			Type ft = f.FieldType;
			if (ft == typeof(string))
			{
				f.SetValue(obj, string.Empty);
			}
			else if (ft.IsArray)
			{
				Type elem = ft.GetElementType();
				if (elem != null)
				{
					f.SetValue(obj, Array.CreateInstance(elem, 0));
				}
			}
			else if (ft.IsGenericType)
			{
				Type def = ft.GetGenericTypeDefinition();
				if (def == typeof(List<>) || def == typeof(Dictionary<,>))
				{
					try
					{
						f.SetValue(obj, Activator.CreateInstance(ft));
					}
					catch
					{
					}
				}
			}
			else if (ft.IsClass && !ft.IsAbstract && ft.Namespace != "UnityEngine")
			{
				try
				{
					object child = Activator.CreateInstance(ft);
					InitializeNestedFields(child, depth + 1);
					f.SetValue(obj, child);
				}
				catch
				{
				}
			}
		}
	}

	private static void DeliverCommon(Response callback, ResponseDataCommon data = null)
	{
		if (data == null)
		{
			data = new ResponseDataCommon();
			FillCommon(data);
		}
		Instance.StartCoroutine(Instance.DeliverCommonCoroutine(callback, data));
	}

	private IEnumerator DeliverCommonCoroutine(Response callback, ResponseDataCommon data)
	{
		m_iOfflinePending++;
		yield return null;
		m_iOfflinePending = Mathf.Max(0, m_iOfflinePending - 1);
		if (callback != null)
		{
			callback(data);
		}
	}

	private static void DeliverMsgPack<T>(MsgPackResponse<T> callback, T data = null) where T : ResponseDataCommon, new()
	{
		if (data == null)
		{
			data = CreateOfflineResponse<T>();
		}
		else
		{
			FillCommon(data);
		}
		Instance.StartCoroutine(Instance.DeliverMsgPackCoroutine(callback, data));
	}

	private IEnumerator DeliverMsgPackCoroutine<T>(MsgPackResponse<T> callback, T data) where T : ResponseDataCommon
	{
		m_iOfflinePending++;
		yield return null;
		m_iOfflinePending = Mathf.Max(0, m_iOfflinePending - 1);
		if (callback != null)
		{
			callback(data);
		}
	}

	public static void AlchemyRecipeList(MsgPackResponse<AlchemyInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void AlchemyRecipeInfo(int recipeID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void AlchemyConfirm(int recipeID, long[] ingredients, long free, MsgPackResponse<AlchemyConfirmResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void AlchemyAlter(int recipeID, long[] ingredients, long free, MsgPackResponse<AlchemyAlterResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void AlchemyPickTrait(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void BannerInfo(BannerCategory category, MsgPackResponse<BannerInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void WealthInfo(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void DailyMissionInfo(MsgPackResponse<MissionDailyResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void TitleMissionInfo(MsgPackResponse<MissionTitleResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void SendChat(string message, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventoryHold(long id, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventoryUnhold(long id, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void Initialize()
	{
		s_bInit = true;
	}

	public static void CheckNgWord(string comment, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void BattleStart(int battleID, MsgPackResponse<BattleStartResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void BattleJoin(long user, MsgPackResponse<BattleJoinResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void BattleFinish(int battleID, long[] useItem, int[] killEnemy, int skillCount, int skillChainCount, List<APIBattleFinish.Request.UseSkill> useSkillList, int[] score, int countBlazeArts, MsgPackResponse<BattleFinishResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void BattleEscape(int battleID, long[] useItem, int countBlazeArts, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void BattleRevive(int ItemID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void BattleAnnihilated(int battleID, long[] useItem, int countBlazeArts, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void DungeonInfo(int dangeonID, MsgPackResponse<DungeonInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void DungeonCreate(int dangeonID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void DungeonFloorInfo(int dangeonID, int floor, MsgPackResponse<DungeonFloorInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void DungeonFloorCreate(int dangeonID, int floor, APIExploreDungeonFloorCreate.Request.PosInfo posInfo, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void DungeonFloorEnter(int dangeonID, int floor, MsgPackResponse<DungeonFieldDataResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void DungeonFloorReload(int dangeonID, int floor, MsgPackResponse<DungeonFieldDataResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void DungeonFloorStamp(int dangeonID, int floor, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void DungeonFloorLeave(int dangeonID, int floor, MsgPackResponse<FieldDataResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void DungeonLeave(int dangeonID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FieldEnter(int fieldID, MsgPackResponse<FieldEnterResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FieldEnter2(long roomID, int roomIndex, MsgPackResponse<FieldEnter2Response> callback)
	{
		DeliverMsgPack(callback);
	}

	[DebuggerHidden]
	public static IEnumerator TutorialFieldEnter2(MsgPackResponse<FieldEnter2Response> callback)
	{
		FieldEnter2Response res = CreateOfflineResponse<FieldEnter2Response>();
		yield return null;
		if (callback != null)
		{
			callback(res);
		}
	}

	public static void SpotPick(int spotID, long item, MsgPackResponse<APISpotPickResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GimmickActivate(int no, long useItemID, MsgPackResponse<GimmickActivateResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ItemHeal(long[] itemIdList, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void ItemCure(long[] itemIdList, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void ItemSprinkle(long[] itemIdList, MsgPackResponse<ItemSprinkleResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FieldGateInfo(int gateID, MsgPackResponse<GateInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GateStamp(int gateID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void GateJump(int gateID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FieldReload(long roomId, MsgPackResponse<FieldReloadResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RoomCreate(string roomName, int fieldID, MsgPackResponse<ExploreRoomCreateResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void RoomInfo(MsgPackResponse<ExploreRoomInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void RoomLeave(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FairyItem(int df, MsgPackResponse<FairyItemResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FairyPick(int ticket, int area, int dungeon, MsgPackResponse<FairyPickResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FairyArea(MsgPackResponse<FairyAreaResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ForgeSummary(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void ForgeInfo(long target, MsgPackResponse<ForgeInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ForgeEnforce(long target, long[] feeds, MsgPackResponse<ForgeResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ForgeQualitySummary(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void ForgeQualityInfoInfo(long target, MsgPackResponse<ForgeQualityInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ForgeQualityEnforce(long target, MsgPackResponse<ForgeResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FriendList(MsgPackResponse<FriendInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FriendSearch(long targetID, MsgPackResponse<FriendSearchResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FriendRequest(long targetID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendRequest(long[] targets, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendAccept(long targetID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendAccept(long[] targets, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendDelete(long targetID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendDelete(long[] targets, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendMute(long targetID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendMute(long[] targets, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendMuteCancel(long targetID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendMuteCancel(long[] targets, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void FriendProfile(long target, MsgPackResponse<FriendProfileResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void OtherProfile(long target, MsgPackResponse<FriendProfileResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GachaInfo(MsgPackResponse<GachaInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GachaShow(int id, MsgPackResponse<ShopGachaShowResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GachaDisassemble(int df, List<APIHomeShopGachaDisassemble.Request.LotInfo> lot, MsgPackResponse<ShopGachaDisassembleResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GachaLot(int id, int sellid, MsgPackResponse<ShopGachaLotResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void GrowInfo(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void GrowCharaShow(int chara, MsgPackResponse<GrowCharaShowResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ExceedInfo(int chara, MsgPackResponse<ExceedInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ExceedApply(int chara, MsgPackResponse<ExceedResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FoodInfo(int chara, MsgPackResponse<FoodInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void FoodApply(int chara, long[] foods, MsgPackResponse<FoodResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PotionInfo(int chara, MsgPackResponse<GrowPotionResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void BlazeMaterialInfo(int chara, MsgPackResponse<GrowBlazeArtsMateriaResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PotionApply(int chara, long[] potion, MsgPackResponse<PotionResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void BlazeMateriaApply(int chara, long[] bMat, int ba, MsgPackResponse<BlazeMateriaResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HomeEnter(MsgPackResponse<HomeEnterResponse> callback)
	{
		HomeEnterResponse res = CreateOfflineResponse<HomeEnterResponse>();
		if (res.API == null)
		{
			res.API = new HomeEnter();
		}
		if (res.API.MIN == null)
		{
			res.API.MIN = new List<HomeEnter.EnableState>();
		}
		if (res.API.PNT == null)
		{
			res.API.PNT = new HomeEnter.PresetnInfo { CNT = 0 };
		}
		if (res.API.LV_LIMIT == null)
		{
			res.API.LV_LIMIT = new HomeEnter.LevelLimit { MIN_LV = 1, MAX_LV = 100 };
		}
		if (res.API.LOGIN_BONUS == null)
		{
			res.API.LOGIN_BONUS = new HomeEnter.LoginBonusResponse
			{
				loginBonusList = new List<HomeEnter.LoginBonus>()
			};
		}
		if (res.API.BNRS == null)
		{
			res.API.BNRS = new List<ShopBanner>();
		}
		if (res.API.GB == null)
		{
			res.API.GB = new HomeEnter.GachaBadgeInfo
			{
				IS_UPDT = 0,
				GI = new Dictionary<string, List<GachaInfo.SellInfo>>()
			};
		}
		DeliverMsgPack(callback, res);
	}

	public static void PresentSummary(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PresentReceive(long[] list, MsgPackResponse<PresentReceiveResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HomeGateInfo(MsgPackResponse<GateInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void AuthTicket(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void HuntMemberChoose(int huntID, int formID, List<FormationInfo> party, MsgPackResponse<HuntMemberChooseResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HuntRecommend(int huntID, int formID, List<FormationInfo> party, MsgPackResponse<HuntRecommendResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HuntResult(int formID, eHuntReturnType returnType, int wealthDF, MsgPackResponse<HuntResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HuntStart(int huntID, int formID, eHuntReturnType returnType, int wealthDF, int leaderID, int clearSec, MsgPackResponse<HuntStartResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HuntStatus(MsgPackResponse<HuntStatusResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void HuntSummary(MsgPackResponse<HuntSummaryResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void InventorySummary(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventorySummary(int[] categoryList, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventoryDrop(long[] inventoryID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventoryDispose(long[] inventoryID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventoryRestore(long[] list, MsgPackResponse<RestoreResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void InventoryReposit(long[] inventoryID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void InventoryBring(long[] inventoryID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void OverwriteSummary(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void OverwritePickTrait(long target, MsgPackResponse<PickTraitResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void OverwriteExecute(long targetID, long feedID, MsgPackResponse<OverwriteExecuteResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyInfo(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyMemberInfo(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyMemberDetail(int charaID, MsgPackResponse<PartyMemberShowResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyMemberChoose(FormationInfo[] form, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyEquipInfo(int charaID, int category, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyEquipChoose(int charaID, EquipData equip, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyVisualEquipChoose(int charaID, EquipData equip, int[] disp, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyEquipRecommend(int charaID, int equipKind, int statusPriority, MsgPackResponse<EquipRecommendResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyEquipSubInfo(int charaID, MsgPackResponse<SubEquipInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyEquipSubChoose(int charaID, SubEquip[] sub, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void PartyItemInfo(MsgPackResponse<PartyItemResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyItemChoose(PartyItemInfo item, MsgPackResponse<PartyItemChooseResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyFavoriteInfo(int charaDF, MsgPackResponse<PartyEquipFavoListResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyFavoriteRegister(int charaDF, int no, string name, EquipData equ, List<SubEquip> sub, int kind, MsgPackResponse<PartyEquipFavoRegisterResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PartyFavoriteErase(int charaDF, int no, int kind, MsgPackResponse<PartyEquipFavoEraseResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ProductInfo(MsgPackResponse<ProductInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void PurchaseProduct(string productId, string receipt_json, string signature, MsgPackResponse<ProductPurchaseResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void RegisterAge(int age, bool never_again, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void GetMyProfile(MsgPackResponse<ProfileInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void SetProfileTitle(DegreeInfo degree, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void SetProfileComment(string comment, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void UpdateTakeoverCode(MsgPackResponse<TakeoverCodeResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ExecTakeover(long userId, string takeoverCode, string sno, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void QuestSummary(MsgPackResponse<QuestSummaryResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void QuestShow(int questID, MsgPackResponse<QuestShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void QuestReceive(int questID, MsgPackResponse<QuestStartResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void QuestDeparture(int questID, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void QuestDeliver(int questID, long[] inventoryList, MsgPackResponse<QuestDeliverResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void QuestGiveup(int questID, MsgPackResponse<QuestGiveupResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void QuestFill(Response callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverCommon(callback);
	}

	public static void QuestTalk(int DF, MsgPackResponse<QuestTalkResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void QuestAchieve(int DF, Response callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverCommon(callback);
	}

	public static void ExtraQuestClear(int DF, int KeyCharaNum, Response callBack = null)
	{
		DeliverCommon(callBack);
	}

	public static void RankingSummary(MsgPackResponse<RankingSummaryResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RankingTopShow(int cycle, int type, MsgPackResponse<RankingTopShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RankingFriendShow(int cycle, int type, MsgPackResponse<RankingFriendShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RankingTopRewardShow(int cycle, int type, MsgPackResponse<RankingTopRewardShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RankingScoreRewardShow(int cycle, int type, MsgPackResponse<RankingScoreRewardShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RankingPartyInfoShow(long targetID, int factor, MsgPackResponse<RankingPartyInfoShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void RespireSummary(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void RespireInfo(long target, MsgPackResponse<RespireInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void RespireFusion(long target, long[] feeds, MsgPackResponse<RespireResultResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void SalonInfo(MsgPackResponse<SalonInfoResponse> callback)
	{
		bool hasChosen = PlayerPrefs.HasKey(GameDefine.sKEY_FIRST_GEN_CHOOSED);
		int savedGen = hasChosen ? PlayerPrefs.GetInt("OFFLINE_PLAYER_GEN", 2) : 0;
		SalonInfoResponse res = new SalonInfoResponse
		{
			API = new SalonInfo
			{
				MAKE = new AppearanceInfo
				{
					NAME = PlayerPrefs.GetString(GameDefine.sKEY_USERNAME, string.Empty),
					GEN = savedGen,
					HAI = 1,
					HAI_C = 1,
					SKI = 1,
					FAC = 1,
					EYE = 1
				},
				PARTS = new SalonInfo.AppearanceDatabase
				{
					GEN = new int[2] { 1, 2 },
					HAI = new int[1] { 1 },
					HAI_C = new int[1] { 1 },
					SKI = new int[1] { 1 },
					FAC = new int[1] { 1 },
					EYE = new int[1] { 1 }
				}
			}
		};
		DeliverMsgPack(callback, res);
	}

	public static void SalonChoose(int characterID, AppearanceInfo appearance, MsgPackResponse<SalonChooseResponse> callback)
	{
		if (appearance != null)
		{
			if (!string.IsNullOrEmpty(appearance.NAME))
			{
				PlayerPrefs.SetString(GameDefine.sKEY_USERNAME, appearance.NAME);
			}
			if (appearance.GEN > 0)
			{
				PlayerPrefs.SetInt("OFFLINE_PLAYER_GEN", appearance.GEN);
			}
			PlayerPrefs.SetInt(GameDefine.sKEY_FIRST_GEN_CHOOSED, 1);
			PlayerPrefs.Save();
		}
		SalonChooseResponse res = new SalonChooseResponse
		{
			API = new SalonChoose
			{
				CH = new CharaDetail()
			}
		};
		DeliverMsgPack(callback, res);
	}

	public static void ShopInfo(MsgPackResponse<ShopInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ShopComInfo(MsgPackResponse<ShopComInfoResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ShopComShow(int id, MsgPackResponse<ShopComShowResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ShopComSummary(List<int> shopDFList, MsgPackResponse<ShopComSummaryResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ShopComBuy(int id, int sellID, MsgPackResponse<BuyResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ExpandStrageStatus(bool ruck, MsgPackResponse<StrageShowResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ExpandStrage(bool ruck, MsgPackResponse<InventoryEnlargeResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void ServerInfo(MsgPackResponse<ServerInfoResponse> callback)
	{
		ServerInfoResponse res = new ServerInfoResponse
		{
			API = new TitleServerInfo
			{
				SFG = 0,
				URL = new TitleServerInfo.UrlInfo
				{
					API = "http://localhost/"
				}
			}
		};
		DeliverMsgPack(callback, res);
	}

	public static void ServerStatus(MsgPackResponse<ServerStatusResponse> callback)
	{
		ServerStatusResponse res = new ServerStatusResponse
		{
			API = new ServerStatusResponse.Status
			{
				URL = new ServerStatusResponse.Status.UrlInfo
				{
					API = "http://localhost/",
					WEB = "http://localhost/",
					ASS = "http://localhost/"
				}
			}
		};
		DeliverMsgPack(callback, res);
	}

	public static void UserCreate(string userName, eRaceKind gender, MsgPackResponse<TitleUserCreateResponse> callback)
	{
		long uid = GetLocalUserId();
		PlayerPrefs.SetString(GameDefine.sKEY_USERID, uid.ToString());
		if (!string.IsNullOrEmpty(userName))
		{
			PlayerPrefs.SetString(GameDefine.sKEY_USERNAME, userName);
		}
		string guid = PlayerPrefs.GetString(GameDefine.sKEY_CUSTOMERID, string.Empty);
		if (string.IsNullOrEmpty(guid))
		{
			guid = Guid.NewGuid().ToString("N");
			PlayerPrefs.SetString(GameDefine.sKEY_CUSTOMERID, guid);
		}
		PlayerPrefs.Save();

		TitleUserCreateResponse res = new TitleUserCreateResponse
		{
			API = new CreateUser
			{
				USER = new CreateUser.UserInfo
				{
					ID = uid,
					CD = uid.ToString(),
					GUID = guid
				}
			}
		};
		DeliverMsgPack(callback, res);
	}

	public static void Login(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void Logout(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void UserDelete(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void GetUserMapping(string sno, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void SaveUserMapping(string sno, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void ForceMapping(string sno, long userid, Response callback)
	{
		DeliverCommon(callback);
	}

	public static void OauthUser(Response callback)
	{
		ResponseDataCommon res = new ResponseDataCommon();
		FillCommon(res);
		DeliverCommon(callback, res);
	}

	public static void CoopUser(MsgPackResponse<TitleUserCreateResponse> callback)
	{
		UserCreate(GetLocalUserName(), eRaceKind.Human_Female, callback);
	}

	public static void ResearchCoopUser(MsgPackResponse<TitleUserCreateResponse> callback)
	{
		UserCreate(GetLocalUserName(), eRaceKind.Human_Female, callback);
	}

	public static void CancelCoopUser(Response callback)
	{
		DeliverCommon(callback);
	}

	public static void ExchangeUser(MsgPackResponse<TitleUserCreateResponse> callback)
	{
		UserCreate(GetLocalUserName(), eRaceKind.Human_Female, callback);
	}

	public static void TutorialSummary(Response callback)
	{
		ResponseDataCommon res = new ResponseDataCommon();
		FillCommon(res);
		res.TUTO = new TutorialStatusList
		{
			LIST = new TutorialStatus[0]
		};
		DeliverCommon(callback, res);
	}

	public static void TutorialFinish(int id, MsgPackResponse<TutorialFinishResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	public static void VillageInfo(int townId, MsgPackResponse<VillageInfoResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
		DeliverMsgPack(callback);
	}

	public static void VillageHeal(int townId, MsgPackResponse<VillageHealResponse> callback)
	{
		DeliverMsgPack(callback);
	}

	private void Awake()
	{
		s_sInstance = this;
		if (m_vRequestQueue == null)
		{
			m_vRequestQueue = new List<APIBase>();
		}
		if (base.transform.parent == null)
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
	}

	[DebuggerHidden]
	private IEnumerator Exec()
	{
		yield break;
	}

	private void ConnectFinish()
	{
	}

	private void RemoveRequest()
	{
		if (m_vRequestQueue != null && m_vRequestQueue.Count > 0)
		{
			m_vRequestQueue.RemoveAt(0);
		}
	}

	private void _Cancel()
	{
		if (m_vRequestQueue != null)
		{
			m_vRequestQueue.Clear();
		}
		m_iOfflinePending = 0;
	}

	public void Add(APIBase api)
	{
		if (api != null)
		{
			ImmediateExec(api);
		}
	}

	public void ImmediateExec(APIBase api)
	{
		if (api != null)
		{
			StartCoroutine(ImmediateExecOffline(api));
		}
	}

	private IEnumerator ImmediateExecOffline(APIBase api)
	{
		m_iOfflinePending++;
		yield return null;
		m_iOfflinePending = Mathf.Max(0, m_iOfflinePending - 1);
		api.PostProcess();
		api.Notify();
	}

	private void Request()
	{
	}

	protected bool IsLogined()
	{
		return true;
	}

	public static void Cancel()
	{
		if (s_sInstance != null)
		{
			s_sInstance._Cancel();
		}
	}

	public static void Regist(APIBase api)
	{
		Instance.Add(api);
	}

	public static bool IsExec()
	{
		return s_sInstance != null && s_sInstance.RequestNum > 0;
	}
}
