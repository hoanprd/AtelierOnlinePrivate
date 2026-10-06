namespace MessagePack.Formatters
{
	public sealed class RpcBattleInterruptSkillFormatter : IMessagePackFormatter<RpcBattleInterruptSkill>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleInterruptSkill value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleInterruptSkill Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
