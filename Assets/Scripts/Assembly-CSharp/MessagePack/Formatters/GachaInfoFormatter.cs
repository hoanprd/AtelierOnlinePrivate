namespace MessagePack.Formatters
{
	public sealed class GachaInfoFormatter : IMessagePackFormatter<GachaInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
