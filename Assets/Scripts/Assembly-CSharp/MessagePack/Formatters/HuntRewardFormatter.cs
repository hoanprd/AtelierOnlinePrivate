namespace MessagePack.Formatters
{
	public sealed class HuntRewardFormatter : IMessagePackFormatter<HuntReward>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntReward value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntReward Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
