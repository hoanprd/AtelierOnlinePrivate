namespace MessagePack.Formatters
{
	public sealed class APIEquipFavRegister_RequestFormatter : IMessagePackFormatter<APIEquipFavRegister.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIEquipFavRegister.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIEquipFavRegister.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
