using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class BoundsFormatter : IMessagePackFormatter<Bounds>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Bounds value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Bounds Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Bounds);
		}
	}
}
