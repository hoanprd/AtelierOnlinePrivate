namespace MessagePack.Formatters
{
	public sealed class APIOverwriteExecute_RequestFormatter : IMessagePackFormatter<APIOverwriteExecute.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIOverwriteExecute.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIOverwriteExecute.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
