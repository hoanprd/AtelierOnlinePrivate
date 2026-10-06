using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class CompositeResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly CompositeResolver Instance;

		private static bool isFreezed;

		private static IMessagePackFormatter[] formatters;

		private static IFormatterResolver[] resolvers;

		private CompositeResolver()
		{
		}

		public static void Register(params IFormatterResolver[] resolvers)
		{
		}

		public static void Register(params IMessagePackFormatter[] formatters)
		{
		}

		public static void Register(IMessagePackFormatter[] formatters, IFormatterResolver[] resolvers)
		{
		}

		public static void RegisterAndSetAsDefault(params IFormatterResolver[] resolvers)
		{
		}

		public static void RegisterAndSetAsDefault(params IMessagePackFormatter[] formatters)
		{
		}

		public static void RegisterAndSetAsDefault(IMessagePackFormatter[] formatters, IFormatterResolver[] resolvers)
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
