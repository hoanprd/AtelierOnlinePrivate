namespace MessagePack.Formatters
{
	public sealed class AlchemyOverwritePickTraitResponse_WealthAmountFormatter : IMessagePackFormatter<AlchemyOverwritePickTraitResponse.WealthAmount>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyOverwritePickTraitResponse.WealthAmount value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyOverwritePickTraitResponse.WealthAmount Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
