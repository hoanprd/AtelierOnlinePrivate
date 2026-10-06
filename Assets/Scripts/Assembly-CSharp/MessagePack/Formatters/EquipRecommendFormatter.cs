namespace MessagePack.Formatters
{
	public sealed class EquipRecommendFormatter : IMessagePackFormatter<EquipRecommend>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipRecommend value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipRecommend Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
