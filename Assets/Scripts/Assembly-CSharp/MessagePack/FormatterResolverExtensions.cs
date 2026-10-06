using System;
using MessagePack.Formatters;

namespace MessagePack
{
	public static class FormatterResolverExtensions
	{
		public static IMessagePackFormatter<T> GetFormatterWithVerify<T>(this IFormatterResolver resolver)
		{
			return null;
		}

		public static object GetFormatterDynamic(this IFormatterResolver resolver, Type type)
		{
			return null;
		}
	}
}
