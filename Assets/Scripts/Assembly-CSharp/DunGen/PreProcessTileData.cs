using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	public sealed class PreProcessTileData
	{
		public readonly List<GameObject> ProxySockets;

		public readonly List<DoorwaySocketType> DoorwaySockets;

		public readonly List<Doorway> Doorways;

		public static Type ProBuilderObjectType { get; private set; }

		public GameObject Prefab { get; private set; }

		public GameObject Proxy { get; private set; }

		public PreProcessTileData(GameObject prefab, bool ignoreSpriteRendererBounds, Vector3 upVector)
		{
		}

		public bool ChooseRandomDoorway(System.Random random, DoorwaySocketType? socketGroupFilter, Vector3? allowedDirection, out int doorwayIndex, out Doorway doorway)
		{
			doorwayIndex = default(int);
			doorway = null;
			return false;
		}

		private void CalculateProxyBounds(bool ignoreSpriteRendererBounds, Vector3 upVector)
		{
		}

		private void GetAllDoorways()
		{
		}
	}
}
