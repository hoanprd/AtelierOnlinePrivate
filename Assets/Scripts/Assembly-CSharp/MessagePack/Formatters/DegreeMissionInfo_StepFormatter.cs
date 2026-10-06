namespace MessagePack.Formatters
{
	public sealed class DegreeMissionInfo_StepFormatter : IMessagePackFormatter<DegreeMissionInfo.Step>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DegreeMissionInfo.Step value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DegreeMissionInfo.Step Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
