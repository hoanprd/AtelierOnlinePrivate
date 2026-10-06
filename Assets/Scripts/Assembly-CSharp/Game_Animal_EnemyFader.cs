using UnityEngine;

public class Game_Animal_EnemyFader : Game_Animal_BaseFader
{
	private static GameObject s_goFadeSound;

	private bool m_bEnable;

	private bool m_bFirstEnable;

	private bool m_bFadeForward_Log;

	protected override bool IsPause_Move()
	{
		return false;
	}

	protected override bool IsMoveNGtoOK()
	{
		return false;
	}

	protected override bool IsMoveOKtoNG()
	{
		return false;
	}

	public void SetDrawEnable(bool bEnable)
	{
	}

	public void SetCullingDist(float fDist)
	{
	}

	protected override void AnimalUpdate_FadeInit(bool bForward)
	{
	}

	protected override void SetChangeMaterialList(GameObject tempObj)
	{
	}
}
