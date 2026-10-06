using System;

namespace MessagePack
{
	public class KeyAttribute : Attribute
	{
		public int? IntKey { get; private set; }

		public string StringKey { get; private set; }

		public KeyAttribute(int x)
		{
		}

		public KeyAttribute(string x)
		{
		}
	}
}
