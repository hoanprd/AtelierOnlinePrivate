namespace MessagePack.Formatters
{
	public sealed class EquipRecommendResponseFormatter : IMessagePackFormatter<EquipRecommendResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipRecommendResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipRecommendResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
