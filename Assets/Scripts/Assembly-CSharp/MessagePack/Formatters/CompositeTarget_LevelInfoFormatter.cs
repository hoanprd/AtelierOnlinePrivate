namespace MessagePack.Formatters
{
	public sealed class CompositeTarget_LevelInfoFormatter : IMessagePackFormatter<CompositeTarget.LevelInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CompositeTarget.LevelInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CompositeTarget.LevelInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
