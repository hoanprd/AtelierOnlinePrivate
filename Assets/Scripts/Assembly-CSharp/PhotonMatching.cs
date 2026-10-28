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
			return true;
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

	private static readonly int sr_iSearchMax = 20;

	private static List<long> m_lIgnoreRoomIdList = new List<long>();

	public static List<RoomInfo> SearchLookRoomList(RoomInfo[] clsRoomAry, string strMyRoomId)
	{
		List<RoomInfo> list = new List<RoomInfo>();
		if (clsRoomAry == null)
		{
			return list;
		}
		for (int i = 0; i < clsRoomAry.Length && list.Count < sr_iSearchMax; i++)
		{
			if (clsRoomAry[i] != null && clsRoomAry[i].Name != strMyRoomId)
			{
				list.Add(clsRoomAry[i]);
			}
		}
		return list;
	}

	public static void SearchRoom(int iMyAreaId, List<RoomInfo> clsLookRoomList, ref bool bFind, ref string strMyRoomName)
	{
		bFind = false;
	}

	public static void CheckRoom(RoomInfo clsRoom, int iMyAreaId, ref SearchResult clsResult)
	{
		clsResult.bSuccess = false;
		clsResult.eFailedCondition = eJoinCondition.None;
	}

	public static bool IsRoomAreaOK(Hashtable htCP, int iMyAreaId)
	{
		return GetRoomAreaId(htCP) == iMyAreaId;
	}

	public static int GetRoomAreaId(Hashtable htCP)
	{
		if (htCP != null && htCP.ContainsKey("area") && htCP["area"] is int)
		{
			return (int)htCP["area"];
		}
		return 0;
	}

	public static bool IsLookOKRoom(Hashtable htCP)
	{
		return true;
	}

	public static bool IsPlayerOK(Hashtable htCP)
	{
		return true;
	}

	private static bool IsExistIgnoreUser(string[] strSplitAry)
	{
		return false;
	}

	public static void SearchFriendRoom(string strRoomName, long lFriendId, string strUserId, List<RoomInfo> clsLookRoomList, ref bool bFind, ref string strMessage, ref int iAreaId)
	{
		bFind = false;
	}

	public static bool IsRoomName(RoomInfo clsRoom, string strRoomName)
	{
		return clsRoom != null && clsRoom.Name == strRoomName;
	}

	public static void CheckFriendRoom(RoomInfo clsRoom, long lFriendId, string strUserId, ref SearchResult clsResult)
	{
		clsResult.bSuccess = false;
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
		if (m_lIgnoreRoomIdList == null)
		{
			m_lIgnoreRoomIdList = new List<long>();
		}
		if (!m_lIgnoreRoomIdList.Contains(lRoomId))
		{
			m_lIgnoreRoomIdList.Add(lRoomId);
		}
	}

	public static void ClearIgnoreRoom()
	{
		if (m_lIgnoreRoomIdList != null)
		{
			m_lIgnoreRoomIdList.Clear();
		}
	}
}
