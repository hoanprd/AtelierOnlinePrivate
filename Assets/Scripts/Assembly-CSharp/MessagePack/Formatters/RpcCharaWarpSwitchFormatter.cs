namespace MessagePack.Formatters
{
	public sealed class RpcCharaWarpSwitchFormatter : IMessagePackFormatter<RpcCharaWarpSwitch>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcCharaWarpSwitch value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcCharaWarpSwitch Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
