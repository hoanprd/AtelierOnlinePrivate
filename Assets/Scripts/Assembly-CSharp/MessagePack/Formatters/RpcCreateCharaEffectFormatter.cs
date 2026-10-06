namespace MessagePack.Formatters
{
	public sealed class RpcCreateCharaEffectFormatter : IMessagePackFormatter<RpcCreateCharaEffect>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcCreateCharaEffect value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcCreateCharaEffect Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
