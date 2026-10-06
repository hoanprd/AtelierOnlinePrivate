using System;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class SerializableType
	{
		[SerializeField]
		private string typeName;

		public Type Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SerializableType()
		{
		}

		public SerializableType(Type type)
		{
		}

		public SerializableType(string assemblyQualifiedName)
		{
		}

		public static implicit operator Type(SerializableType serializableType)
		{
			return null;
		}

		public static implicit operator SerializableType(Type type)
		{
			return null;
		}
	}
}
