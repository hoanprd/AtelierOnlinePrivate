namespace MessagePack.Formatters
{
	public sealed class HomeEnter_LoginBonusResponseFormatter : IMessagePackFormatter<HomeEnter.LoginBonusResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.LoginBonusResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.LoginBonusResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
