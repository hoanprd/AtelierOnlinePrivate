using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Android
{
	public class AndroidClient : IPlayGamesClient
	{
		private enum AuthState
		{
			Unauthenticated = 0,
			Authenticated = 1
		}

		private class InvitationCallbackProxy : AndroidJavaProxy
		{
			private Action<Invitation, bool> mInvitationDelegate;

			public InvitationCallbackProxy(Action<Invitation, bool> invitationDelegate)
				: base((string)null)
			{
			}

			public void onInvitationReceived(AndroidJavaObject invitation)
			{
			}

			public void onInvitationRemoved(string invitationId)
			{
			}
		}

		private readonly object GameServicesLock;

		private readonly object AuthStateLock;

		private readonly PlayGamesClientConfiguration mConfiguration;

		private AndroidTurnBasedMultiplayerClient mTurnBasedClient;

		private IRealTimeMultiplayerClient mRealTimeClient;

		private ISavedGameClient mSavedGameClient;

		private IEventsClient mEventsClient;

		private IVideoClient mVideoClient;

		private AndroidTokenClient mTokenClient;

		private Action<Invitation, bool> mInvitationDelegate;

		private Player mUser;

		private AuthState mAuthState;

		private AndroidJavaClass mGamesClass;

		private static string TasksClassName;

		private AndroidJavaObject mInvitationCallback;

		private readonly int mLeaderboardMaxResults;

		internal AndroidClient(PlayGamesClientConfiguration configuration)
		{
		}

		public void Authenticate(bool silent, Action<SignInStatus> callback)
		{
		}

		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		private static void InvokeCallbackOnGameThread(Action callback)
		{
		}

		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2)
		{
		}

		private void InitializeGameServices()
		{
		}

		private void InitializeTokenClient()
		{
		}

		public string GetUserEmail()
		{
			return null;
		}

		public string GetIdToken()
		{
			return null;
		}

		public string GetServerAuthCode()
		{
			return null;
		}

		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		public bool IsAuthenticated()
		{
			return false;
		}

		public void LoadFriends(Action<bool> callback)
		{
		}

		public IUserProfile[] GetFriends()
		{
			return null;
		}

		public void SignOut()
		{
		}

		public void SignOut(Action uiCallback)
		{
		}

		public string GetUserId()
		{
			return null;
		}

		public string GetUserDisplayName()
		{
			return null;
		}

		public string GetUserImageUrl()
		{
			return null;
		}

		public void SetGravityForPopups(Gravity gravity)
		{
		}

		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		public int LeaderboardMaxResults()
		{
			return 0;
		}

		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		private void AddOnFailureListenerWithSignOut(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		private Action<UIStatus> GetUiSignOutCallbackOnGameThread(Action<UIStatus> callback)
		{
			return null;
		}

		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava)
		{
			return null;
		}

		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		private void UpdateClients()
		{
		}

		public bool HasPermissions(string[] scopes)
		{
			return false;
		}

		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			return null;
		}

		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			return null;
		}

		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		public IEventsClient GetEventsClient()
		{
			return null;
		}

		public IVideoClient GetVideoClient()
		{
			return null;
		}

		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
		}

		private AndroidJavaObject getAchievementsClient()
		{
			return null;
		}

		private AndroidJavaObject getGamesClient()
		{
			return null;
		}

		private AndroidJavaObject getInvitationsClient()
		{
			return null;
		}

		private AndroidJavaObject getPlayersClient()
		{
			return null;
		}

		private AndroidJavaObject getLeaderboardsClient()
		{
			return null;
		}

		private AndroidJavaObject getPlayerStatsClient()
		{
			return null;
		}

		private AndroidJavaObject getVideosClient()
		{
			return null;
		}
	}
}
