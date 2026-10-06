using UnityEngine;

namespace DunGen
{
	public class RuntimeDungeon : MonoBehaviour
	{
		public DungeonGenerator Generator;

		public bool GenerateOnStart;

		public GameObject Root;

		protected virtual void Start()
		{
		}

		public void Generate()
		{
		}

		protected virtual void OnDungeonGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
		{
		}
	}
}
