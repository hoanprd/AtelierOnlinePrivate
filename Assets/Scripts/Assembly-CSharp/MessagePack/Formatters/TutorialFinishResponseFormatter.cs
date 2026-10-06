namespace MessagePack.Formatters
{
	public sealed class TutorialFinishResponseFormatter : IMessagePackFormatter<TutorialFinishResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TutorialFinishResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TutorialFinishResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
