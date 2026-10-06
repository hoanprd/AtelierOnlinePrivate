namespace MessagePack.Formatters
{
	public sealed class VillageInfoResponseFormatter : IMessagePackFormatter<VillageInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, VillageInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public VillageInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
