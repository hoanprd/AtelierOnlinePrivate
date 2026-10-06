namespace MessagePack.Formatters
{
	public sealed class AlchemyOverwriteExecuteResultFormatter : IMessagePackFormatter<AlchemyOverwriteExecuteResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AlchemyOverwriteExecuteResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AlchemyOverwriteExecuteResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
