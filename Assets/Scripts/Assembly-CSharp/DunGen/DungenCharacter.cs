using UnityEngine;

namespace DunGen
{
	public class DungenCharacter : MonoBehaviour
	{
		private CharacterTileChangedEvent OnTileChanged__BackingField;

		[SerializeField]
		[HideInInspector]
		private Tile currentTile;

		public Tile CurrentTile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event CharacterTileChangedEvent OnTileChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal void ForceRecheckTile()
		{
		}

		protected virtual void OnTileChangedEvent(Tile previousTile, Tile newTile)
		{
		}

		internal void HandleTileChange(Tile newTile)
		{
		}
	}
}
