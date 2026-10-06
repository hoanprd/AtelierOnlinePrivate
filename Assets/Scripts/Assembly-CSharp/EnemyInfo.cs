using System;

[Serializable]
public class EnemyInfo : MasterRecordDFBase
{
	public int bBoss;

	public eAttackTargetKind eAttackTargetKind;

	public string sNormalAttackFile;

	public string sBossStartFile;

	public string sBossEndFile;

	public eEnemyKind eKind;

	public int iCategory;

	public eMusicID musicID;

	public string strName;

	public string strAnotherName;

	public eEnemySize eSize;

	public int bAura;

	public float fViewRadius;

	public float fViewCos;

	public float fMoveRadius;

	public float fMoveSpeed;

	public float fHitRadius;

	public bool bOnlyOnline;

	public float fCullingSide;

	public string strDesc;

	public EnemyParam sParam;

	public string GetTexPath()
	{
		return null;
	}

	public string GetIconPath()
	{
		return null;
	}

	public float GetViewRadius()
	{
		return 0f;
	}

	public float GetMoveRadius()
	{
		return 0f;
	}

	public CharaSpec GetParam(int lv)
	{
		return null;
	}

	public bool IsBoss()
	{
		return false;
	}

	public bool IsAdventBattle()
	{
		return false;
	}

	public EElement GetWeakElement()
	{
		return EElement.eNONE;
	}
}
