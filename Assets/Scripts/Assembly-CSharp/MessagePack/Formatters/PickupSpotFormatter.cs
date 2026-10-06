namespace MessagePack.Formatters
{
	public sealed class PickupSpotFormatter : IMessagePackFormatter<PickupSpot>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PickupSpot value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PickupSpot Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
