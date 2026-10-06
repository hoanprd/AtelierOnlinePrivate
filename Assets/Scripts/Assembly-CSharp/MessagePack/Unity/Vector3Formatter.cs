using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class Vector3Formatter : IMessagePackFormatter<Vector3>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Vector3 value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Vector3 Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Vector3);
		}
	}
}
