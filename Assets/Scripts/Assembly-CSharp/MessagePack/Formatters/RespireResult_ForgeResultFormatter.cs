namespace MessagePack.Formatters
{
	public sealed class RespireResult_ForgeResultFormatter : IMessagePackFormatter<RespireResult.ForgeResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RespireResult.ForgeResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RespireResult.ForgeResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
