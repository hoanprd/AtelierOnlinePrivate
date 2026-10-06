using MessagePack.Formatters;

namespace MessagePack.Internal
{
	internal class AnonymousSerializableFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter
	{
		private readonly byte[][] stringByteKeysField;

		private readonly object[] serializeCustomFormatters;

		private readonly object[] deserializeCustomFormatters;

		private readonly AnonymousSerializeFunc<T> serialize;

		private readonly AnonymousDeserializeFunc<T> deserialize;

		public AnonymousSerializableFormatter(byte[][] stringByteKeysField, object[] serializeCustomFormatters, object[] deserializeCustomFormatters, AnonymousSerializeFunc<T> serialize, AnonymousDeserializeFunc<T> deserialize)
		{
		}

		public int Serialize(ref byte[] bytes, int offset, T value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public T Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(T);
		}
	}
}
