namespace MessagePack.Formatters
{
	public sealed class GimmickActivate_RequestFormatter : IMessagePackFormatter<GimmickActivate.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GimmickActivate.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GimmickActivate.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
