namespace MessagePack.Formatters
{
	public sealed class RpcRequestEffectDataFormatter : IMessagePackFormatter<RpcRequestEffectData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRequestEffectData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRequestEffectData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
