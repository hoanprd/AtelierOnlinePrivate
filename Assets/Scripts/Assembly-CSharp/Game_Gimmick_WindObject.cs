using System.Collections.Generic;
using UnityEngine;

public class Game_Gimmick_WindObject : Game_Gimmick_UseBombBase
{
	private List<SphereCollider> m_scrCollList;

	public void SetCollider(List<Game_Spawner_WindObject.CollStatus> clsCollList)
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected override void ExecOwn()
	{
	}

	protected override void ExecMultiSub(bool perform)
	{
	}

	private void CommonExec(bool perform)
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
