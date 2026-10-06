using System;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class Participant : IComparable<Participant>
	{
		public enum ParticipantStatus
		{
			NotInvitedYet = 0,
			Invited = 1,
			Joined = 2,
			Declined = 3,
			Left = 4,
			Finished = 5,
			Unresponsive = 6,
			Unknown = 7
		}

		private string mDisplayName;

		private readonly string mParticipantId;

		private ParticipantStatus mStatus;

		private Player mPlayer;

		private bool mIsConnectedToRoom;

		public string DisplayName
		{
			get
			{
				return null;
			}
		}

		public string ParticipantId
		{
			get
			{
				return null;
			}
		}

		public ParticipantStatus Status
		{
			get
			{
				return ParticipantStatus.NotInvitedYet;
			}
		}

		public Player Player
		{
			get
			{
				return null;
			}
		}

		public bool IsConnectedToRoom
		{
			get
			{
				return false;
			}
		}

		public bool IsAutomatch
		{
			get
			{
				return false;
			}
		}

		internal Participant(string displayName, string participantId, ParticipantStatus status, Player player, bool connectedToRoom)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public int CompareTo(Participant other)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
