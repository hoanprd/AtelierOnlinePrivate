namespace MessagePack.Formatters
{
	public sealed class HomeEnter_LoginBonusFormatter : IMessagePackFormatter<HomeEnter.LoginBonus>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.LoginBonus value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.LoginBonus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
