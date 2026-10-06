namespace MessagePack.Formatters
{
	public sealed class RpcBattleInterruptSkillCancelFormatter : IMessagePackFormatter<RpcBattleInterruptSkillCancel>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleInterruptSkillCancel value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleInterruptSkillCancel Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
