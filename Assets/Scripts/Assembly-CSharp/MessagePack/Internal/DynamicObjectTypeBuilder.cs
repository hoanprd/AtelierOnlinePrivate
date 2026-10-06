using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace MessagePack.Internal
{
	internal static class DynamicObjectTypeBuilder
	{
		internal static class MessagePackBinaryTypeInfo
		{
			public static TypeInfo TypeInfo;

			public static readonly MethodInfo GetEncodedStringBytes;

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

			public static MethodInfo ReadStringSegment;

			public static MethodInfo IsNil;

			public static MethodInfo ReadNextBlock;

			public static MethodInfo WriteStringUnsafe;

			public static MethodInfo WriteStringBytes;

			public static MethodInfo WriteRaw;

			public static MethodInfo ReadArrayHeader;

			public static MethodInfo ReadMapHeader;

			static MessagePackBinaryTypeInfo()
			{
			}
		}

		internal static class EmitInfo
		{
			internal static class MessagePackFormatterAttr
			{
				internal static readonly MethodInfo FormatterType;

				internal static readonly MethodInfo Arguments;
			}

			public static readonly MethodInfo GetTypeFromHandle;

			public static readonly MethodInfo TypeGetProperty;

			public static readonly MethodInfo TypeGetField;

			public static readonly MethodInfo GetCustomAttributeMessagePackFormatterAttribute;

			public static readonly MethodInfo ActivatorCreateInstance;
		}

		private class DeserializeInfo
		{
			public ObjectSerializationInfo.EmittableMember MemberInfo { get; set; }

			public LocalBuilder LocalField { get; set; }

			public Label SwitchLabel { get; set; }
		}

		private static readonly Regex SubtractFullNameRegex;

		private static int nameSequence;

		private static HashSet<Type> ignoreTypes;

		private static readonly Type refByte;

		private static readonly Type refInt;

		private static readonly MethodInfo getFormatterWithVerify;

		private static readonly Func<Type, MethodInfo> getSerialize;

		private static readonly Func<Type, MethodInfo> getDeserialize;

		private static readonly ConstructorInfo invalidOperationExceptionConstructor;

		private static readonly MethodInfo onBeforeSerialize;

		private static readonly MethodInfo onAfterDeserialize;

		private static readonly ConstructorInfo objectCtor;

		public static TypeInfo BuildType(DynamicAssembly assembly, Type type, bool forceStringKey, bool contractless)
		{
			return null;
		}

		public static object BuildFormatterToDynamicMethod(Type type, bool forceStringKey, bool contractless, bool allowPrivate)
		{
			return null;
		}

		private static void BuildConstructor(Type type, ObjectSerializationInfo info, ConstructorInfo method, FieldBuilder stringByteKeysField, ILGenerator il)
		{
		}

		private static Dictionary<ObjectSerializationInfo.EmittableMember, FieldInfo> BuildCustomFormatterField(TypeBuilder builder, ObjectSerializationInfo info, ILGenerator il)
		{
			return null;
		}

		private static void BuildSerialize(Type type, ObjectSerializationInfo info, ILGenerator il, Action emitStringByteKeys, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, int firstArgIndex)
		{
		}

		private static void EmitOffsetPlusEqual(ILGenerator il, Action loadEmit, Action emit, ArgumentField argBytes, ArgumentField argOffset)
		{
		}

		private static void EmitSerializeValue(ILGenerator il, TypeInfo type, ObjectSerializationInfo.EmittableMember member, int index, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, ArgumentField argBytes, ArgumentField argOffset, ArgumentField argValue, ArgumentField argResolver)
		{
		}

		private static void BuildDeserialize(Type type, ObjectSerializationInfo info, ILGenerator il, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, int firstArgIndex)
		{
		}

		private static void EmitOffsetPlusReadSize(ILGenerator il, ArgumentField argOffset, ArgumentField argReadSize)
		{
		}

		private static void EmitDeserializeValue(ILGenerator il, DeserializeInfo info, int index, Func<int, ObjectSerializationInfo.EmittableMember, Action> tryEmitLoadCustomFormatter, ArgumentField argBytes, ArgumentField argOffset, ArgumentField argResolver, ArgumentField argReadSize)
		{
		}

		private static LocalBuilder EmitNewObject(ILGenerator il, Type type, ObjectSerializationInfo info, DeserializeInfo[] members)
		{
			return null;
		}

		private static bool IsOptimizeTargetType(Type type)
		{
			return false;
		}
	}
}
