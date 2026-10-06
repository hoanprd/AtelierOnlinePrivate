using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class ColorFormatter : IMessagePackFormatter<Color>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Color value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Color Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Color);
		}
	}
}
