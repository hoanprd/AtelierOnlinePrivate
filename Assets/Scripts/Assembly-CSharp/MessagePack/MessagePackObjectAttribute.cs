using System;

namespace MessagePack
{
	public class MessagePackObjectAttribute : Attribute
	{
		public bool KeyAsPropertyName { get; private set; }

		public MessagePackObjectAttribute(bool keyAsPropertyName = false)
		{
		}
	}
}
