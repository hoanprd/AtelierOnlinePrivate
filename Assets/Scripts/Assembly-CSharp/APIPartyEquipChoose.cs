public class APIPartyEquipChoose : APISimple
{
	public class Request
	{
		public int DF;

		public EquipData EQU;

		public ResponseBase TUTO;

		public int[] CD_V;
	}

	private Request m_sRequest;

	public int CharaID
	{
		set
		{
		}
	}

	public EquipData Equip
	{
		set
		{
		}
	}

	public int[] Disp
	{
		set
		{
		}
	}

	public int TutoDf
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
