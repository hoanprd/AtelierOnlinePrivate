public class Game_Animal_Stalk : Game_Animal_BaseMover
{
	public float m_addPos_Scale;

	protected float m_addPosZ_Now;

	protected float m_rotationY;

	private bool m_dist_StalkFlag;

	private float m_dist_StalkBegin;

	private float m_dist_StalkEnd;

	private float m_addPosZ_Log;

	private float m_addPosZ_Slow;

	private float m_addPosZ_Stalk;

	private float m_addPosZ_Default;

	private float m_addRotY_Normal;

	private float m_driftRotY_Log;

	private float m_waitSec_Move_Now;

	private float m_waitSec_Move_Min;

	private float m_waitSec_Move_Max;

	private bool m_isMoveOK;

	public override void InitializeAnimal()
	{
	}

	public void SetStalkData(float speed, float begin, float end)
	{
	}

	protected override void MoveOK_Wait()
	{
	}

	private void SetStalkMode(bool flag)
	{
	}

	public bool IsStalkMode()
	{
		return false;
	}

	public void SetMoveOK(bool flag)
	{
	}
}
