namespace MessagePack.Formatters
{
	public sealed class VillageHealResponseFormatter : IMessagePackFormatter<VillageHealResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, VillageHealResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public VillageHealResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
