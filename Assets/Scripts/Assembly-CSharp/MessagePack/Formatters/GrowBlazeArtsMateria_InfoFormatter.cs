namespace MessagePack.Formatters
{
	public sealed class GrowBlazeArtsMateria_InfoFormatter : IMessagePackFormatter<GrowBlazeArtsMateria.Info>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowBlazeArtsMateria.Info value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowBlazeArtsMateria.Info Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
