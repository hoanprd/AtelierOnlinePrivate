using Mission;

namespace MessagePack.Formatters.Mission
{
	public sealed class RewardItemFormatter : IMessagePackFormatter<RewardItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RewardItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RewardItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
