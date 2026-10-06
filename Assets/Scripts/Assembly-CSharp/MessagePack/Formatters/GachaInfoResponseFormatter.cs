namespace MessagePack.Formatters
{
	public sealed class GachaInfoResponseFormatter : IMessagePackFormatter<GachaInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
