namespace MessagePack.Formatters
{
	public sealed class ShopGachaShow_CharaFormatter : IMessagePackFormatter<ShopGachaShow.Chara>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow.Chara value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow.Chara Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
