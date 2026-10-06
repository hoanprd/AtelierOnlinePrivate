using System;

namespace DunGen.Adapters
{
	[Serializable]
	public abstract class PortalCullingAdapter
	{
		public virtual void Clear()
		{
		}

		public abstract PortalCullingAdapter Clone();

		public abstract void PrepareForCulling(DungeonGenerator generator, Dungeon dungeon);

		public abstract void ChangeDoorState(Door door, bool isOpen);

		public virtual void OnInspectorGUI(DungeonGenerator generator, bool isRuntimeDungeon)
		{
		}
	}
}
