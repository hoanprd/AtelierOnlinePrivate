using System.Text;
using DunGen.Analysis;
using DunGen.Graph;
using UnityEngine;

namespace DunGen.Editor
{
	public sealed class RuntimeAnalyzer : MonoBehaviour
	{
		public DungeonFlow DungeonFlow;

		public int Iterations;

		public int MaxFailedAttempts;

		public bool RunOnStart;

		public float MaximumAnalysisTime;

		public float PerFrameAnalysisTime;

		private DungeonGenerator generator;

		private GenerationAnalysis analysis;

		private StringBuilder infoText;

		private int targetIterations;

		private int currentIterations;

		private double analysisTime;

		private bool finishedEarly;

		private bool prevShouldRandomizeSeed;

		private void Start()
		{
		}

		public void Analyze()
		{
		}

		private void Update()
		{
		}

		private void OnAnalysisComplete()
		{
		}

		private void OnGUI()
		{
		}
	}
}
