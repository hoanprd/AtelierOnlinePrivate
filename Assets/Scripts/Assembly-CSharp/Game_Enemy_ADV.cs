using System;
using UnityEngine;

public class Game_Enemy_ADV : Game_Enemy_FieldBase
{
	private ADVMoveObj m_scrMove;

	public override void SetData_F(long enemyId, int df, bool[] moveTime, bool[] moveWeather, eFEnemyAIType ai, eFakeEnemy fake, bool isRandom, int level, int auraSize, Action<GameObject> makeCallback)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void Kill()
	{
	}

	protected void OnWalk()
	{
	}

	protected void OnDash()
	{
	}

	protected void OnEnd()
	{
	}

	public void SetAutoMove(Vector3 target, float speed, bool useNavmesh, bool firstFull, bool endFull, bool rotate)
	{
	}

	public bool IsAutoMoveEnd()
	{
		return false;
	}

	public void ForceEndMove()
	{
	}
}
