namespace MessagePack.Formatters
{
	public sealed class eConditionTypeFormatter : IMessagePackFormatter<eConditionType>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, eConditionType value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public eConditionType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return eConditionType.None;
		}
	}
}
