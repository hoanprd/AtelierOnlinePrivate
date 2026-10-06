using Mission;

namespace MessagePack.Formatters.Mission
{
	public sealed class RewardWorthFormatter : IMessagePackFormatter<RewardWorth>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RewardWorth value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RewardWorth Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
