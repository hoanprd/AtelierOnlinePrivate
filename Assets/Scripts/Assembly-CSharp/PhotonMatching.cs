using System.Collections.Generic;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class PhotonMatching : MonoBehaviour
{
	public enum eOptionKind
	{
		None = 0,
		NearLv = 1
	}

	public class MatchOption
	{
		public eOptionKind eKind;

		public int iParam;

		public bool IsMatch(RoomInfo clsRoom)
		{
			return false;
		}
	}

	public enum eJoinCondition
	{
		None = 0,
		Multi = 1,
		PlayerNum = 2,
		IgnoreRoom = 3,
		IgnoreUser = 4,
		Area = 5,
		Friend = 6,
		FriendRoom = 7
	}

	[StructLayout((LayoutKind)0, Size = 8)]
	public struct SearchResult
	{
		public bool bSuccess;

		public eJoinCondition eFailedCondition;
	}

	private static readonly int sr_iSearchMax;

	private static List<long> m_lIgnoreRoomIdList;

	public static List<RoomInfo> SearchLookRoomList(RoomInfo[] clsRoomAry, string strMyRoomId)
	{
		return null;
	}

	public static void SearchRoom(int iMyAreaId, List<RoomInfo> clsLookRoomList, ref bool bFind, ref string strMyRoomName)
	{
	}

	public static void CheckRoom(RoomInfo clsRoom, int iMyAreaId, ref SearchResult clsResult)
	{
	}

	public static bool IsRoomAreaOK(Hashtable htCP, int iMyAreaId)
	{
		return false;
	}

	public static int GetRoomAreaId(Hashtable htCP)
	{
		return 0;
	}

	public static bool IsLookOKRoom(Hashtable htCP)
	{
		return false;
	}

	public static bool IsPlayerOK(Hashtable htCP)
	{
		return false;
	}

	private static bool IsExistIgnoreUser(string[] strSplitAry)
	{
		return false;
	}

	public static void SearchFriendRoom(string strRoomName, long lFriendId, string strUserId, List<RoomInfo> clsLookRoomList, ref bool bFind, ref string strMessage, ref int iAreaId)
	{
	}

	public static bool IsRoomName(RoomInfo clsRoom, string strRoomName)
	{
		return false;
	}

	public static void CheckFriendRoom(RoomInfo clsRoom, long lFriendId, string strUserId, ref SearchResult clsResult)
	{
	}

	public static bool IsExistUser(Hashtable htCP, long lCheckUserId)
	{
		return false;
	}

	private static bool IsExistUser(string[] strSplitAry, long lCheckId)
	{
		return false;
	}

	public static void AddIgnoreRoom(long lRoomId)
	{
	}

	public static void ClearIgnoreRoom()
	{
	}
}
