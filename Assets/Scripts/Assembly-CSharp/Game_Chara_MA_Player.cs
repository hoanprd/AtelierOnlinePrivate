using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CharaMotion;
using UnityEngine;
using UnityEngine.AI;

public class Game_Chara_MA_Player : Game_Chara_MA_Base
{
	private enum eMainStep
	{
		Wait = 0,
		Move = 1,
		Action = 2
	}

	public enum eActionKind
	{
		None = 0,
		PickUp = 1,
		Bomb = 2,
		NPCTalk = 3,
		Surprise = 4,
		CheckEnemy = 5,
		Portal = 6,
		Warp = 7,
		Ship = 8,
		PortalED = 9,
		Check = 10,
		Climb = 11,
		Boatman = 12,
		NPCQuestion = 13,
		NPCQuestTarget = 14,
		Carriage = 15,
		DungeonEnter = 16,
		DungeonMove = 17,
		DungeonWayPoint = 18,
		Tide = 19,
		QuestArea = 20,
		RideWind = 21,
		Encount = 22,
		ForceWalk = 23
	}

	public enum eGimmickSelect
	{
		All = 0,
		OnlyImmediate = 1,
		OnlyAction = 2
	}

	private class SubBoatMan : SubNPCTalkBase
	{
		private enum eSubStep
		{
			First = 0,
			Approach = 1,
			Rotation_Init = 2,
			Rotation_Wait = 3,
			Talk_Init = 4,
			Talk_Wait = 5,
			Inventory_Init = 6,
			Inventory_Wait = 7,
			Return_Init = 8,
			Return = 9,
			FadeOut1_Init = 10,
			FadeOut1_Wait = 11,
			Prepare1 = 12,
			FadeIn1_Init = 13,
			FadeIn1_Wait = 14,
			Move1 = 15,
			AreaChange_Wait = 16,
			Move_AreaChange_Init = 17,
			AreaChangeFade_Wait = 18,
			Move_AreaChange_Wait = 19,
			Move2 = 20,
			FadeOut2_Init = 21,
			FadeOut2_Wait = 22,
			Prepare2 = 23,
			FadeIn2_Init = 24,
			FadeIn2_Wait = 25,
			Last = 26,
			End = 27
		}

		private static Vector3 s_v3NPCDefaultRot;

		private static Vector3 s_v3Forward;

		private static eSubStep s_eSubStep;

		private static int s_iPrevAreaId;

		private Game_Gimmick_BoatMan m_scrBoat
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		public static void ResetStatus()
		{
		}
	}

	private class SubCarriage : SubBase
	{
		private enum eSubStep_Carriage
		{
			Rotation = 0,
			Surprise = 1,
			Surprise_Wait = 2,
			Last = 3,
			End = 4
		}

		private eSubStep_Carriage m_eSubStep;

		private float m_fWaitSec_Surprise1;

		public override void Update()
		{
		}
	}

	private class SubCheck : SubBase
	{
		private enum eSubStep_Check
		{
			Check = 0,
			Dungeon_Init = 1,
			Dungeon_Wait = 2,
			Taru_Init = 3,
			Taru_Wait = 4,
			Last = 5,
			End = 6
		}

		private eSubStep_Check m_eSubStep;

