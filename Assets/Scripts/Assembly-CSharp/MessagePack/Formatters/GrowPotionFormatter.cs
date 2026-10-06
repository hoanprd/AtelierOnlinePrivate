namespace MessagePack.Formatters
{
	public sealed class GrowPotionFormatter : IMessagePackFormatter<GrowPotion>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowPotion value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowPotion Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
