using System.Collections.Generic;
using UnityEngine;

public class MasterEnemy : MasterListBase<EnemyInfo>
{
	public List<EnemyKindInfo> KindList;

	public List<EnemyModelInfo> ModelList;

	private Vector3 m_HitPos;

	public new EnemyInfo Find(int DF)
	{
		return null;
	}

	public EnemyInfo Find(eEnemyKind eKind, int iCategory)
	{
		return null;
	}

	public string GetEnemyName(eEnemyKind eKind, int iCategory)
	{
		return null;
	}

	public string GetKindName(eEnemyKind eKind)
	{
		return null;
	}

	public string GetEnemyTexPath(eEnemyKind eKind, int iCategory)
	{
		return null;
	}

	public List<EnemyInfo> Find(List<int> DFList)
	{
		return null;
	}

	public bool IsExistKind(eEnemyKind eKind)
	{
		return false;
	}

	public Vector3 GetHitPosition(int enemyKind, int enemySubId)
	{
		return default(Vector3);
	}

	public float GetEffectSize(int enemyKind, int enemySubId)
	{
		return 0f;
	}
}
