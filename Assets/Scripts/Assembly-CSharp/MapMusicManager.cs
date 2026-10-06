using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MapMusicManager : MonoBehaviour
{
	[StructLayout((LayoutKind)0, Size = 16)]
	public struct MusicFactor
	{
		public eAreaKind eArea;

		public int iId;

		public bool bDungeon;

		public bool bParts;

		public bool IsChange(MusicFactor strctFactor)
		{
			return false;
		}

		public void Set(MusicFactor strctFactor)
		{
		}

		public void Set(eAreaKind eArea, int iId, bool bDungeon, bool bParts)
		{
		}
	}

	public class MusicTime
	{
		public eMusicID eMusic;

		public float fTime;
	}

	public enum eTimeZone
	{
		Day = 0,
		Night = 1,
		EnumMax = 2
	}

	private static readonly int sr_iLogMax;

	private static MapMusicManager s_scrInstance;

	private eTimeZone m_eTimeZone;

	private MusicFactor m_strctFactorNow;

	private MusicFactor m_strctFactorReq;

	private bool m_bEnableNow;

	private bool m_bEnableReq;

	private eMusicID m_eLatestMusic;

	private bool m_bFieldMusic;

	private eMusicID m_eMapPriMusicNow;

	private eMusicID m_eMapPriMusicReq;

	private List<MusicTime> m_clsFieldBGMList;

	public static MapMusicManager Instance
	{
		get
		{
			return null;
		}
	}

	private static eMusicID GetMusic(eAreaKind eArea, int iId, eTimeZone eZone, bool bDungeon, bool bParts)
	{
		return eMusicID.Title;
	}

	private static eTimeZone GetTimeZone()
	{
		return eTimeZone.Day;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ChangeMusic(eAreaKind eArea, int iId, eTimeZone eZone, bool bDungeon, bool bParts)
	{
	}

	private void ChangeMusic(eMusicID eMusic, eAreaKind eArea)
	{
	}

	private void UpdateTimeLog(eMusicID eLatestMusic, float fTime)
	{
	}

	private void FloorLog()
	{
	}

	public void Request(eAreaKind eKind, int iId, bool bDungeon = false, bool bParts = false)
	{
	}

	public void Request(eMusicID eMusic)
	{
	}

	public eMusicID GetPriMusic()
	{
		return eMusicID.Title;
	}

	public void SetEnable(bool bEnable)
	{
	}

	public void ClearLog()
	{
	}
}
