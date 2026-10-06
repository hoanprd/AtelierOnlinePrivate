using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
	{
		private class TurnBasedMatchUpdateCallbackProxy : AndroidJavaProxy
		{
			private Action<TurnBasedMatch, bool> mMatchDelegate;

			public TurnBasedMatchUpdateCallbackProxy(Action<TurnBasedMatch, bool> matchDelegate)
				: base((string)null)
			{
			}

			public void onTurnBasedMatchReceived(AndroidJavaObject turnBasedMatch)
			{
			}

			public void onTurnBasedMatchRemoved(string invitationId)
			{
			}
		}

		private AndroidJavaObject mClient;

		private AndroidClient mAndroidClient;

		private Action<TurnBasedMatch, bool> mMatchDelegate;

		public Action<TurnBasedMatch, bool> MatchDelegate
		{
			get
			{
				return null;
			}
		}

		public AndroidTurnBasedMultiplayerClient(AndroidClient androidClient, AndroidJavaObject account)
		{
		}

		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback)
		{
		}

		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, TurnBasedMatch> callback)
		{
		}

		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback)
		{
		}

		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, TurnBasedMatch> callback)
		{
		}

		private AndroidJavaObject StringListToAndroidJavaObject(List<string> list)
		{
			return null;
		}

		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		public void GetAllMatches(Action<TurnBasedMatch[]> callback)
		{
		}

		public void GetMatch(string matchId, Action<bool, TurnBasedMatch> callback)
		{
		}

		private void GetMatchAndroidJavaObject(string matchId, Action<bool, AndroidJavaObject> callback)
		{
		}

		public void AcceptFromInbox(Action<bool, TurnBasedMatch> callback)
		{
		}

		public void AcceptInvitation(string invitationId, Action<bool, TurnBasedMatch> callback)
		{
		}

		public void RegisterMatchDelegate(MatchDelegate del)
		{
		}

		public void TakeTurn(TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback)
		{
		}

		public int GetMaxMatchDataSize()
		{
			return 0;
		}

		public void Finish(TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback)
		{
		}

		public void AcknowledgeFinished(TurnBasedMatch match, Action<bool> callback)
		{
		}

		public void Leave(TurnBasedMatch match, Action<bool> callback)
		{
		}

		public void LeaveDuringTurn(TurnBasedMatch match, string pendingParticipantId, Action<bool> callback)
		{
		}

		public void Cancel(TurnBasedMatch match, Action<bool> callback)
		{
		}

		public void Dismiss(TurnBasedMatch match)
		{
		}

		public void Rematch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback)
		{
		}

		public void DeclineInvitation(string invitationId)
		{
		}

		private void FindInvitationWithId(string invitationId, Action<Invitation> callback)
		{
		}

		private void FindEqualVersionMatch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback)
		{
		}

		private void FindEqualVersionMatchWithParticipant(TurnBasedMatch match, string participantId, Action<bool> onFailure, Action<Participant, TurnBasedMatch> onFoundParticipantAndMatch)
		{
		}

		private Participant CreateAutomatchingSentinel()
		{
			return null;
		}

		private List<TurnBasedMatch> CreateTurnBasedMatchList(AndroidJavaObject turnBasedMatchBuffer)
		{
			return null;
		}

		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
}
