using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class PrimitiveObjectResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static IFormatterResolver Instance;

		private PrimitiveObjectResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
