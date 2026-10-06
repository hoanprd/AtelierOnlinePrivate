public static class Game_MA_GateManager
{
	public static readonly int sc_iAcademyAreaId;

	public static readonly int sc_iAcadeyFrontId;

	public static readonly int sc_iFairyAreaId;

	public static readonly int sc_iCanusAreaId;

	public static readonly int sc_iCanusAreaId_hard;

	private static bool s_bNewRequest;

	private static bool s_bRoomNameRequest;

	private static readonly string sr_strMultiModeKey;

	private static readonly string sr_strPrivateRoomKey;

	public static int s_iLatestAreaId { get; private set; }

	public static int s_iLatestStageId { get; private set; }

	public static int s_iLatestSpawnId { get; private set; }

	public static string s_strReqRoomName { get; private set; }

	public static bool s_bMultiMode { get; private set; }

	public static bool s_bMultiModePrefs
	{
		get
		{
			return false;
		}
	}

	public static EPrivateRoom s_ePrivateRoom { get; private set; }

	public static EPrivateRoom s_ePrivateRoomPrefs
	{
		get
		{
			return EPrivateRoom.All;
		}
	}

	public static int s_iPrevAreaId { get; private set; }

	public static UnlockGateList s_clsGateList { get; private set; }

	public static void Init()
	{
	}

	public static void RequestGateJump(int iPortalId)
	{
	}

	public static void RequestJump(int iAreaId, int iStageId, int iSpawnId)
	{
	}

	public static void RequestJump(int iAreaId, int iStageId, int iSpawnId, string strReqRoomName)
	{
	}

	public static void SetMultiRequest(bool bMulti, bool bStore = true)
	{
	}

	public static void SetMultiRequest(bool bMulti, EPrivateRoom ePrivateRoom, bool bStore = true)
	{
	}

	public static void StoreMultiStatus(bool bMulti, EPrivateRoom ePrivateRoom)
	{
	}

	public static void RequestAcademy()
	{
	}

	public static bool IsExistRequest()
	{
		return false;
	}

	public static bool IsSameAreaRequest()
	{
		return false;
	}

	public static bool IsExistRoomRequest()
	{
		return false;
	}

	public static bool IsModeChange()
	{
		return false;
	}

	public static void SetRequestEnd()
	{
	}

	public static bool IsRequestAcademy()
	{
		return false;
	}

	public static void UpdateGateList(UnlockGateList clsGateList)
	{
	}

	public static void UpdateFieldGateList(UnlockGateList clsGateList)
	{
	}

	public static GateInfo GetGateData(int iPortalId)
	{
		return null;
	}

	public static GateInfo[] GetGateDataList(int iAreaId)
	{
		return null;
	}

	public static GateInfo GetAcademyGateData()
	{
		return null;
	}

	public static GateInfo GetAcademyFrontGateData()
	{
		return null;
	}

	public static UnlockGateList GetUnlockGateList(bool bField = false)
	{
		return null;
	}

	public static UnlockGate GetUnlockGate(int iId, bool bField = false)
	{
		return null;
	}
}
