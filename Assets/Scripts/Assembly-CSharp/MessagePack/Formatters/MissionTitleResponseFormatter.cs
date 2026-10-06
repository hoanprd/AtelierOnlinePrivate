namespace MessagePack.Formatters
{
	public sealed class MissionTitleResponseFormatter : IMessagePackFormatter<MissionTitleResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, MissionTitleResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public MissionTitleResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
