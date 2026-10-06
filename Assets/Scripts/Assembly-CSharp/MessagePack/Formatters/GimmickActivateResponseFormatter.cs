namespace MessagePack.Formatters
{
	public sealed class GimmickActivateResponseFormatter : IMessagePackFormatter<GimmickActivateResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GimmickActivateResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GimmickActivateResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
