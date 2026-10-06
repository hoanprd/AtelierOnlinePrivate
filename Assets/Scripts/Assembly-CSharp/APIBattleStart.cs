public class APIBattleStart : MsgPackAPICommon<BattleStartResponse>
{
	public class Request
	{
		public int BT;
	}

	private Request m_sRequest;

	public int BattleID
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}
}
