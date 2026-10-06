namespace MessagePack.Formatters
{
	public sealed class PopupInfo_ButtonInfoFormatter : IMessagePackFormatter<PopupInfo.ButtonInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PopupInfo.ButtonInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PopupInfo.ButtonInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
