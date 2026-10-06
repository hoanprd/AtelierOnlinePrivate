using System.Collections.Generic;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	public class Tile : MonoBehaviour
	{
		public bool AllowRotation;

		public bool AllowImmediateRepeats;

		[SerializeField]
		private TilePlacementData placement;

		[SerializeField]
		private bool isVisible;

		[SerializeField]
		private DungeonArchetype archetype;

		[SerializeField]
		private TileSet tileSet;

		[SerializeField]
		private FlowNodeReference node;

		[SerializeField]
		private FlowLineReference line;

		public TilePlacementData Placement
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public DungeonArchetype Archetype
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public TileSet TileSet
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public GraphNode Node
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public GraphLine Line
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Dungeon Dungeon { get; internal set; }

		public bool IsVisible
		{
			get
			{
				return false;
			}
		}

		internal void AddTriggerVolume()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public IEnumerable<Tile> GetAdjactedTiles()
		{
			return null;
		}

		public bool IsAdjacentTo(Tile other)
		{
			return false;
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void SetVisibility(bool isVisible)
		{
		}
	}
}
