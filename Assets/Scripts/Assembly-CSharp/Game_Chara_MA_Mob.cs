public class Game_Chara_MA_Mob : Game_Chara_MA_Base
{
	public float m_waitSec_Min;

	public float m_waitSec_Max;

	private float m_waitSec_Now;

	public float m_stopPercent;

	public float m_addPosZ_Min;

	public float m_addPosZ_Max;

	public float m_addRotY_Max;

	private float m_addPosZ_Log;

	private float m_addRotY_Log;

	protected override void MoverUpdate_Normal()
	{
	}

	protected override void CheckMove()
	{
	}
}
