namespace MessagePack.Formatters
{
	public sealed class HomeEnter_LoginBonusDailyInfoFormatter : IMessagePackFormatter<HomeEnter.LoginBonusDailyInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.LoginBonusDailyInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.LoginBonusDailyInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
