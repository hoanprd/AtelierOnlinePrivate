namespace MessagePack.Formatters
{
	public sealed class JoinConditionFormatter : IMessagePackFormatter<JoinCondition>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, JoinCondition value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public JoinCondition Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
