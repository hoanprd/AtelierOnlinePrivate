namespace MessagePack.Formatters
{
	public sealed class GrowPotionResponseFormatter : IMessagePackFormatter<GrowPotionResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowPotionResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowPotionResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
