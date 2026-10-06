namespace MessagePack.Formatters
{
	public sealed class APIForgeQualitEnforcey_RequestFormatter : IMessagePackFormatter<APIForgeQualitEnforcey.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIForgeQualitEnforcey.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIForgeQualitEnforcey.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
