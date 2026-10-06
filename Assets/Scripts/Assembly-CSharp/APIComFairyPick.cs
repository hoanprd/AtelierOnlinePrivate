public class APIComFairyPick : MsgPackAPICommon<FairyPickResponse>
{
	public class Request
	{
		public int FLD;

		public int DGN;

		public int CNT;
	}

	private Request m_sRequest;

	public int FieldID
	{
		set
		{
		}
	}

	public int DungeonID
	{
		set
		{
		}
	}

	public int Count
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
