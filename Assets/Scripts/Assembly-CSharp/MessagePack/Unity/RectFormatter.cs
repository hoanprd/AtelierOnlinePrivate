using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class RectFormatter : IMessagePackFormatter<Rect>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Rect value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Rect Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Rect);
		}
	}
}
