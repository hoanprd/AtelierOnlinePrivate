namespace MessagePack.Formatters
{
	public sealed class AlchemyOverwritePickTraitResponseFormatter : IMessagePackFormatter<AlchemyOverwritePickTraitResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyOverwritePickTraitResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyOverwritePickTraitResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
