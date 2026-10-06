namespace MessagePack.Formatters
{
	public sealed class AlchemyConfirm_ItemFormatter : IMessagePackFormatter<AlchemyConfirm.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyConfirm.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyConfirm.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
