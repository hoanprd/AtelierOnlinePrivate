namespace MessagePack.Formatters
{
	public sealed class GrowBlazeArtsMateriaResponseFormatter : IMessagePackFormatter<GrowBlazeArtsMateriaResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowBlazeArtsMateriaResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowBlazeArtsMateriaResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
