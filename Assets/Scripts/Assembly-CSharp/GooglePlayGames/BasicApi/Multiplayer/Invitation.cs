using System;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	public class Invitation
	{
		public enum InvType
		{
			RealTime = 0,
			TurnBased = 1,
			Unknown = 2
		}

		private InvType mInvitationType;

		private string mInvitationId;

		private Participant mInviter;

		private int mVariant;

		private DateTime mCreationTime;

		public InvType InvitationType
		{
			get
			{
				return InvType.RealTime;
			}
		}

		public string InvitationId
		{
			get
			{
				return null;
			}
		}

		public Participant Inviter
		{
			get
			{
				return null;
			}
		}

		public int Variant
		{
			get
			{
				return 0;
			}
		}

		public DateTime CreationTime
		{
			get
			{
				return default(DateTime);
			}
		}

		internal Invitation(InvType invType, string invId, Participant inviter, int variant, DateTime creationTime)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
