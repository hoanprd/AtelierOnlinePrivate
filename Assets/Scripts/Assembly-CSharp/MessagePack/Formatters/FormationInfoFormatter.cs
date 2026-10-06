namespace MessagePack.Formatters
{
	public sealed class FormationInfoFormatter : IMessagePackFormatter<FormationInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FormationInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FormationInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
