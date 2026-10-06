namespace MessagePack.Formatters
{
	public sealed class ProfileInfoResponseFormatter : IMessagePackFormatter<ProfileInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProfileInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProfileInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
