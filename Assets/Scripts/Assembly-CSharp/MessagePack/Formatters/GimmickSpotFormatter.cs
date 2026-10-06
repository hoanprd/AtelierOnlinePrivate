namespace MessagePack.Formatters
{
	public sealed class GimmickSpotFormatter : IMessagePackFormatter<GimmickSpot>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GimmickSpot value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GimmickSpot Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
