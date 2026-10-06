using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace MessagePack.Internal
{
	internal class ObjectSerializationInfo
	{
		public class EmittableMember
		{
			public bool IsProperty
			{
				get
				{
					return false;
				}
			}

			public bool IsField
			{
				get
				{
					return false;
				}
			}

			public bool IsWritable { get; set; }

			public bool IsReadable { get; set; }

			public int IntKey { get; set; }

			public string StringKey { get; set; }

			public Type Type
			{
				get
				{
					return null;
				}
			}

			public FieldInfo FieldInfo { get; set; }

			public PropertyInfo PropertyInfo { get; set; }

			public string Name
			{
				get
				{
					return null;
				}
			}

			public bool IsValueType
			{
				get
				{
					return false;
				}
			}

			public MessagePackFormatterAttribute GetMessagePackFormatterAttribtue()
			{
				return null;
			}

			public void EmitLoadValue(ILGenerator il)
			{
			}

			public void EmitStoreValue(ILGenerator il)
			{
			}
		}

		public Type Type { get; set; }

		public bool IsIntKey { get; set; }

		public bool IsStringKey
		{
			get
			{
				return false;
			}
		}

		public bool IsClass { get; set; }

		public bool IsStruct
		{
			get
			{
				return false;
			}
		}

		public ConstructorInfo BestmatchConstructor { get; set; }

		public EmittableMember[] ConstructorParameters { get; set; }

		public EmittableMember[] Members { get; set; }

		private ObjectSerializationInfo()
		{
		}

		public static ObjectSerializationInfo CreateOrNull(Type type, bool forceStringKey, bool contractless, bool allowPrivate)
		{
			return null;
		}

		private static bool TryGetNextConstructor(IEnumerator<ConstructorInfo> ctorEnumerator, ref ConstructorInfo ctor)
		{
			return false;
		}
	}
}
