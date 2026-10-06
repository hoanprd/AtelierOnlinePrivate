namespace MessagePack.Formatters
{
	public sealed class HomeEnter_GachaBadgeInfoFormatter : IMessagePackFormatter<HomeEnter.GachaBadgeInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.GachaBadgeInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.GachaBadgeInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
