using System.Reflection.Emit;

namespace System.Reflection
{
	public static class ReflectionExtensions
	{
		public static TypeInfo GetTypeInfo(this Type type)
		{
			return null;
		}

		public static TypeInfo CreateTypeInfo(this TypeBuilder type)
		{
			return null;
		}

		public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] types)
		{
			return null;
		}

		public static MethodInfo GetRuntimeMethod(this Type type, string name)
		{
			return null;
		}

		public static MethodInfo[] GetRuntimeMethods(this Type type)
		{
			return null;
		}

		public static PropertyInfo GetRuntimeProperty(this Type type, string name)
		{
			return null;
		}

		public static PropertyInfo[] GetRuntimeProperties(this Type type)
		{
			return null;
		}

		public static FieldInfo GetRuntimeField(this Type type, string name)
		{
			return null;
		}

		public static FieldInfo[] GetRuntimeFields(this Type type)
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this FieldInfo type, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this PropertyInfo type, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this ConstructorInfo type, bool inherit) where T : Attribute
		{
			return null;
		}
	}
}
