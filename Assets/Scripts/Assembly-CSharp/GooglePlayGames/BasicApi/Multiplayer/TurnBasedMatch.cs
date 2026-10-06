using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class TurnBasedMatch
	{
		public enum MatchStatus
		{
			Active = 0,
			AutoMatching = 1,
			Cancelled = 2,
			Complete = 3,
			Expired = 4,
			Unknown = 5,
			Deleted = 6
		}

		public enum MatchTurnStatus
		{
			Complete = 0,
			Invited = 1,
			MyTurn = 2,
			TheirTurn = 3,
			Unknown = 4
		}

		private string mMatchId;

		private byte[] mData;

		private bool mCanRematch;

		private uint mAvailableAutomatchSlots;

		private string mSelfParticipantId;

		private List<Participant> mParticipants;

		private string mPendingParticipantId;

		private MatchTurnStatus mTurnStatus;

		private MatchStatus mMatchStatus;

		private uint mVariant;

		private uint mVersion;

		private DateTime mCreationTime;

		private DateTime mLastUpdateTime;

		public DateTime CreationTime
		{
			get
			{
				return default(DateTime);
			}
		}

		public DateTime LastUpdateTime
		{
			get
			{
				return default(DateTime);
			}
		}

		public string MatchId
		{
			get
			{
				return null;
			}
		}

		public byte[] Data
		{
			get
			{
				return null;
			}
		}

		public bool CanRematch
		{
			get
			{
				return false;
			}
		}

		public string SelfParticipantId
		{
			get
			{
				return null;
			}
		}

		public Participant Self
		{
			get
			{
				return null;
			}
		}

		public List<Participant> Participants
		{
			get
			{
				return null;
			}
		}

		public string PendingParticipantId
		{
			get
			{
				return null;
			}
		}

		public Participant PendingParticipant
		{
			get
			{
				return null;
			}
		}

		public MatchTurnStatus TurnStatus
		{
			get
			{
				return MatchTurnStatus.Complete;
			}
		}

		public MatchStatus Status
		{
			get
			{
				return MatchStatus.Active;
			}
		}

		public uint Variant
		{
			get
			{
				return 0u;
			}
		}

		public uint Version
		{
			get
			{
				return 0u;
			}
		}

		public uint AvailableAutomatchSlots
		{
			get
			{
				return 0u;
			}
		}

		internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, List<Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, MatchTurnStatus turnStatus, MatchStatus matchStatus, uint variant, uint version, DateTime creationTime, DateTime lastUpdateTime)
		{
		}

		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
