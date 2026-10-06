namespace MessagePack.Formatters
{
	public sealed class GrowCharaData_InfoFormatter : IMessagePackFormatter<GrowCharaData.Info>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowCharaData.Info value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowCharaData.Info Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
