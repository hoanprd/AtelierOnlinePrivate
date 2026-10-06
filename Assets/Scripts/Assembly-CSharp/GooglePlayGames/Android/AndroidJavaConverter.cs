using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidJavaConverter
	{
		internal static DateTime ToDateTime(long milliseconds)
		{
			return default(DateTime);
		}

		internal static int ToLeaderboardVariantTimeSpan(LeaderboardTimeSpan span)
		{
			return 0;
		}

		internal static int ToLeaderboardVariantCollection(LeaderboardCollection collection)
		{
			return 0;
		}

		internal static int ToPageDirection(ScorePageDirection direction)
		{
			return 0;
		}

		internal static Invitation.InvType FromInvitationType(int invitationTypeJava)
		{
			return Invitation.InvType.RealTime;
		}

		internal static Participant.ParticipantStatus FromParticipantStatus(int participantStatusJava)
		{
			return Participant.ParticipantStatus.NotInvitedYet;
		}

		internal static Participant ToParticipant(AndroidJavaObject participant)
		{
			return null;
		}

		internal static Player ToPlayer(AndroidJavaObject player)
		{
			return null;
		}

		internal static Invitation ToInvitation(AndroidJavaObject invitation)
		{
			return null;
		}

		internal static TurnBasedMatch ToTurnBasedMatch(AndroidJavaObject turnBasedMatch)
		{
			return null;
		}

		internal static List<Participant> ToParticipantList(AndroidJavaObject turnBasedMatch)
		{
			return null;
		}

		internal static List<string> ToStringList(AndroidJavaObject stringList)
		{
			return null;
		}

		internal static AndroidJavaObject ToJavaStringList(List<string> list)
		{
			return null;
		}

		internal static TurnBasedMatch.MatchStatus ToMatchStatus(int matchStatus)
		{
			return TurnBasedMatch.MatchStatus.Active;
		}

		internal static TurnBasedMatch.MatchTurnStatus ToMatchTurnStatus(int matchTurnStatus)
		{
			return TurnBasedMatch.MatchTurnStatus.Complete;
		}
	}
}
