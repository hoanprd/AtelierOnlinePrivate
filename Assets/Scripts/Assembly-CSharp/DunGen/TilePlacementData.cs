using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class TilePlacementData
	{
		public List<Doorway> UsedDoorways;

		public List<Doorway> UnusedDoorways;

		public List<Doorway> AllDoorways;

		[SerializeField]
		private int pathDepth;

		[SerializeField]
		private float normalizedPathDepth;

		[SerializeField]
		private int branchDepth;

		[SerializeField]
		private float normalizedBranchDepth;

		[SerializeField]
		private bool isOnMainPath;

		[SerializeField]
		private Bounds bounds;

		[SerializeField]
		private GameObject root;

		[SerializeField]
		private Tile tile;

		public GameObject Root
		{
			get
			{
				return null;
			}
		}

		public Tile Tile
		{
			get
			{
				return null;
			}
		}

		public int PathDepth
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public float NormalizedPathDepth
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public int BranchDepth
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public float NormalizedBranchDepth
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public bool IsOnMainPath
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public Bounds Bounds
		{
			get
			{
				return default(Bounds);
			}
			internal set
			{
			}
		}

		public int Depth
		{
			get
			{
				return 0;
			}
		}

		public float NormalizedDepth
		{
			get
			{
				return 0f;
			}
		}

		internal TilePlacementData(PreProcessTileData preProcessData, bool isOnMainPath, DungeonArchetype archetype, TileSet tileSet, Dungeon dungeon)
		{
		}

		public void ProcessDoorways(System.Random randomStream)
		{
		}

		public void RecalculateBounds(bool ignoreSpriteRenderers, Vector3 upVector)
		{
		}

		public Doorway PickRandomDoorway(System.Random randomStream, bool mustBeAvailable, DungeonArchetype archetype)
		{
			return null;
		}

		public int PickRandomDoorwayIndex(System.Random randomStream, bool mustBeAvailable)
		{
			return 0;
		}
	}
}
