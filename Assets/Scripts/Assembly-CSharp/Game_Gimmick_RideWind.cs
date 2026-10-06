using System.Collections.Generic;
using UnityEngine;

public class Game_Gimmick_RideWind : Game_Gimmick_Base
{
	private List<SphereCollider> m_scrCollList;

	private List<GameObject> m_goLandPointList;

	private GameObject m_goEffect;

	public void Init(eBombLevel eLv, List<SphereCollider> scrCollList)
	{
	}

	public Vector3 GetDestination(Vector3 v3FromPos)
	{
		return default(Vector3);
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
