namespace MessagePack.Formatters
{
	public sealed class FieldJoinResponseFormatter : IMessagePackFormatter<FieldJoinResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FieldJoinResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FieldJoinResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
