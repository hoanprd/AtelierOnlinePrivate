namespace MessagePack.Formatters
{
	public class NilFormatter : IMessagePackFormatter<Nil>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<Nil> Instance;

		private NilFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, Nil value, IFormatterResolver typeResolver)
		{
			return 0;
		}

		public Nil Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize)
		{
			readSize = default(int);
			return default(Nil);
		}
	}
}
