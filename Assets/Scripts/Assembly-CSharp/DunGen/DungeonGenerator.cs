using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DunGen.Adapters;
using DunGen.Analysis;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public class DungeonGenerator
	{
		public int Seed;

		public bool ShouldRandomizeSeed;

		public int MaxAttemptCount;

		public bool IgnoreSpriteBounds;

		public Vector3 UpVector;

		public bool OverrideAllowImmediateRepeats;

		public bool AllowImmediateRepeats;

		public bool OverrideAllowTileRotation;

		public bool AllowTileRotation;

		public bool DebugRender;

		public bool AllowBacktracking;

		public float LengthMultiplier;

		public bool UseLegacyWeightCombineMethod;

		public bool PlaceTileTriggers;

		public int TileTriggerLayer;

		public GameObject Root;

		public DungeonFlow DungeonFlow;

		private GenerationStatusDelegate OnGenerationStatusChanged__BackingField;

		private TileInjectionDelegate TileInjectionMethods__BackingField;

		protected int retryCount;

		protected int roomRetryCount;

		protected Dungeon currentDungeon;

		protected readonly Dictionary<TilePlacementResult, int> tilePlacementResultCounters;

		protected readonly List<PreProcessTileData> preProcessData;

		protected readonly List<GameObject> useableTiles;

		protected int targetLength;

		protected List<InjectedTile> tilesPendingInjection;

		private int nextNodeIndex;

		private DungeonArchetype currentArchetype;

		private GraphLine previousLineSegment;

		public bool isAnalysis;

		private GameObject lastTilePrefabUsed;

		private List<Doorway> allDoorways;

		private Dungeon appendedToDungeon;

		private bool allowAppendedDungeonIntersection;

		private Doorway appendedToDoorway;

		public SerializableType PortalCullingAdapterClass;

		public PortalCullingAdapter Culling;

		public bool IsPortalCullingEnabled;

		public Light DirShadowCaster;

		public float ExtraBounds;

		public bool CullEachChild;

		public System.Random RandomStream { get; protected set; }

		public GenerationStatus Status { get; private set; }

		public GenerationStats GenerationStats { get; private set; }

		public int ChosenSeed { get; protected set; }

		public Dungeon CurrentDungeon
		{
			get
			{
				return null;
			}
		}

		public event GenerationStatusDelegate OnGenerationStatusChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event TileInjectionDelegate TileInjectionMethods
		{
			add
			{
			}
			remove
			{
			}
		}

		public DungeonGenerator()
		{
		}

		public DungeonGenerator(GameObject root)
		{
		}

		protected bool OuterGenerate(int? seed)
		{
			return false;
		}

		public bool GenerateAppended(Dungeon appendTo, bool allowIntersection)
		{
			return false;
		}

		public bool Generate()
		{
			return false;
		}

		public Dungeon DetachDungeon()
		{
			return null;
		}

		protected virtual bool OuterGenerate()
		{
			return false;
		}

		public GenerationAnalysis RunAnalysis(int iterations, float maximumAnalysisTime)
		{
			return null;
		}

		public void RandomizeSeed()
		{
		}

		protected virtual bool InnerGenerate(bool isRetry)
		{
			return false;
		}

		[DebuggerHidden]
		private IEnumerator NotifyGenerationComplete()
		{
			return null;
		}

		public virtual void Clear()
		{
		}

		private void ChangeStatus(GenerationStatus status)
		{
		}

		protected virtual void PreProcess()
		{
		}

		protected virtual void GatherTilesToInject()
		{
		}

		protected virtual bool GenerateMainPath()
		{
			return false;
		}

		protected virtual void GenerateBranchPaths()
		{
		}

		protected virtual Tile AddTile(Tile attachTo, IList<TileSet> useableTileSets, float normalizedDepth, DungeonArchetype archetype, TilePlacementResult result = TilePlacementResult.None)
		{
			return null;
		}

		protected PreProcessTileData GetTileTemplate(GameObject prefab)
		{
			return null;
		}

		protected PreProcessTileData PickRandomTemplate(DoorwaySocketType? socketGroupFilter)
		{
			return null;
		}

		protected int NormalizedDepthToIndex(float normalizedDepth)
		{
			return 0;
		}

		protected float IndexToNormalizedDepth(int index)
		{
			return 0f;
		}

		protected bool IsCollidingWithAnyTile(GameObject proxy)
		{
			return false;
		}

		protected void ClearPreProcessData()
		{
		}

		protected virtual void ConnectOverlappingDoorways(float percentageChance)
		{
		}

		protected virtual void PostProcess()
		{
		}

		protected virtual void ProcessGlobalProps()
		{
		}

		protected virtual void PlaceLocksAndKeys()
		{
		}

		protected virtual void LockDoorway(Doorway doorway, Key key, KeyManager keyManager)
		{
		}
	}
}
