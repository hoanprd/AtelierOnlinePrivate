namespace MessagePack.Formatters
{
	public sealed class RewardInfoExtFormatter : IMessagePackFormatter<RewardInfoExt>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RewardInfoExt value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RewardInfoExt Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
