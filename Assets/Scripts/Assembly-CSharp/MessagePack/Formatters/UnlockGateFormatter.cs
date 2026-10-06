namespace MessagePack.Formatters
{
	public sealed class UnlockGateFormatter : IMessagePackFormatter<UnlockGate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, UnlockGate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public UnlockGate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
