namespace MessagePack.Formatters
{
	public sealed class GrowCharaData_LevelLimitFormatter : IMessagePackFormatter<GrowCharaData.LevelLimit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowCharaData.LevelLimit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowCharaData.LevelLimit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
