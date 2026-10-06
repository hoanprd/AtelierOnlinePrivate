namespace MessagePack.Formatters
{
	public sealed class NPCSpotFormatter : IMessagePackFormatter<NPCSpot>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, NPCSpot value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public NPCSpot Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
