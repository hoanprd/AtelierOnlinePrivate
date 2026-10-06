using System;

namespace MessagePack
{
	public class MessagePackFormatterAttribute : Attribute
	{
		public Type FormatterType { get; private set; }

		public object[] Arguments { get; private set; }

		public MessagePackFormatterAttribute(Type formatterType)
		{
		}

		public MessagePackFormatterAttribute(Type formatterType, params object[] arguments)
		{
		}
	}
}
