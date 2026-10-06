namespace MessagePack.Formatters
{
	public sealed class APIRespireFusion_RequestFormatter : IMessagePackFormatter<APIRespireFusion.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIRespireFusion.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIRespireFusion.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
