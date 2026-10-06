namespace MessagePack.Formatters
{
	public sealed class BattleResultCharaInfoFormatter : IMessagePackFormatter<BattleResultCharaInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleResultCharaInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleResultCharaInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
