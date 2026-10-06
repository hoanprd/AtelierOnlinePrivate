namespace MessagePack.Formatters
{
	public sealed class SalonInfo_AppearanceDatabaseFormatter : IMessagePackFormatter<SalonInfo.AppearanceDatabase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SalonInfo.AppearanceDatabase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SalonInfo.AppearanceDatabase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
