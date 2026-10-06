using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DunGen
{
	public static class UnityUtil
	{
		public static void Destroy(Object obj)
		{
		}

		public static string GetUniqueName(string name, IEnumerable<string> usedNames)
		{
			return null;
		}

		public static Bounds CombineBounds(params Bounds[] bounds)
		{
			return default(Bounds);
		}

		public static Bounds CalculateObjectBounds(GameObject obj, bool includeInactive, bool ignoreSpriteRenderers, bool ignoreTriggerColliders = true)
		{
			return default(Bounds);
		}

		public static void PositionObjectBySocket(GameObject objectA, GameObject socketA, GameObject socketB)
		{
		}

		public static void PositionObjectBySocket(Transform objectA, Transform socketA, Transform socketB)
		{
		}

		public static Vector3 GetCardinalDirection(Vector3 direction, out float magnitude)
		{
			magnitude = default(float);
			return default(Vector3);
		}

		public static Vector3 VectorAbs(Vector3 vector)
		{
			return default(Vector3);
		}

		public static void SetVector3Masked(ref Vector3 input, Vector3 value, Vector3 mask)
		{
		}

		public static Bounds CondenseBounds(Bounds bounds, IEnumerable<Doorway> doorways)
		{
			return default(Bounds);
		}

		[DebuggerHidden]
		public static IEnumerable<T> GetComponentsInParents<T>(GameObject obj, bool includeInactive = false) where T : Component
		{
			return null;
		}

		public static T GetComponentInParents<T>(GameObject obj, bool includeInactive = false) where T : Component
		{
			return null;
		}
	}
}
