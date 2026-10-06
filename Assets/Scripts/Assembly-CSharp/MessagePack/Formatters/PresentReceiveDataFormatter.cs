namespace MessagePack.Formatters
{
	public sealed class PresentReceiveDataFormatter : IMessagePackFormatter<PresentReceiveData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PresentReceiveData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PresentReceiveData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
