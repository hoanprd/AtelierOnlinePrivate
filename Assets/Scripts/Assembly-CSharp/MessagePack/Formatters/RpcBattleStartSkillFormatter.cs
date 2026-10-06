namespace MessagePack.Formatters
{
	public sealed class RpcBattleStartSkillFormatter : IMessagePackFormatter<RpcBattleStartSkill>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcBattleStartSkill value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcBattleStartSkill Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
