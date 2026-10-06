using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	public class Doorway : MonoBehaviour
	{
		public DoorwaySocketType SocketGroup;

		public int DoorPrefabPriority;

		public List<GameObject> DoorPrefabs;

		public List<GameObject> BlockerPrefabs;

		public bool AvoidRotatingDoorPrefab;

		public bool AvoidRotatingBlockerPrefab;

		public List<GameObject> AddWhenInUse;

		public List<GameObject> AddWhenNotInUse;

		public Vector2 Size;

		public int? LockID;

		[SerializeField]
		[HideInInspector]
		private GameObject doorPrefab;

		[SerializeField]
		private Tile tile;

		[SerializeField]
		private Doorway connectedDoorway;

		[SerializeField]
		private bool hideConditionalObjects;

		internal bool placedByGenerator;

		public Tile Tile
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool IsLocked
		{
			get
			{
				return false;
			}
		}

		public bool HasDoorPrefab
		{
			get
			{
				return false;
			}
		}

		public GameObject UsedDoorPrefab
		{
			get
			{
				return null;
			}
		}

		public Dungeon Dungeon { get; internal set; }

		public Doorway ConnectedDoorway
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool HideConditionalObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnDrawGizmos()
		{
		}

		internal void SetUsedPrefab(GameObject doorPrefab)
		{
		}

		internal void RemoveUsedPrefab()
		{
		}

		internal void DebugDraw()
		{
		}
	}
}
