public class PartyCharaData
{
	public MakeCharaData makeCharaData;

	public BattleCharaData battleCharaData;

	private PartyMember m_memberData;

	public int DF
	{
		get
		{
			return 0;
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
	}

	public PartyCharaData(PartyMember mem)
	{
	}

	public PartyCharaData(MakeCharaData _makeCharaData, BattleCharaData _battleCharaData)
	{
	}
}
