namespace MessagePack.Formatters
{
	public sealed class GrowBlazeArtsMateria_StatusFormatter : IMessagePackFormatter<GrowBlazeArtsMateria.Status>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowBlazeArtsMateria.Status value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowBlazeArtsMateria.Status Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
