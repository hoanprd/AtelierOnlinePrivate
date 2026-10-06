using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen.Graph
{
	[Serializable]
	public class DungeonFlow : ScriptableObject
	{
		public IntRange Length;

		public List<int> GlobalPropGroupIDs;

		public List<IntRange> GlobalPropRanges;

		public KeyManager KeyManager;

		public float DoorwayConnectionChance;

		public List<TileInjectionRule> TileInjectionRules;

		public List<GraphNode> Nodes;

		public List<GraphLine> Lines;

		public void Reset()
		{
		}

		public GraphLine GetLineAtDepth(float normalizedDepth)
		{
			return null;
		}

		public DungeonArchetype[] GetUsedArchetypes()
		{
			return null;
		}

		public TileSet[] GetUsedTileSets()
		{
			return null;
		}
	}
}
