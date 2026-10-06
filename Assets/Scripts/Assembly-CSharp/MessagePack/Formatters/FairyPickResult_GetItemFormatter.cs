namespace MessagePack.Formatters
{
	public sealed class FairyPickResult_GetItemFormatter : IMessagePackFormatter<FairyPickResult.GetItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FairyPickResult.GetItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FairyPickResult.GetItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
