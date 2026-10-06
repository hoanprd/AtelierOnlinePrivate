using System;

namespace DunGen
{
	public class RandomPrefab : RandomProp
	{
		public GameObjectChanceTable Props;

		public bool ZeroPosition;

		public bool ZeroRotation;

		public override void Process(Random randomStream, Tile tile)
		{
		}
	}
}
