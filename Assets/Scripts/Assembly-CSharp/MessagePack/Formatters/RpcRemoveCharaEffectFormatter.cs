namespace MessagePack.Formatters
{
	public sealed class RpcRemoveCharaEffectFormatter : IMessagePackFormatter<RpcRemoveCharaEffect>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRemoveCharaEffect value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRemoveCharaEffect Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
