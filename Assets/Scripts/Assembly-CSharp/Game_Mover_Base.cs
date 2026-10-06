using UnityEngine;

public class Game_Mover_Base : System_Mover_Base
{
	protected virtual void SetDrawRenderer(bool enabled)
	{
	}

	protected virtual bool IsCulling()
	{
		return false;
	}

	protected override bool IsPause_Move()
	{
		return false;
	}

	protected bool IsPlayerObj(GameObject targetObj)
	{
		return false;
	}

	protected Vector3 GetDistance_Player()
	{
		return default(Vector3);
	}
}
