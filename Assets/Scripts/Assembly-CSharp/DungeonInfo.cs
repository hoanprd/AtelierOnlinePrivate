using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DungeonInfo
{
	public int iDungeonId;

	public int iAreaNameId;

	public int iAreaId;

	public int iMaxFloor;

	public bool iForExtra;

	public int iReturnArea;

	public int iReturnStage;

	public int iReturnSpawn;

	public string strBattleBG;

	public eMusicID eMusic;

	public bool bEnableFilter;

	public List<int> iFlowIdList;

	public eSoundID eRandomSE;

	public float fRandomSECheckSec;

	public float fRandomSEPer;

	public Vector4[] a11FSunlight;

	public Vector4[] a21FSunlight;

	public bool IsDungeonId(int iDungeonId)
	{
		return false;
	}

	public bool IsFieldDungeon()
	{
		return false;
	}

	public bool IsParts()
	{
		return false;
	}

	public FieldName GetFieldName()
	{
		return null;
	}

	public int GetFlow(int iFloor)
	{
		return 0;
	}

	public string GetMusicAssetName()
	{
		return null;
	}

	public bool IsForExtraQuest()
	{
		return false;
	}
}
