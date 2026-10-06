using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DunGen.Adapters;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	public class Dungeon : MonoBehaviour
	{
		public bool DebugRender;

		public PortalCullingAdapter Culling;

		private readonly List<Tile> allTiles;

		private readonly List<Tile> mainPathTiles;

		private readonly List<Tile> branchPathTiles;

		private readonly List<GameObject> doors;

		private readonly List<DoorwayConnection> connections;

		public Bounds Bounds { get; protected set; }

		public DungeonFlow DungeonFlow { get; protected set; }

		public ReadOnlyCollection<Tile> AllTiles { get; private set; }

		public ReadOnlyCollection<Tile> MainPathTiles { get; private set; }

		public ReadOnlyCollection<Tile> BranchPathTiles { get; private set; }

		public ReadOnlyCollection<GameObject> Doors { get; private set; }

		public ReadOnlyCollection<DoorwayConnection> Connections { get; private set; }

		public DungeonGraph ConnectionGraph { get; private set; }

		internal void PreGenerateDungeon(DungeonGenerator dungeonGenerator)
		{
		}

		internal void PostGenerateDungeon(DungeonGenerator dungeonGenerator)
		{
		}

		public void Clear()
		{
		}

		public Doorway GetConnection(Doorway doorway)
		{
			return null;
		}

		internal void MakeConnection(Doorway a, Doorway b, System.Random randomStream)
		{
		}

		internal void AddTile(Tile tile)
		{
		}

		internal void RemoveTile(Tile tile)
		{
		}

		internal void RemoveLastConnection()
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void DebugDraw()
		{
		}
	}
}
