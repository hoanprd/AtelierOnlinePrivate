namespace MessagePack.Formatters
{
	public sealed class AlchemyConfirm_CandidateSkillFormatter : IMessagePackFormatter<AlchemyConfirm.CandidateSkill>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyConfirm.CandidateSkill value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyConfirm.CandidateSkill Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
