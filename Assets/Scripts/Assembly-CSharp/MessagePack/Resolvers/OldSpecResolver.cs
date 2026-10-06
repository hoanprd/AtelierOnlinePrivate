using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class OldSpecResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly IFormatterResolver Instance;

		private OldSpecResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
