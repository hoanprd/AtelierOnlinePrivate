namespace MessagePack.Formatters
{
	public sealed class PickTraitResponseFormatter : IMessagePackFormatter<PickTraitResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PickTraitResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PickTraitResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
