using System;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public class Door : MonoBehaviour
	{
		public delegate void DoorStateChangedDelegate(Door door, bool isOpen);

		[HideInInspector]
		public Dungeon Dungeon;

		[HideInInspector]
		public Doorway DoorwayA;

		[HideInInspector]
		public Doorway DoorwayB;

		[HideInInspector]
		public Tile TileA;

		[HideInInspector]
		public Tile TileB;

		private DoorStateChangedDelegate OnDoorStateChanged__BackingField;

		[SerializeField]
		private bool isOpen;

		public virtual bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event DoorStateChangedDelegate OnDoorStateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public void SetDoorState(bool isOpen)
		{
		}
	}
}
