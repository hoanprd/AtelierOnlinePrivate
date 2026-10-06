namespace MessagePack.Formatters
{
	public sealed class HomeEnter_LoginBonusSheetInfoFormatter : IMessagePackFormatter<HomeEnter.LoginBonusSheetInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.LoginBonusSheetInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.LoginBonusSheetInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
