using MessagePack.Formatters;
using UnityEngine;

namespace MessagePack.Unity
{
	public sealed class QuaternionFormatter : IMessagePackFormatter<Quaternion>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Quaternion value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Quaternion Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Quaternion);
		}
	}
}
