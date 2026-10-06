namespace MessagePack.Formatters
{
	public sealed class Restore_GetItemFormatter : IMessagePackFormatter<Restore.GetItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Restore.GetItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Restore.GetItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
