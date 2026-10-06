namespace MessagePack.Formatters
{
	public sealed class PotionResult_ParamFormatter : IMessagePackFormatter<PotionResult.Param>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PotionResult.Param value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PotionResult.Param Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
