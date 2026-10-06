namespace MessagePack.Formatters
{
	public sealed class TutorialStatusFormatter : IMessagePackFormatter<TutorialStatus>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TutorialStatus value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TutorialStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
