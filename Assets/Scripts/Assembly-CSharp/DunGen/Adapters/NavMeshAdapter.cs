using System.Runtime.InteropServices;
using UnityEngine;

namespace DunGen.Adapters
{
	public abstract class NavMeshAdapter : MonoBehaviour
	{
		[StructLayout((LayoutKind)0, Size = 16)]
		public struct NavMeshGenerationProgress
		{
			public float Percentage;

			public string Description;
		}

		public delegate void OnNavMeshGenerationProgress(NavMeshGenerationProgress progress);

		public OnNavMeshGenerationProgress OnProgress;

		public abstract void Generate(Dungeon dungeon);
	}
}
