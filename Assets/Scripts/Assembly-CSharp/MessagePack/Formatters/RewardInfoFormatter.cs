namespace MessagePack.Formatters
{
	public sealed class RewardInfoFormatter : IMessagePackFormatter<RewardInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RewardInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RewardInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
