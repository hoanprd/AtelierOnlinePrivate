namespace MessagePack.Formatters
{
	public sealed class GrowCharaData_PowerupInfoFormatter : IMessagePackFormatter<GrowCharaData.PowerupInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowCharaData.PowerupInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowCharaData.PowerupInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
