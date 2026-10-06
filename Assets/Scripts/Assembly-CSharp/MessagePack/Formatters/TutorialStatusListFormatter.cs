namespace MessagePack.Formatters
{
	public sealed class TutorialStatusListFormatter : IMessagePackFormatter<TutorialStatusList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TutorialStatusList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TutorialStatusList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
