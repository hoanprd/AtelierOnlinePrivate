using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace MessagePack.Resolvers
{
	public sealed class DynamicUnionResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		private static class MessagePackBinaryTypeInfo
		{
			public static TypeInfo TypeInfo;

			public static MethodInfo WriteFixedMapHeaderUnsafe;

			public static MethodInfo WriteFixedArrayHeaderUnsafe;

			public static MethodInfo WriteMapHeader;

			public static MethodInfo WriteArrayHeader;

			public static MethodInfo WritePositiveFixedIntUnsafe;

			public static MethodInfo WriteInt32;

			public static MethodInfo WriteBytes;

			public static MethodInfo WriteNil;

			public static MethodInfo ReadBytes;

			public static MethodInfo ReadInt32;

			public static MethodInfo ReadString;

			public static MethodInfo IsNil;

			public static MethodInfo ReadNextBlock;

			public static MethodInfo WriteStringUnsafe;

			public static MethodInfo ReadArrayHeader;

			public static MethodInfo ReadMapHeader;

			static MessagePackBinaryTypeInfo()
			{
			}
		}

		public static readonly DynamicUnionResolver Instance;

		private const string ModuleName = "MessagePack.Resolvers.DynamicUnionResolver";

		private static readonly DynamicAssembly assembly;

		private static readonly Regex SubtractFullNameRegex;

		private static int nameSequence;

		private static readonly Type refByte;

		private static readonly Type refInt;

		private static readonly Type refKvp;

		private static readonly MethodInfo getFormatterWithVerify;

		private static readonly Func<Type, MethodInfo> getSerialize;

		private static readonly Func<Type, MethodInfo> getDeserialize;

		private static readonly FieldInfo runtimeTypeHandleEqualityComparer;

		private static readonly ConstructorInfo intIntKeyValuePairConstructor;

		private static readonly ConstructorInfo typeMapDictionaryConstructor;

		private static readonly MethodInfo typeMapDictionaryAdd;

		private static readonly MethodInfo typeMapDictionaryTryGetValue;

		private static readonly ConstructorInfo keyMapDictionaryConstructor;

		private static readonly MethodInfo keyMapDictionaryAdd;

		private static readonly MethodInfo keyMapDictionaryTryGetValue;

		private static readonly MethodInfo objectGetType;

		private static readonly MethodInfo getTypeHandle;

		private static readonly MethodInfo intIntKeyValuePairGetKey;

		private static readonly MethodInfo intIntKeyValuePairGetValue;

		private static readonly ConstructorInfo invalidOperationExceptionConstructor;

		private static readonly ConstructorInfo objectCtor;

		private DynamicUnionResolver()
		{
		}

		static DynamicUnionResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}

		private static TypeInfo BuildType(Type type)
		{
			return null;
		}

		private static void BuildConstructor(Type type, UnionAttribute[] infos, ConstructorInfo method, FieldBuilder typeToKeyAndJumpMap, FieldBuilder keyToJumpMap, ILGenerator il)
		{
		}

		private static void BuildSerialize(Type type, UnionAttribute[] infos, MethodBuilder method, FieldBuilder typeToKeyAndJumpMap, ILGenerator il)
		{
		}

		private static void EmitOffsetPlusEqual(ILGenerator il, Action loadEmit, Action emit)
		{
		}

		private static void BuildDeserialize(Type type, UnionAttribute[] infos, MethodBuilder method, FieldBuilder keyToJumpMap, ILGenerator il)
		{
		}

		private static bool IsZeroStartSequential(UnionAttribute[] infos)
		{
			return false;
		}

		private static void EmitOffsetPlusReadSize(ILGenerator il)
		{
		}
	}
}
