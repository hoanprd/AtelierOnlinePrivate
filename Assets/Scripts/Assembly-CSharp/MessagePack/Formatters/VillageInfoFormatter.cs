namespace MessagePack.Formatters
{
	public sealed class VillageInfoFormatter : IMessagePackFormatter<VillageInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, VillageInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public VillageInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