		private Game_Gimmick_Check m_scrCheck
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}
	}

	private class SubCheckEnemy : SubBase
	{
		private enum eSubStep_Check
		{
			First = 0,
			Check = 1,
			AppearEnemy = 2,
			Last = 3,
			End = 4
		}

		private eSubStep_Check m_eSubStep;

		private Game_Gimmick_CheckEnemy m_scrCheck
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}
	}

	private class SubClimb : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			Approach = 1,
			Rotate_Init = 2,
			Rotate_Wait = 3,
			Climbing = 4,
			Falling = 5,
			ApproachGoal_Init = 6,
			ApproachGoal_Wait = 7,
			Last = 8,
			End = 9
		}

		private static readonly float sr_fClimbSpeed;

		private static readonly float sr_fFallSpeed;

		private static readonly float sr_fRotateTime;

		private eSubStep m_eSubStep;

		private GrowManager m_scrGrowMng;

		private Vector3 m_v3Goal;

		private Vector3 m_v3RotGoal;

		private float m_fAngleFirst;

		private float m_fAngleGoal;

		private Sound_Loop m_scrClimbSE;

		private Game_Gimmick_GrowClimb m_scrClimb
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void CalcOptimizedAngle(ref float fFirst, ref float fGoal)
		{
		}

		private Vector3 GetRotatePos(float fAngle)
		{
			return default(Vector3);
		}
	}

	private class SubDungeonEnter : SubBase
	{
		private enum eSubStep
		{
			API_Init = 0,
			API_Wait = 1,
			SelectFloor_Init = 2,
			SelectFloor_Wait = 3,
			Enter = 4,
			Last = 5,
			End = 6
		}

		private eSubStep m_eSubStep;

		private bool m_bFloorDialogEnd;

		private DungeonFloorMoveDialog.eButton m_eFloorDialogResult;

		private int m_iSelectFloor;

		private Game_Gimmick_DungeonEnter m_scrEnter
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void OnAPI_DungeonInfo(DungeonInfoResponse clsRes)
		{
		}

		private void OnFloorDialogEnd(DungeonFloorMoveDialog.eButton eResult, int iFloor)
		{
		}

		private void CheckForExDungeon()
		{
		}
	}

	private class SubDungeonFloorMove : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			Next_Init = 1,
			Next_Wait = 2,
			Clear_Init = 3,
			Clear_Wait = 4,
			Last = 5,
			End = 6
		}

		private eSubStep m_eSubStep;

		private DungeonFloorMoveDialog.eButton m_eFloorResult;

		private int m_iFloorResult;

		private bool m_bFloorDialogEnd;

		private Game_MA_DungeonFloorMoveColl m_scrFloorMove;

		public override void Update()
		{
		}

		private void OnFloorDialog(DungeonFloorMoveDialog.eButton eResult, int iOtherFloor)
		{
		}
	}

	private class SubDungeonWayPoint : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			InfoAPI_Init = 1,
			InfoAPI_Wait = 2,
			UnlockAPI_Init = 3,
			UnlockAPI_Wait = 4,
			Check = 5,
			Unlock_Init = 6,
			Unlock_Wait = 7,
			Exit_Init = 8,
			Exit_Wait = 9,
			EX_Exit_Init = 10,
			EX_Exit_Wait = 11,
			Last = 12,
			End = 13
		}

		private eSubStep m_eSubStep;

		private int m_iSelectFloor;

		private int m_iNeedEther;

		private Game_Gimmick_DungeonWayPoint m_scrWayPoint
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void OnAPI_Info(DungeonFloorInfoResponse clsRes)
		{
		}

		private void OnAPI_Stamp(ResponseDataCommon clsRes)
		{
		}

		private bool CheckExtraDungeon()
		{
			return false;
		}
	}

	private class SubEncount : SubBase
	{
	}

	private class SubForceWalk : SubBase
	{
		private enum eSubStep_FWalk
		{
			First = 0,
			Talk_Init = 1,
			Talk_Wait = 2,
			Rotation = 3,
			Walk = 4,
			Last = 5,
			End = 6
		}

		private eSubStep_FWalk m_eSubStep;

		private float m_fForceWalkWaitTime;

		private float m_fForceWalkSpeed;

		private Vector3 m_v3ForceWalkPos_Log;

		private Vector3 m_v3ForceWalkTo
		{
			get
			{
				return default(Vector3);
			}
		}

		private List<string> m_strTalkNameList
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}
	}

	private class SubNPCQuestTarget : SubNPCTalkBase
	{
		private enum eSubStep_NPCQuestTarget
		{
			First = 0,
			Approach = 1,
			Rotation_Init = 2,
			Rotation_Wait = 3,
			SelectQuest_Init = 4,
			SelectQuest_Wait = 5,
			Adventure_Init = 6,
			Adventure_Wait = 7,
			Network_Init = 8,
			Network_Wait = 9,
			QuestShow_Init = 10,
			QuestShow_Wait = 11,
			Delivery_Init = 12,
			Delivery_Wait = 13,
			QuestDelivery_Init = 14,
			QuestDelivery_Wait = 15,
			DispAcheive_Init = 16,
			DispAcheive_Wait = 17,
			QuestSummary_Init = 18,
			QuestSummary_Wait = 19,
			FieldReload_Init = 20,
			FieldReload_Wait = 21,
			FadeO_Init = 22,
			FadeO_Wait = 23,
			UpdateSpawner = 24,
			UpdateQuestObject_Init = 25,
			UpdateQuestObject_Wait = 26,
			FadeI_Init = 27,
			FadeI_Wait = 28,
			Return_Init = 29,
			Return_Wait = 30,
			Last = 31,
			End = 32
		}

		private static readonly float s_fRotTime;

		private float s_fFromRotation;

		private float s_fGmkFromRotation;

		private eSubStep_NPCQuestTarget m_eSubStep;

		private QuestDetail m_clsDetail;

		private MasterQuestInfo m_clsMaster;

		private EButtonKind m_eSelectResult;

		private bool m_bEndSelect;

		private InventoryList m_clsDeliInv;

		private QuestDeliveryManager m_scrDelivery;

		private bool m_bEndDelivery;

		private long[] m_lItemIdList;

		private FieldData m_clsFieldData;

		private QuestSelectWindow m_scrQuestSelect;

		private Game_Gimmick_NPCQuestTarget m_scrNPC
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		protected override void Finish()
		{
		}

		private void OnEndSelect(EButtonKind eResult, int iQuestDF)
		{
		}

		private void OnAPITalk(QuestTalkResponse clsRes)
		{
		}

		public void OnSelectDeliveryItem(bool bExecute, List<InventoryInfo> clsSelectList)
		{
		}

		private void OnAPIQuestShow(QuestShowResponse clsRes)
		{
		}

		private void OnAPIDelivery(QuestDeliverResponse clsRes)
		{
		}

		private void OnAPISummary(QuestSummaryResponse clsRes)
		{
		}

		private void OnAPIDungeonFloorReload(DungeonFieldDataResponse clsRes)
		{
		}

		private void OnAPIFieldReload(FieldReloadResponse clsRes)
		{
		}
	}

	private class SubPickup : SubBase
	{
		private enum eSubStep
		{
			MakeSure_Init = 0,
			MakeSure_Wait = 1,
			API_Init = 2,
			API_Wait = 3,
			Start = 4,
			First = 5,
			Pick_Wait1 = 6,
			Pick_Init = 7,
			Pick_Wait2 = 8,
			Pick_Wait3 = 9,
			Rare_Init = 10,
			Rare_Wait = 11,
			OverCheck_Init = 12,
			OverCheck_Wait = 13,
			DispAcheive_Init = 14,
			DispAcheive_Wait = 15,
			Last = 16,
			End = 17
		}

		private eSubStep m_eSubStep;

		private InventoryInfo[] m_clsItemArray;

		private int m_iSpotNo;

		private InventoryInfo m_clsUseItem;

		private bool m_bEndCheckDialog;

		private Game_Item_PickUp_Base m_scrPickup
		{
			get
			{
				return null;
			}
		}

		private Game_UI_ActionShortcutManager m_scrActionMng
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void First()
		{
		}

		private void Pickup_Wait1()
		{
		}

		private void Pickup_Wait2()
		{
		}

		private void OnAPI_FieldPick(APISpotPickResponse clsRes)
		{
		}

		private void OnEndCheckDialog(EButtonKind eResult)
		{
		}
	}

	private class SubPortal : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			API_GateInfo_Init = 1,
			API_GateInfo_Wait = 2,
			NotEnoughMana = 3,
			AlreadyUnlock = 4,
			AskUnlock_Init = 5,
			AskUnlock_Wait = 6,
			API_GateStamp_Init = 7,
			API_GateStamp_Wait = 8,
			Check = 9,
			UnlockPortal_Init = 10,
			UnlockPortal_Wait = 11,
			Tutorial_Init = 12,
			Tutorial_Wait = 13,
			Last = 14,
			End = 15
		}

		private eSubStep m_eSubStep;

		private int m_iNeedMana;

		private Game_Gimmick_Portal m_scrPortal
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void OnAPI_GateInfo(GateInfoResponse clsRes)
		{
		}

		private void OnAPI_GateStamp(ResponseDataCommon clsCommon)
		{
		}

		private void OnAPI_TutorialFinish(TutorialFinishResponse res)
		{
		}
	}

	private class SubPortalED : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			DungeonInfo_Init = 1,
			DungeonInfo_Wait = 2,
			GoNext_Init = 3,
			GoNext_Wait = 4,
			Exit_Init = 5,
			Exit_Wait = 6,
			Last = 7,
			End = 8
		}

		private eSubStep m_eSubStep;

		private int m_iNowDifficulty;

		private bool m_bInterval;

		private DungeonDifficulty m_clsDiffInfo;

		private DungeonFloorMoveDialog.eButton m_eFloorResult;

		private int m_iFloorResult;

		private bool m_bFloorDialogEnd;

		private Game_Gimmick_ExitDungeonPortal m_scrPortal
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void OnAPI_DungeonInfo(DungeonInfoResponse clsRes)
		{
		}

		private void OnFloorDialog(DungeonFloorMoveDialog.eButton eResult, int iOtherFloor)
		{
		}
	}

	private class SubPut : SubBase
	{
		private enum eSubStep_Put
		{
			MakeSure_Init = 0,
			MakeSure_Wait = 1,
			Resreve_Init = 2,
			Reserve_Wait = 3,
			NetWork = 4,
			First = 5,
			Wait = 6,
			Last = 7,
			End = 8
		}

		private static readonly float sr_fReserveTimeOut;

		private float m_fWaitSec_PutBomb;

		private eSubStep_Put m_eSubStep;

		private InventoryInfo m_clsUseBombInfo;

		private Game_Gimmick_UseBombBase m_scrUseBomb
		{
			get
			{
				return null;
			}
		}

		private Game_UI_ActionShortcutManager m_scrActionMng
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void OnAPIGimmickActivate(GimmickActivateResponse clsRes)
		{
		}
	}

	private class SubQuestArea : SubBase
	{
		private enum eSubStep_QuestArea
		{
			SelectQuest_Init = 0,
			SelectQuest_Wait = 1,
			LoadADV_Init = 2,
			LoadADV_Wait = 3,
			AreaArrival_Init = 4,
			AreaArrival_Wait = 5,
			Last = 6,
			End = 7
		}

		private static readonly float s_fRotTime;

		private float s_fFromRotation;

		private float s_fGmkFromRotation;

		private eSubStep_QuestArea m_eSubStep;

		private EButtonKind m_eSelectResult;

		private bool m_bEndSelect;

		private MasterQuestInfo m_clsMaster;

		private Game_Gimmick_QuestArea m_scrQuestArea
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		private void OnEndSelect(EButtonKind eResult, int iQuestDF)
		{
		}

		private void OnAPIQuestAchieve(ResponseDataCommon clsRes)
		{
		}
	}

	private class SubRideWind : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			Motion_Init = 1,
			Motion_Wait = 2,
			ToEye_SE = 3,
			ToEye = 4,
			ToDestination = 5,
			Last = 6,
			End = 7
		}

		private static readonly float st_fMotionSec;

		private static readonly float sr_fSESec;

		private static readonly float sr_fToEyeSec;

		private static readonly float sr_fToDestSec;

		private Vector3 m_v3Velocity;

		private eSubStep m_eSubStep;

		private Vector3 m_v3WindOffset;

		private Vector3 m_v3Destination;

		private Vector3 m_v3MyGravity;

		private Vector3 m_v3FloatVec;

		private Game_Gimmick_RideWind m_scrWind
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}
	}

	private class SubShip : SubBase
	{
		private enum eSubStep_Ship
		{
			First = 0,
			LeaveRoom = 1,
			LeaveRoom_Wait = 2,
			Jump = 3,
			RideOn = 4,
			Last = 5,
			End = 6
		}

		private eSubStep_Ship m_eSubStep;

		private float m_fYPosLog;

		private Game_Gimmick_Ship m_scrShip
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}
	}

	private abstract class SubBase
	{
		private bool m_bFinished;

		protected float m_fWaitSec_ToIdle;

		protected Game_Chara_MA_Player m_scrPlayer;

		protected Game_Gimmick_Base m_scrGimmick;

		protected float m_fWaitSec_Now;

		protected bool m_bAPIEnd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected bool m_bAPIError
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected EButtonKind m_eDialogResult
		{
			get
			{
				return EButtonKind.eNORMAL;
			}
		}

		protected bool m_bDialogEnd
		{
			get
			{
				return false;
			}
		}

		protected virtual void InitSub()
		{
		}

		protected float GetDeltaTime()
		{
			return 0f;
		}

		protected void CreateYNDialog(string strContent, string strCancel = null, string strDecide = null)
		{
		}

		protected void CreateDialog(string strSubject, string strContent)
		{
		}

		protected void CreateDialog(string strContent)
		{
		}

		protected void CreateHoldItemDialog(string strContent)
		{
		}

		protected virtual void Finish()
		{
		}

		public virtual void Init(Game_Chara_MA_Player scrPlayer, Game_Gimmick_Base scrGimmick)
		{
		}

		public virtual void Update()
		{
		}

		public virtual void FixedUpdate()
		{
		}

		public virtual bool IsFinish()
		{
			return false;
		}
	}

	private class SubSurprise : SubBase
	{
		private enum eSubStep_Surprise
		{
			First = 0,
			Rotation = 1,
			Surprise = 2,
			Surprise_Wait = 3,
			Last = 4,
			End = 5
		}

		private eSubStep_Surprise m_eSubStep;

		private float m_fWaitSec_Surprise1;

		public override void Update()
		{
		}
	}

	private class SubNPCQuestOrder : SubNPCTalkBase
	{
		private enum eSubStep_NPCQuestion
		{
			NetWork = 0,
			First = 1,
			Approach = 2,
			Rotation_Init = 3,
			Rotation_Wait = 4,
			Adventure_Init = 5,
			Adventure_Wait = 6,
			Order = 7,
			OrderWait = 8,
			Tutorial_Init = 9,
			Tutorial_Wait = 10,
			Return_Init = 11,
			Return_Wait = 12,
			Last = 13,
			End = 14
		}

		private static readonly float s_fRotTime;

		private float s_fFromRotation;

		private float s_fGmkFromRotation;

		private eSubStep_NPCQuestion m_eSubStep;

		private QuestDetail m_clsDetail;

		private InventoryList m_clsInventory;

		private QuestWindow m_clsQuestWindow;

		private Game_Gimmick_NPCQuestion m_scrNPC
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}

		protected override void Finish()
		{
		}

		private void OnAPIShow(QuestShowResponse res)
		{
		}
	}

	private class SubNPCTalkBase : SubBase
	{
		private static readonly float s_fRotTime;

		private static readonly float s_fMoveTime;

		private float m_fElapsedTime;

		private float m_fGmkFromRotation;

		protected virtual void First(Transform trTarget)
		{
		}

		protected virtual bool Approach(Game_Chara_MA_Base scrChara)
		{
			return false;
		}

		protected virtual void Rotation_Init(Game_Chara_MA_Base scrNPC)
		{
		}

		protected virtual bool Rotation_Wait(Game_Chara_MA_Base scrNPC)
		{
			return false;
		}

		protected virtual void Talk(string strADV, Game_Chara_MA_Base scrNPC)
		{
		}

		protected virtual bool IsTalkEnd()
		{
			return false;
		}

		protected virtual void Return_Init(Game_Chara_MA_Base scrNPC)
		{
		}

		protected virtual bool Return_Wait(Game_Chara_MA_Base scrNPC)
		{
			return false;
		}

		protected virtual void Last(Game_Chara_MA_Base scrNPC)
		{
		}

		protected override void Finish()
		{
		}
	}

	private class SubNPCTalk : SubNPCTalkBase
	{
		private enum eSubStep_NPCTalk
		{
			First = 0,
			Approach = 1,
			Rotation_Init = 2,
			Rotation_Wait = 3,
			Adventure_Init = 4,
			Adventure_Wait = 5,
			Return_Init = 6,
			Return_Wait = 7,
			Last = 8,
			End = 9
		}

		private static readonly float s_fRotTime;

		private float s_fFromRotation;

		private float s_fGmkFromRotation;

		private Game_Gimmick_NPCTalk m_scrNPCTalk;

		private Game_Gimmick_NPCQuestTarget m_scrNPCQuest;

		private eSubStep_NPCTalk m_eSubStep;

		private Game_Gimmick_NPCBase m_scrNPCBase
		{
			get
			{
				return null;
			}
		}

		public override void Init(Game_Chara_MA_Player scrPlayer, Game_Gimmick_Base scrGimmick)
		{
		}

		public override void Update()
		{
		}
	}

	private class SubTide : SubBase
	{
		private enum eSubStep
		{
			First = 0,
			ADV_Init = 1,
			ADV_Wait = 2,
			FadeOut_Init = 3,
			FadeOut_Wait = 4,
			Return_Init = 5,
			Return_Wait = 6,
			FadeIn_Init = 7,
			FadeIn_Wait = 8,
			Last = 9,
			End = 10
		}

		private eSubStep m_eSubStep;

		private Game_Gimmick_Tide m_scrTide
		{
			get
			{
				return null;
			}
		}

		public override void Update()
		{
		}
	}

	public enum eDirection
	{
		Forward = 0,
		RightForward = 1,
		Right = 2,
		RightBack = 3,
		Back = 4,
		LeftBack = 5,
		Left = 6,
		LeftForward = 7,
		EnumMax = 8
	}

	private class SubWarp : SubBase
	{
		private enum eSubStep_Warp
		{
			First = 0,
			Warp = 1,
			Direction = 2,
			Last = 3,
			End = 4
		}

		private eSubStep_Warp m_eSubStep;

		private Vector3 m_v3WarpPos
		{
			get
			{
				return default(Vector3);
			}
		}

		private eDirection m_eDirection
		{
			get
			{
				return eDirection.Forward;
			}
		}

		protected override void InitSub()
		{
		}

		public override void Update()
		{
		}
	}

	protected static Game_Chara_MA_Player m_Inst;

	public static readonly float m_warpTempY;

	private eMainStep m_mainStep;

	private eActionKind m_actionKind;

	private float m_waitSec_Idle;

	private float m_addPosZ_Log;

	private float m_padPressSec_Now;

	public static readonly float m_padPressSec_Action;

	private float m_padPressSec_Ignore;

	private float m_padPressVar_Action;

	private float m_runContinueSec_Now;

	private float m_runContinueSec_Max;

	public float m_padControlToMoveScale;

	private List<Game_Gimmick_Base> m_GimmickList_Req;

	private Game_Gimmick_Base m_execGimmick;

	private bool m_actionExeced;

	private bool m_execGimmickRemFlag;

	public bool m_pressFlag_ActionButton;

	protected GameObject m_raderMarker;

	protected Game_RaderMap_Marker m_raderMapMarker;

	protected bool m_forceMoveFlag;

	private Vector3 m_forceWalkTo;

	private List<string> m_forceWalkTalkNameList;

	protected bool m_warpFlag;

	private Vector3 m_warpToPos;

	private eDirection m_dirAfterWarp;

	private EButtonKind m_dialogResult;

	private bool m_isEndDialog;

	private bool m_isEndAPI;

	private bool m_isErrorAPI;

	private SubBase m_actionScr;

	private bool m_activeAutoMoveMarker;

	private bool m_autoMoveStart;

	private bool m_autoMovePartialOK;

	private bool m_acitionIconEnable;

	private bool m_isWaitBomb;

	protected float m_addPos_ScaleOrg;

	protected bool m_isOwner;

	private static readonly Vector3[] sc_v3DirAry;

	public bool IsOwner
	{
		get
		{
			return false;
		}
	}

	public static bool m_isOnBoat { get; private set; }

	public bool AutoMoveStart
	{
		get
		{
			return false;
		}
	}

	public bool IsMyPlayer
	{
		get
		{
			return false;
		}
	}

	public static Game_Chara_MA_Player GetInst()
	{
		return null;
	}

	protected override void Initialize()
	{
	}

	protected virtual void Initialize_Sub()
	{
	}

	protected void SetPlayerPointer()
	{
	}

	protected override void MoverUpdate_Pause()
	{
	}

	protected override void CheckMove()
	{
	}

	private eActionKind CheckMove_Move()
	{
		return eActionKind.None;
	}

	protected void Move(bool enableAuto = true, bool onlyAuto = false)
	{
	}

	private void EndAutoMove()
	{
	}

	private float CalcAnimationSpeed(bool toSlow, float addPosZ)
	{
		return 0f;
	}

	private void SetAutoMove()
	{
	}

	public bool SetAutoMove(Vector3 target, float speed = 0f, bool activeMarker = true, bool partialOK = true)
	{
		return false;
	}

	private void AfterCalcPath(Vector3 target, float speed = 0f, bool activeMarker = true, bool partialOK = true)
	{
	}

	public bool SetAutoMove(NavMeshPath path, float speed = 0f, bool activeMarker = true, bool partialOK = true)
	{
		return false;
	}

	public void StopAutoMove()
	{
	}

	public void PauseAutoMove(bool pause)
	{
	}

	private FieldTouchData GetFieldTouchData()
	{
		return null;
	}

	protected eActionKind CheckImmediateGimmick()
	{
		return eActionKind.None;
	}

	private void SetAnimeTrigger(eMotionKind kind)
	{
	}

	private void SetAnimeTrigger_PickUp(ePickUpToolKind kind, ePickupToolLook look = ePickupToolLook.Normal)
	{
	}

	private void SetAnimeTrigger_Bomb(eBombKind kind)
	{
	}

	private void SetAnime_Target(Vector3 target)
	{
	}

	private void SetAnime_BombScale(float scale)
	{
	}

	public override void SetAnimeFlag(eFlagMotion kind, bool flag)
	{
	}

	protected bool CheckMove_Action()
	{
		return false;
	}

	protected void FixedUpdate()
	{
	}

	public static void SetOnBoat(bool flag)
	{
	}

	public static void ResetBoat()
	{
	}

	private void ApproachTarget(Vector3 target, float dist = 1.5f)
	{
	}

	public bool IsEnableAction_Move()
	{
		return false;
	}

	private List<Game_Gimmick_Base> GetEnableGimmickList(eGimmickSelect select = eGimmickSelect.All)
	{
		return null;
	}

	private bool IsDispNotifyIcon()
	{
		return false;
	}

	private Game_Gimmick_Base GetExecutableGimmick(eGimmickSelect select = eGimmickSelect.All)
	{
		return null;
	}

	private void ClearExecutableGimmickReq()
	{
	}

	public void AddExecutableGimmickReq(Game_Gimmick_Base temp)
	{
	}

	public void RemoveExecutableGimmickReq(Game_Gimmick_Base temp)
	{
	}

	public bool IsExistExecutableGimmickReq(Game_Gimmick_Base temp)
	{
		return false;
	}

	public void UpdateNotifyIcon(bool force = false)
	{
	}

	public void ClearActionButtonFlag()
	{
	}

	public bool SetActionButtonFlag(Game_Gimmick_Base gim)
	{
		return false;
	}

	public bool IsActionButtonReq()
	{
		return false;
	}

	private void CreateYNDialog(string content, string cancel = null, string decide = null)
	{
	}

	private void CreateDialog(string subject, string content)
	{
	}

	private void CreateDialog(string content)
	{
	}

	private void CreateHoldItemDialog(string content)
	{
	}

	private void OnEndDialog(EButtonKind resut)
	{
	}

	public float GetRotateY()
	{
		return 0f;
	}

	public void SetRotationY(Vector3 toPos, bool bImmidiate = false)
	{
	}

	public void SetRotationY(float y)
	{
	}

	public void SetRotationY(Quaternion rotate)
	{
	}

	public void SetWarp_Pos(Vector3 newPos)
	{
	}

	public void SetWarp_Add(Vector3 addPos)
	{
	}

	public void SetWarpWithEffect(Vector3 toPos, eDirection dir)
	{
	}

	public override void MakeCharaObject(MakeCharaData data, bool springFlag, bool ignoreOptionParts = false, eAnimator anim = eAnimator.EnumMax)
	{
	}

	public override void ForceAddPos(float value = 0f)
	{
	}

	public void ForceWalk(Vector3 toPos, List<string> talkFileList = null)
	{
	}

	public void StopForceWalk()
	{
	}

	public override GameObject SetOverHeadEmote(bool flag, eOverHeadPos pos, EEmoticon emote = EEmoticon.eNONE, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
		return null;
	}

	public bool IsBattleOK()
	{
		return false;
	}

	public bool IsAutoPickOnOK()
	{
		return false;
	}

	public eActionKind GetNowAction()
	{
		return eActionKind.None;
	}

	public override void SetAgent(bool enable = true)
	{
	}

	public void InventoryOverCheck()
	{
	}

	[DebuggerHidden]
	private IEnumerator InventoryOverProc()
	{
		return null;
	}

	public void SetWaitBombFlag(bool flag)
	{
	}

	private void SetExecGimmick(Game_Gimmick_Base gmk)
	{
	}

	public void RemoveGimmickLog(Game_Gimmick_Base gimmick)
	{
	}

	public override void SetActive(bool active)
	{
	}

	public virtual void UpdateRaderMap()
	{
	}

	public void PrintDebug()
	{
	}

	protected override void UpdateMove()
	{
	}

	public void MoverUpdate_Viewer()
	{
	}
}
