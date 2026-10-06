using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Network;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
	private bool m_bIgnoreSession;

	private List<APIBase> m_vRequestQueue;

	private NetworkRequest m_sReq;

	private static bool s_bInit;

	private static NetworkManager s_sInstance;

	public static NetworkManager Instance
	{
		get
		{
			return null;
		}
	}

	public int RequestNum
	{
		get
		{
			return 0;
		}
	}

	public static void AlchemyRecipeList(MsgPackResponse<AlchemyInfoResponse> callback)
	{
	}

	public static void AlchemyRecipeInfo(int recipeID, Response callback)
	{
	}

	public static void AlchemyConfirm(int recipeID, long[] ingredients, long free, MsgPackResponse<AlchemyConfirmResponse> callback)
	{
	}

	public static void AlchemyAlter(int recipeID, long[] ingredients, long free, MsgPackResponse<AlchemyAlterResponse> callback)
	{
	}

	public static void AlchemyPickTrait(Response callback)
	{
	}

	public static void BannerInfo(BannerCategory category, MsgPackResponse<BannerInfoResponse> callback)
	{
	}

	public static void WealthInfo(Response callback)
	{
	}

	public static void DailyMissionInfo(MsgPackResponse<MissionDailyResponse> callback)
	{
	}

	public static void TitleMissionInfo(MsgPackResponse<MissionTitleResponse> callback)
	{
	}

	public static void SendChat(string message, Response callback)
	{
	}

	public static void InventoryHold(long id, Response callback)
	{
	}

	public static void InventoryUnhold(long id, Response callback)
	{
	}

	public static void Initialize()
	{
	}

	public static void CheckNgWord(string comment, Response callback)
	{
	}

	public static void BattleStart(int battleID, MsgPackResponse<BattleStartResponse> callback)
	{
	}

	public static void BattleJoin(long user, MsgPackResponse<BattleJoinResponse> callback)
	{
	}

	public static void BattleFinish(int battleID, long[] useItem, int[] killEnemy, int skillCount, int skillChainCount, List<APIBattleFinish.Request.UseSkill> useSkillList, int[] score, int countBlazeArts, MsgPackResponse<BattleFinishResponse> callback)
	{
	}

	public static void BattleEscape(int battleID, long[] useItem, int countBlazeArts, Response callback)
	{
	}

	public static void BattleRevive(int ItemID, Response callback)
	{
	}

	public static void BattleAnnihilated(int battleID, long[] useItem, int countBlazeArts, Response callback)
	{
	}

	public static void DungeonInfo(int dangeonID, MsgPackResponse<DungeonInfoResponse> callback)
	{
	}

	public static void DungeonCreate(int dangeonID, Response callback)
	{
	}

	public static void DungeonFloorInfo(int dangeonID, int floor, MsgPackResponse<DungeonFloorInfoResponse> callback)
	{
	}

	public static void DungeonFloorCreate(int dangeonID, int floor, APIExploreDungeonFloorCreate.Request.PosInfo posInfo, Response callback)
	{
	}

	public static void DungeonFloorEnter(int dangeonID, int floor, MsgPackResponse<DungeonFieldDataResponse> callback)
	{
	}

	public static void DungeonFloorReload(int dangeonID, int floor, MsgPackResponse<DungeonFieldDataResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void DungeonFloorStamp(int dangeonID, int floor, Response callback)
	{
	}

	public static void DungeonFloorLeave(int dangeonID, int floor, MsgPackResponse<FieldDataResponse> callback)
	{
	}

	public static void DungeonLeave(int dangeonID, Response callback)
	{
	}

	public static void FieldEnter(int fieldID, MsgPackResponse<FieldEnterResponse> callback)
	{
	}

	public static void FieldEnter2(long roomID, int roomIndex, MsgPackResponse<FieldEnter2Response> callback)
	{
	}

	[DebuggerHidden]
	public static IEnumerator TutorialFieldEnter2(MsgPackResponse<FieldEnter2Response> callback)
	{
		return null;
	}

	public static void SpotPick(int spotID, long item, MsgPackResponse<APISpotPickResponse> callback)
	{
	}

	public static void GimmickActivate(int no, long useItemID, MsgPackResponse<GimmickActivateResponse> callback)
	{
	}

	public static void ItemHeal(long[] itemIdList, Response callback)
	{
	}

	public static void ItemCure(long[] itemIdList, Response callback)
	{
	}

	public static void ItemSprinkle(long[] itemIdList, MsgPackResponse<ItemSprinkleResponse> callback)
	{
	}

	public static void FieldGateInfo(int gateID, MsgPackResponse<GateInfoResponse> callback)
	{
	}

	public static void GateStamp(int gateID, Response callback)
	{
	}

	public static void GateJump(int gateID, Response callback)
	{
	}

	public static void FieldReload(long roomId, MsgPackResponse<FieldReloadResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RoomCreate(string roomName, int fieldID, MsgPackResponse<ExploreRoomCreateResponse> callback)
	{
	}

	public static void RoomInfo(MsgPackResponse<ExploreRoomInfoResponse> callback)
	{
	}

	public static void RoomLeave(Response callback)
	{
	}

	public static void FairyItem(int df, MsgPackResponse<FairyItemResponse> callback)
	{
	}

	public static void FairyPick(int ticket, int area, int dungeon, MsgPackResponse<FairyPickResponse> callback)
	{
	}

	public static void FairyArea(MsgPackResponse<FairyAreaResponse> callback)
	{
	}

	public static void ForgeSummary(Response callback)
	{
	}

	public static void ForgeInfo(long target, MsgPackResponse<ForgeInfoResponse> callback)
	{
	}

	public static void ForgeEnforce(long target, long[] feeds, MsgPackResponse<ForgeResultResponse> callback)
	{
	}

	public static void ForgeQualitySummary(Response callback)
	{
	}

	public static void ForgeQualityInfoInfo(long target, MsgPackResponse<ForgeQualityInfoResponse> callback)
	{
	}

	public static void ForgeQualityEnforce(long target, MsgPackResponse<ForgeResultResponse> callback)
	{
	}

	public static void FriendList(MsgPackResponse<FriendInfoResponse> callback)
	{
	}

	public static void FriendSearch(long targetID, MsgPackResponse<FriendSearchResponse> callback)
	{
	}

	public static void FriendRequest(long targetID, Response callback)
	{
	}

	public static void FriendRequest(long[] targets, Response callback)
	{
	}

	public static void FriendAccept(long targetID, Response callback)
	{
	}

	public static void FriendAccept(long[] targets, Response callback)
	{
	}

	public static void FriendDelete(long targetID, Response callback)
	{
	}

	public static void FriendDelete(long[] targets, Response callback)
	{
	}

	public static void FriendMute(long targetID, Response callback)
	{
	}

	public static void FriendMute(long[] targets, Response callback)
	{
	}

	public static void FriendMuteCancel(long targetID, Response callback)
	{
	}

	public static void FriendMuteCancel(long[] targets, Response callback)
	{
	}

	public static void FriendProfile(long target, MsgPackResponse<FriendProfileResponse> callback)
	{
	}

	public static void OtherProfile(long target, MsgPackResponse<FriendProfileResponse> callback)
	{
	}

	public static void GachaInfo(MsgPackResponse<GachaInfoResponse> callback)
	{
	}

	public static void GachaShow(int id, MsgPackResponse<ShopGachaShowResponse> callback)
	{
	}

	public static void GachaDisassemble(int df, List<APIHomeShopGachaDisassemble.Request.LotInfo> lot, MsgPackResponse<ShopGachaDisassembleResponse> callback)
	{
	}

	public static void GachaLot(int id, int sellid, MsgPackResponse<ShopGachaLotResponse> callback)
	{
	}

	public static void GrowInfo(Response callback)
	{
	}

	public static void GrowCharaShow(int chara, MsgPackResponse<GrowCharaShowResponse> callback)
	{
	}

	public static void ExceedInfo(int chara, MsgPackResponse<ExceedInfoResponse> callback)
	{
	}

	public static void ExceedApply(int chara, MsgPackResponse<ExceedResultResponse> callback)
	{
	}

	public static void FoodInfo(int chara, MsgPackResponse<FoodInfoResponse> callback)
	{
	}

	public static void FoodApply(int chara, long[] foods, MsgPackResponse<FoodResultResponse> callback)
	{
	}

	public static void PotionInfo(int chara, MsgPackResponse<GrowPotionResponse> callback)
	{
	}

	public static void BlazeMaterialInfo(int chara, MsgPackResponse<GrowBlazeArtsMateriaResponse> callback)
	{
	}

	public static void PotionApply(int chara, long[] potion, MsgPackResponse<PotionResultResponse> callback)
	{
	}

	public static void BlazeMateriaApply(int chara, long[] bMat, int ba, MsgPackResponse<BlazeMateriaResultResponse> callback)
	{
	}

	public static void HomeEnter(MsgPackResponse<HomeEnterResponse> callback)
	{
	}

	public static void PresentSummary(Response callback)
	{
	}

	public static void PresentReceive(long[] list, MsgPackResponse<PresentReceiveResponse> callback)
	{
	}

	public static void HomeGateInfo(MsgPackResponse<GateInfoResponse> callback)
	{
	}

	public static void AuthTicket(Response callback)
	{
	}

	public static void HuntMemberChoose(int huntID, int formID, List<FormationInfo> party, MsgPackResponse<HuntMemberChooseResponse> callback)
	{
	}

	public static void HuntRecommend(int huntID, int formID, List<FormationInfo> party, MsgPackResponse<HuntRecommendResponse> callback)
	{
	}

	public static void HuntResult(int formID, eHuntReturnType returnType, int wealthDF, MsgPackResponse<HuntResultResponse> callback)
	{
	}

	public static void HuntStart(int huntID, int formID, eHuntReturnType returnType, int wealthDF, int leaderID, int clearSec, MsgPackResponse<HuntStartResponse> callback)
	{
	}

	public static void HuntStatus(MsgPackResponse<HuntStatusResponse> callback)
	{
	}

	public static void HuntSummary(MsgPackResponse<HuntSummaryResponse> callback)
	{
	}

	public static void InventorySummary(Response callback)
	{
	}

	public static void InventorySummary(int[] categoryList, Response callback)
	{
	}

	public static void InventoryDrop(long[] inventoryID, Response callback)
	{
	}

	public static void InventoryDispose(long[] inventoryID, Response callback)
	{
	}

	public static void InventoryRestore(long[] list, MsgPackResponse<RestoreResponse> callback)
	{
	}

	public static void InventoryReposit(long[] inventoryID, Response callback)
	{
	}

	public static void InventoryBring(long[] inventoryID, Response callback)
	{
	}

	public static void OverwriteSummary(Response callback)
	{
	}

	public static void OverwritePickTrait(long target, MsgPackResponse<PickTraitResponse> callback)
	{
	}

	public static void OverwriteExecute(long targetID, long feedID, MsgPackResponse<OverwriteExecuteResponse> callback)
	{
	}

	public static void PartyInfo(Response callback)
	{
	}

	public static void PartyMemberInfo(Response callback)
	{
	}

	public static void PartyMemberDetail(int charaID, MsgPackResponse<PartyMemberShowResponse> callback)
	{
	}

	public static void PartyMemberChoose(FormationInfo[] form, Response callback)
	{
	}

	public static void PartyEquipInfo(int charaID, int category, Response callback)
	{
	}

	public static void PartyEquipChoose(int charaID, EquipData equip, Response callback)
	{
	}

	public static void PartyVisualEquipChoose(int charaID, EquipData equip, int[] disp, Response callback)
	{
	}

	public static void PartyEquipRecommend(int charaID, int equipKind, int statusPriority, MsgPackResponse<EquipRecommendResponse> callback)
	{
	}

	public static void PartyEquipSubInfo(int charaID, MsgPackResponse<SubEquipInfoResponse> callback)
	{
	}

	public static void PartyEquipSubChoose(int charaID, SubEquip[] sub, Response callback)
	{
	}

	public static void PartyItemInfo(MsgPackResponse<PartyItemResponse> callback)
	{
	}

	public static void PartyItemChoose(PartyItemInfo item, MsgPackResponse<PartyItemChooseResponse> callback)
	{
	}

	public static void PartyFavoriteInfo(int charaDF, MsgPackResponse<PartyEquipFavoListResponse> callback)
	{
	}

	public static void PartyFavoriteRegister(int charaDF, int no, string name, EquipData equ, List<SubEquip> sub, int kind, MsgPackResponse<PartyEquipFavoRegisterResponse> callback)
	{
	}

	public static void PartyFavoriteErase(int charaDF, int no, int kind, MsgPackResponse<PartyEquipFavoEraseResponse> callback)
	{
	}

	public static void ProductInfo(MsgPackResponse<ProductInfoResponse> callback)
	{
	}

	public static void PurchaseProduct(string productId, string receipt_json, string signature, MsgPackResponse<ProductPurchaseResponse> callback)
	{
	}

	public static void RegisterAge(int age, bool never_again, Response callback)
	{
	}

	public static void GetMyProfile(MsgPackResponse<ProfileInfoResponse> callback)
	{
	}

	public static void SetProfileTitle(DegreeInfo degree, Response callback)
	{
	}

	public static void SetProfileComment(string comment, Response callback)
	{
	}

	public static void UpdateTakeoverCode(MsgPackResponse<TakeoverCodeResponse> callback)
	{
	}

	public static void ExecTakeover(long userId, string takeoverCode, string sno, Response callback)
	{
	}

	public static void QuestSummary(MsgPackResponse<QuestSummaryResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestShow(int questID, MsgPackResponse<QuestShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestReceive(int questID, MsgPackResponse<QuestStartResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestDeparture(int questID, Response callback)
	{
	}

	public static void QuestDeliver(int questID, long[] inventoryList, MsgPackResponse<QuestDeliverResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestGiveup(int questID, MsgPackResponse<QuestGiveupResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestFill(Response callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestTalk(int DF, MsgPackResponse<QuestTalkResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void QuestAchieve(int DF, Response callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void ExtraQuestClear(int DF, int KeyCharaNum, Response callBack = null)
	{
	}

	public static void RankingSummary(MsgPackResponse<RankingSummaryResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RankingTopShow(int cycle, int type, MsgPackResponse<RankingTopShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RankingFriendShow(int cycle, int type, MsgPackResponse<RankingFriendShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RankingTopRewardShow(int cycle, int type, MsgPackResponse<RankingTopRewardShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RankingScoreRewardShow(int cycle, int type, MsgPackResponse<RankingScoreRewardShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RankingPartyInfoShow(long targetID, int factor, MsgPackResponse<RankingPartyInfoShowResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void RespireSummary(Response callback)
	{
	}

	public static void RespireInfo(long target, MsgPackResponse<RespireInfoResponse> callback)
	{
	}

	public static void RespireFusion(long target, long[] feeds, MsgPackResponse<RespireResultResponse> callback)
	{
	}

	public static void SalonInfo(MsgPackResponse<SalonInfoResponse> callback)
	{
	}

	public static void SalonChoose(int characterID, AppearanceInfo appearance, MsgPackResponse<SalonChooseResponse> callback)
	{
	}

	public static void ShopInfo(MsgPackResponse<ShopInfoResponse> callback)
	{
	}

	public static void ShopComInfo(MsgPackResponse<ShopComInfoResponse> callback)
	{
	}

	public static void ShopComShow(int id, MsgPackResponse<ShopComShowResponse> callback)
	{
	}

	public static void ShopComSummary(List<int> shopDFList, MsgPackResponse<ShopComSummaryResponse> callback)
	{
	}

	public static void ShopComBuy(int id, int sellID, MsgPackResponse<BuyResponse> callback)
	{
	}

	public static void ExpandStrageStatus(bool ruck, MsgPackResponse<StrageShowResponse> callback)
	{
	}

	public static void ExpandStrage(bool ruck, MsgPackResponse<InventoryEnlargeResponse> callback)
	{
	}

	public static void ServerInfo(MsgPackResponse<ServerInfoResponse> callback)
	{
	}

	public static void ServerStatus(MsgPackResponse<ServerStatusResponse> callback)
	{
	}

	public static void UserCreate(string userName, eRaceKind gender, MsgPackResponse<TitleUserCreateResponse> callback)
	{
	}

	public static void Login(Response callback)
	{
	}

	public static void Logout(Response callback)
	{
	}

	public static void UserDelete(Response callback)
	{
	}

	public static void GetUserMapping(string sno, Response callback)
	{
	}

	public static void SaveUserMapping(string sno, Response callback)
	{
	}

	public static void ForceMapping(string sno, long userid, Response callback)
	{
	}

	public static void OauthUser(Response callback)
	{
	}

	public static void CoopUser(MsgPackResponse<TitleUserCreateResponse> callback)
	{
	}

	public static void ResearchCoopUser(MsgPackResponse<TitleUserCreateResponse> callback)
	{
	}

	public static void CancelCoopUser(Response callback)
	{
	}

	public static void ExchangeUser(MsgPackResponse<TitleUserCreateResponse> callback)
	{
	}

	public static void TutorialSummary(Response callback)
	{
	}

	public static void TutorialFinish(int id, MsgPackResponse<TutorialFinishResponse> callback)
	{
	}

	public static void VillageInfo(int townId, MsgPackResponse<VillageInfoResponse> callback, bool autoDispPop = true, bool autoDispAcheive = true)
	{
	}

	public static void VillageHeal(int townId, MsgPackResponse<VillageHealResponse> callback)
	{
	}

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator Exec()
	{
		return null;
	}

	private void ConnectFinish()
	{
	}

	private void RemoveRequest()
	{
	}

	private void _Cancel()
	{
	}

	public void Add(APIBase api)
	{
	}

	public void ImmediateExec(APIBase api)
	{
	}

	private void Request()
	{
	}

	protected bool IsLogined()
	{
		return false;
	}

	public static void Cancel()
	{
	}

	public static void Regist(APIBase api)
	{
	}

	public static bool IsExec()
	{
		return false;
	}
}
