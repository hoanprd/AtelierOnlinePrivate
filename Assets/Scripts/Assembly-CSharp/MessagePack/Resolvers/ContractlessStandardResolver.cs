using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class ContractlessStandardResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly IFormatterResolver Instance;

		private ContractlessStandardResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
