using System.Reflection;

namespace MessagePack.Internal
{
	internal static class ReflectionExtensions
	{
		public static bool IsNullable(this TypeInfo type)
		{
			return false;
		}

		public static bool IsPublic(this TypeInfo type)
		{
			return false;
		}

		public static bool IsAnonymous(this TypeInfo type)
		{
			return false;
		}

		public static bool IsIndexer(this PropertyInfo propertyInfo)
		{
			return false;
		}
	}
}
