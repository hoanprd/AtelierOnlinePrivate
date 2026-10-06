namespace MessagePack.Formatters
{
	public sealed class TutorialFinishFormatter : IMessagePackFormatter<TutorialFinish>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TutorialFinish value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TutorialFinish Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
