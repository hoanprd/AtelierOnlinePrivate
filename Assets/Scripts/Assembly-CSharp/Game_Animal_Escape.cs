public class Game_Animal_Escape : Game_Animal_ItemDrop
{
	public float m_addPos_Scale;

	protected float m_addPosZ_Now;

	protected float m_rotationY;

	private float m_waitSec_Min;

	private float m_waitSec_Max;

	private float m_waitSec_Now;

	private bool m_escapeFlag;

	private float m_dist_Emergency;

	private float m_dist_Safety;

	private float m_addPosZ_Max;

	private float m_addRotY_Max;

	private float m_addPosZ_Log;

	private float m_addRotY_Log;

	public override void InitializeAnimal()
	{
	}

	protected override void MoveOK_Init()
	{
	}

	protected override void MoveOK_Wait()
	{
	}

	protected override bool IsMoveOKtoNG()
	{
		return false;
	}

	protected override void MoveNG_Init()
	{
	}
}
