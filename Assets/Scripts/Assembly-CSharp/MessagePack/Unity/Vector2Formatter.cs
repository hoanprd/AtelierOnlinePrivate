using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class Vector2Formatter : IMessagePackFormatter<Vector2>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Vector2 value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Vector2 Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Vector2);
		}
	}
}
