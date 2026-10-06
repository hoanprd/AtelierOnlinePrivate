public class APIBattleJoin : MsgPackAPICommon<BattleJoinResponse>
{
	public class Request
	{
		public long USR;
	}

	private Request m_sRequest;

	public long User
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
