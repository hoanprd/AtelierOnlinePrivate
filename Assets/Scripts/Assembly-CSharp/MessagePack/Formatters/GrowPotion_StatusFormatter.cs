namespace MessagePack.Formatters
{
	public sealed class GrowPotion_StatusFormatter : IMessagePackFormatter<GrowPotion.Status>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowPotion.Status value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowPotion.Status Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
