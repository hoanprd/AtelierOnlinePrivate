using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class Vector4Formatter : IMessagePackFormatter<Vector4>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Vector4 value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Vector4 Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Vector4);
		}
	}
}
