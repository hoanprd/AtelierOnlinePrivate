namespace MessagePack.Formatters
{
	public sealed class UnlockAreaInfoFormatter : IMessagePackFormatter<UnlockAreaInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UnlockAreaInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UnlockAreaInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
