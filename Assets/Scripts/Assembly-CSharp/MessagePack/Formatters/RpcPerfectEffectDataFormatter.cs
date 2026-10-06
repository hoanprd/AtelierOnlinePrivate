namespace MessagePack.Formatters
{
	public sealed class RpcPerfectEffectDataFormatter : IMessagePackFormatter<RpcPerfectEffectData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcPerfectEffectData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcPerfectEffectData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
