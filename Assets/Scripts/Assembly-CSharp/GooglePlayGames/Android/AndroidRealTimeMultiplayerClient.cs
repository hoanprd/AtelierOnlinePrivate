using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidRealTimeMultiplayerClient : IRealTimeMultiplayerClient
	{
		private enum RoomStatus
		{
			NotCreated = -1,
			Inviting = 0,
			AutoMatching = 1,
			Connecting = 2,
			Active = 3,
			Deleted = 4
		}

		private class RoomStatusUpdateCallbackProxy : AndroidJavaProxy
		{
			private OnGameThreadForwardingListener mListener;

			private AndroidRealTimeMultiplayerClient mParent;

			public RoomStatusUpdateCallbackProxy(AndroidRealTimeMultiplayerClient parent, OnGameThreadForwardingListener listener)
				: base((string)null)
			{
			}

			public void onRoomConnecting(AndroidJavaObject room)
			{
			}

			public void onRoomAutoMatching(AndroidJavaObject room)
			{
			}

			public void onPeerInvitedToRoom(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			public void onPeerDeclined(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			public void onPeerJoined(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			public void onPeerLeft(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			private void handleParticipantStatusChanged(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			public void onConnectedToRoom(AndroidJavaObject room)
			{
			}

			public void onDisconnectedFromRoom(AndroidJavaObject room)
			{
			}

			public void onPeersConnected(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			public void onPeersDisconnected(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			private void handleConnectedSetChanged(AndroidJavaObject room)
			{
			}

			public void onP2PConnected(string participantId)
			{
			}

			public void onP2PDisconnected(string participantId)
			{
			}
		}

		private class MessageReceivedListenerProxy : AndroidJavaProxy
		{
			private OnGameThreadForwardingListener mListener;

			public MessageReceivedListenerProxy(OnGameThreadForwardingListener listener)
				: base((string)null)
			{
			}

			public void onRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}
		}

		private class RoomUpdateCallbackProxy : AndroidJavaProxy
		{
			private OnGameThreadForwardingListener mListener;

			private AndroidRealTimeMultiplayerClient mParent;

			public RoomUpdateCallbackProxy(AndroidRealTimeMultiplayerClient parent, OnGameThreadForwardingListener listener)
				: base((string)null)
			{
			}

			public void onRoomCreated(int statusCode, AndroidJavaObject room)
			{
			}

			public void onJoinedRoom(int statusCode, AndroidJavaObject room)
			{
			}

			public void onLeftRoom(int statusCode, string roomId)
			{
			}

			public void onRoomConnected(int statusCode, AndroidJavaObject room)
			{
			}
		}

		private class OnGameThreadForwardingListener
		{
			private readonly RealTimeMultiplayerListener mListener;

			internal OnGameThreadForwardingListener(RealTimeMultiplayerListener listener)
			{
			}

			public void OnRoomSetupProgress(float percent)
			{
			}

			public void OnRoomConnected(bool success)
			{
			}

			public void OnLeftRoom()
			{
			}

			public void OnPeersConnected(string[] participantIds)
			{
			}

			public void OnPeersDisconnected(string[] participantIds)
			{
			}

			public void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}

			public void OnParticipantLeft(Participant participant)
			{
			}
		}

		private readonly object mSessionLock;

		private int mMinPlayersToStart;

		private AndroidClient mAndroidClient;

		private AndroidJavaObject mRtmpClient;

		private AndroidJavaObject mInvitationsClient;

		private AndroidJavaObject mRoom;

		private AndroidJavaObject mRoomConfig;

		private OnGameThreadForwardingListener mListener;

		private Invitation mInvitation;

		public AndroidRealTimeMultiplayerClient(AndroidClient androidClient, AndroidJavaObject account)
		{
		}

		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener)
		{
		}

		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		private float GetPercentComplete()
		{
			return 0f;
		}

		public void ShowWaitingRoomUI()
		{
		}

		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		public void AcceptFromInbox(RealTimeMultiplayerListener listener)
		{
		}

		public void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener)
		{
		}

		public void SendMessageToAll(bool reliable, byte[] data)
		{
		}

		public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
		{
		}

		public void SendMessage(bool reliable, string participantId, byte[] data)
		{
		}

		public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
		{
		}

		public List<Participant> GetConnectedParticipants()
		{
			return null;
		}

		private List<Participant> GetParticipantList()
		{
			return null;
		}

		public Participant GetSelf()
		{
			return null;
		}

		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		public Invitation GetInvitation()
		{
			return null;
		}

		public void LeaveRoom()
		{
		}

		public bool IsRoomConnected()
		{
			return false;
		}

		private RoomStatus GetRoomStatus()
		{
			return RoomStatus.Inviting;
		}

		public void DeclineInvitation(string invitationId)
		{
		}

		private void FindInvitation(string invitationId, Action<bool> fail, Action<Invitation> callback)
		{
		}

		private void CleanSession()
		{
		}

		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}
	}
}
