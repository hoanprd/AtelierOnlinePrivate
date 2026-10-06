namespace MessagePack.Formatters
{
	public sealed class ShopGachaShow_BenefitFormatter : IMessagePackFormatter<ShopGachaShow.Benefit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow.Benefit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow.Benefit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
