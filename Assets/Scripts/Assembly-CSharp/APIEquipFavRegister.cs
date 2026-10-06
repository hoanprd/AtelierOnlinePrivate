using System.Collections.Generic;

public class APIEquipFavRegister : MsgPackAPICommon<PartyEquipFavoRegisterResponse>
{
	public class Request
	{
		public int DF;

		public int NO;

		public EquipData EQU;

		public string NAME;

		public List<SubEquip> SUB;

		public int KIND;
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

	public int NO
	{
		set
		{
		}
	}

	public string NA
	{
		set
		{
		}
	}

	public List<SubEquip> Sub
	{
		set
		{
		}
	}

	public int Kind
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
