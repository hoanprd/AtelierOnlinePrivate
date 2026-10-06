using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AreaInfo
{
	public enum ESunlightKind
	{
		eDEFAULT = 0,
		eANIM = 1,
		eFIXED = 2
	}

	public int iAreaId;

	public int iAreaNameId;

	public int iHardMode;

	public int iStartPortalID;

	public Color32 cMapColor;

	public int iRestartStage;

	public int iRestartSpawn;

	public Color32 cMapListColor;

	public eMusicID eMusic_Day;

	public eMusicID eMusic_Night;

	public List<eMusicID> eOtherMusicList;

	public eMusicID eMusic_NormalBattle;

	public eAreaMulti eMultiKind;

	public ESunlightKind eSunlightKind;

	public string sSunlightAnimPath;

	public Vector4[] aFixedSunlight;

	public FieldName GetAreaName()
	{
		return null;
	}

	public bool IsAreaNameId(int iAreaNameId)
	{
		return false;
	}

	public bool IsAreaId(int iAreaId)
	{
		return false;
	}

	public bool IsVisit()
	{
		return false;
	}

	public void SetVisit()
	{
	}

	public List<string> GetMusicAssetNameList()
	{
		return null;
	}

	public bool IsHardModeArea()
	{
		return false;
	}

	public int GetStartPortalID()
	{
		return 0;
	}
}
