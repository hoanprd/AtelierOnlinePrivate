using System.Collections.Generic;

namespace System.Reflection
{
	public class TypeInfo
	{
		private readonly Type type;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public TypeAttributes Attributes
		{
			get
			{
				return TypeAttributes.NotPublic;
			}
		}

		public bool IsClass
		{
			get
			{
				return false;
			}
		}

		public bool IsPublic
		{
			get
			{
				return false;
			}
		}

		public bool IsInterface
		{
			get
			{
				return false;
			}
		}

		public bool IsAbstract
		{
			get
			{
				return false;
			}
		}

		public bool IsArray
		{
			get
			{
				return false;
			}
		}

		public bool IsValueType
		{
			get
			{
				return false;
			}
		}

		public bool IsNestedPublic
		{
			get
			{
				return false;
			}
		}

		public IEnumerable<ConstructorInfo> DeclaredConstructors
		{
			get
			{
				return null;
			}
		}

		public bool IsGenericType
		{
			get
			{
				return false;
			}
		}

		public Type[] GenericTypeArguments
		{
			get
			{
				return null;
			}
		}

		public bool IsEnum
		{
			get
			{
				return false;
			}
		}

		public Type[] ImplementedInterfaces
		{
			get
			{
				return null;
			}
		}

		public TypeInfo(Type type)
		{
		}

		public Type GetGenericTypeDefinition()
		{
			return null;
		}

		public Type AsType()
		{
			return null;
		}

		public MethodInfo GetDeclaredMethod(string name)
		{
			return null;
		}

		public IEnumerable<MethodInfo> GetDeclaredMethods(string name)
		{
			return null;
		}

		public bool IsConstructedGenericType()
		{
			return false;
		}

		public MethodInfo[] GetRuntimeMethods()
		{
			return null;
		}

		public bool IsAssignableFrom(TypeInfo c)
		{
			return false;
		}

		public PropertyInfo GetDeclaredProperty(string name)
		{
			return null;
		}

		public T GetCustomAttribute<T>(bool inherit = true) where T : Attribute
		{
			return null;
		}

		public IEnumerable<T> GetCustomAttributes<T>(bool inherit = true) where T : Attribute
		{
			return null;
		}
	}
}
