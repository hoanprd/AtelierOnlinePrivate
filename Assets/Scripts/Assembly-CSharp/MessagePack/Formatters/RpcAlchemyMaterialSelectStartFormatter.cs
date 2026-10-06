namespace MessagePack.Formatters
{
	public sealed class RpcAlchemyMaterialSelectStartFormatter : IMessagePackFormatter<RpcAlchemyMaterialSelectStart>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcAlchemyMaterialSelectStart value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcAlchemyMaterialSelectStart Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
