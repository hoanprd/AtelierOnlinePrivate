namespace MessagePack.Formatters
{
	public sealed class EnemySpotFormatter : IMessagePackFormatter<EnemySpot>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EnemySpot value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EnemySpot Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
