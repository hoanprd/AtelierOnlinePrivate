using MessagePack.Formatters;
using MessagePack.Internal;

namespace MessagePack.Resolvers
{
	public sealed class DynamicContractlessObjectResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly DynamicContractlessObjectResolver Instance;

		private const string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";

		private static readonly DynamicAssembly assembly;

		private DynamicContractlessObjectResolver()
		{
		}

		static DynamicContractlessObjectResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
