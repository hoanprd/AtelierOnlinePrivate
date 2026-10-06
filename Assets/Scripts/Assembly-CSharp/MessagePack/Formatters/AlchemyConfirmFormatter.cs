namespace MessagePack.Formatters
{
	public sealed class AlchemyConfirmFormatter : IMessagePackFormatter<AlchemyConfirm>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyConfirm value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyConfirm Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
