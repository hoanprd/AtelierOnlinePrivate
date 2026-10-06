using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class DungeonArchetype : ScriptableObject
	{
		public List<TileSet> TileSets;

		public List<TileSet> BranchCapTileSets;

		public BranchCapType BranchCapType;

		public IntRange BranchingDepth;

		public IntRange BranchCount;

		public float StraightenChance;

		public bool GetHasValidBranchCapTiles()
		{
			return false;
		}
	}
}
