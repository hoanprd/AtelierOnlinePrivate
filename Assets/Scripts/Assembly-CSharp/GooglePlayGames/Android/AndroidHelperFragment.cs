using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidHelperFragment
	{
		public enum WaitingRoomUIStatus
		{
			Valid = 1,
			Cancelled = 2,
			LeftRoom = 3,
			InvalidRoom = 4,
			Busy = -1,
			InternalError = -2
		}

		public class InvitationResultHolder
		{
			public int MinAutomatchingPlayers;

			public int MaxAutomatchingPlayers;

			public List<string> PlayerIdsToInvite;

			public InvitationResultHolder(int MinAutomatchingPlayers, int MaxAutomatchingPlayers, List<string> PlayerIdsToInvite)
			{
			}
		}

		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		public static AndroidJavaObject GetActivity()
		{
			return null;
		}

		public static AndroidJavaObject GetDefaultPopupView()
		{
			return null;
		}

		public static void ShowAchievementsUI(Action<UIStatus> cb)
		{
		}

		public static void ShowCaptureOverlayUI()
		{
		}

		public static void ShowAllLeaderboardsUI(Action<UIStatus> cb)
		{
		}

		public static void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan timeSpan, Action<UIStatus> cb)
		{
		}

		public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, Action<SelectUIStatus, ISavedGameMetadata> cb)
		{
		}

		public static void ShowRtmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, Action<UIStatus, InvitationResultHolder> cb)
		{
		}

		public static void ShowTbmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, Action<UIStatus, InvitationResultHolder> cb)
		{
		}

		private static void ShowSelectOpponentsUI(uint minOpponents, uint maxOpponents, bool isRealTime, Action<UIStatus, InvitationResultHolder> cb)
		{
		}

		public static void ShowWaitingRoomUI(AndroidJavaObject room, int minParticipantsToStart, Action<WaitingRoomUIStatus, AndroidJavaObject> cb)
		{
		}

		public static void ShowInboxUI(Action<UIStatus, TurnBasedMatch> cb)
		{
		}

		public static void ShowInvitationInboxUI(Action<UIStatus, Invitation> cb)
		{
		}

		private static List<string> CreatePlayerIdsToInvite(AndroidJavaObject playerIdsObject)
		{
			return null;
		}
	}
}
