using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class KeyManager : ScriptableObject
	{
		[SerializeField]
		private List<Key> keys;

		public ReadOnlyCollection<Key> Keys { get; private set; }

		public Key CreateKey()
		{
			return null;
		}

		public void DeleteKey(int index)
		{
		}

		public Key GetKeyByID(int id)
		{
			return null;
		}

		public Key GetKeyByName(string name)
		{
			return null;
		}

		public bool RenameKey(int index, string newName)
		{
			return false;
		}

		public void ExposeKeyList()
		{
		}

		private int GetNextAvailableID()
		{
			return 0;
		}
	}
}
