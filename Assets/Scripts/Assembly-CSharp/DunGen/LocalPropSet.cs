using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	public class LocalPropSet : RandomProp
	{
		private static readonly Dictionary<LocalPropSetCountMode, GetPropCountDelegate> GetCountMethods;

		public GameObjectChanceTable Props;

		public IntRange PropCount;

		public LocalPropSetCountMode CountMode;

		public AnimationCurve CountDepthCurve;

		static LocalPropSet()
		{
		}

		public override void Process(System.Random randomStream, Tile tile)
		{
		}

		private static int GetCountRandom(LocalPropSet propSet, System.Random randomStream, Tile tile)
		{
			return 0;
		}

		private static int GetCountDepthBased(LocalPropSet propSet, System.Random randomStream, Tile tile)
		{
			return 0;
		}

		private static int GetCountDepthMultiply(LocalPropSet propSet, System.Random randomStream, Tile tile)
		{
			return 0;
		}
	}
}
