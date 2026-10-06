namespace MessagePack.Formatters
{
	public sealed class GrowBlazeArtsMateriaFormatter : IMessagePackFormatter<GrowBlazeArtsMateria>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowBlazeArtsMateria value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowBlazeArtsMateria Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
