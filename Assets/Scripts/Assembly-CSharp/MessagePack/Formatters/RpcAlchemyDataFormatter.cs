namespace MessagePack.Formatters
{
	public sealed class RpcAlchemyDataFormatter : IMessagePackFormatter<RpcAlchemyData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcAlchemyData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcAlchemyData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
