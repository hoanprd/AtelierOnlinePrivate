using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	public class DemoTileInjector : MonoBehaviour
	{
		public RuntimeDungeon RuntimeDungeon;

		public TileSet TileSet;

		public float NormalizedPathDepth;

		public float NormalizedBranchDepth;

		public bool IsOnMainPath;

		private void Awake()
		{
		}

		private void InjectTiles(System.Random randomStream, ref List<InjectedTile> tilesToInject)
		{
		}
	}
}
