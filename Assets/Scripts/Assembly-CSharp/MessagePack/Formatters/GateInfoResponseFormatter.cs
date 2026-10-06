namespace MessagePack.Formatters
{
	public sealed class GateInfoResponseFormatter : IMessagePackFormatter<GateInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GateInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GateInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
