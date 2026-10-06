namespace MessagePack.Formatters
{
	public sealed class PickupSpot_ToolFormatter : IMessagePackFormatter<PickupSpot.Tool>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PickupSpot.Tool value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PickupSpot.Tool Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
