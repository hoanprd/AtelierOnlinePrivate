namespace MessagePack.Formatters
{
	public sealed class GrowPotion_InfoFormatter : IMessagePackFormatter<GrowPotion.Info>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowPotion.Info value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowPotion.Info Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
