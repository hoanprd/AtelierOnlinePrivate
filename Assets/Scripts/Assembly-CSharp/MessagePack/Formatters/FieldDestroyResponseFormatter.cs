namespace MessagePack.Formatters
{
	public sealed class FieldDestroyResponseFormatter : IMessagePackFormatter<FieldDestroyResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldDestroyResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldDestroyResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
