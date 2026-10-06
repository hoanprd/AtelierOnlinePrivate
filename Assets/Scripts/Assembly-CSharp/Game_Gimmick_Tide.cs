using UnityEngine;
using UnityEngine.AI;

public class Game_Gimmick_Tide : Game_Gimmick_Base
{
	private static readonly float sr_fObstacleActiveTime;

	private float m_fWaitTime;

	[SerializeField]
	private GameObject m_goReturnPos;

	[SerializeField]
	private string m_strADVFile;

	public NavMeshObstacle m_scrObstacle;

	public MeshRenderer m_scrMeshRenderer;

	private void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public override bool IsImmediate()
	{
		return false;
	}

	public Vector3 GetReturnPos()
	{
		return default(Vector3);
	}

	public string GetADVFileName()
	{
		return null;
	}
}
