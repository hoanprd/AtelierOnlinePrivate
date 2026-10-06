namespace MessagePack.Formatters
{
	public sealed class RespireResult_ForgeResultEXPFormatter : IMessagePackFormatter<RespireResult.ForgeResultEXP>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RespireResult.ForgeResultEXP value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RespireResult.ForgeResultEXP Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
