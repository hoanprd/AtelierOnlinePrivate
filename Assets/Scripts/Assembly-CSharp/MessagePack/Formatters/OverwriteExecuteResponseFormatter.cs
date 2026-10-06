namespace MessagePack.Formatters
{
	public sealed class OverwriteExecuteResponseFormatter : IMessagePackFormatter<OverwriteExecuteResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, OverwriteExecuteResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public OverwriteExecuteResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
