using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class MatchOutcome
	{
		public enum ParticipantResult
		{
			Unset = -1,
			None = 0,
			Win = 1,
			Loss = 2,
			Tie = 3
		}

		public const uint PlacementUnset = 0u;

		private List<string> mParticipantIds;

		private Dictionary<string, uint> mPlacements;

		private Dictionary<string, ParticipantResult> mResults;

		public List<string> ParticipantIds
		{
			get
			{
				return null;
			}
		}

		public void SetParticipantResult(string participantId, ParticipantResult result, uint placement)
		{
		}

		public void SetParticipantResult(string participantId, ParticipantResult result)
		{
		}

		public void SetParticipantResult(string participantId, uint placement)
		{
		}

		public ParticipantResult GetResultFor(string participantId)
		{
			return ParticipantResult.None;
		}

		public uint GetPlacementFor(string participantId)
		{
			return 0u;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
