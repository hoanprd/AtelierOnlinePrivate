namespace MessagePack.Formatters
{
	public sealed class RpcLivingFormatter : IMessagePackFormatter<RpcLiving>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcLiving value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcLiving Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
