using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout((LayoutKind)0, Size = 32)]
	public struct ConnectionResponse
	{
		public enum Status
		{
			Accepted = 0,
			Rejected = 1,
			ErrorInternal = 2,
			ErrorNetworkNotConnected = 3,
			ErrorEndpointNotConnected = 4,
			ErrorAlreadyConnected = 5
		}

		private static readonly byte[] EmptyPayload;

		private readonly long mLocalClientId;

		private readonly string mRemoteEndpointId;

		private readonly Status mResponseStatus;

		private readonly byte[] mPayload;

		public long LocalClientId
		{
			get
			{
				return 0L;
			}
		}

		public string RemoteEndpointId
		{
			get
			{
				return null;
			}
		}

		public Status ResponseStatus
		{
			get
			{
				return Status.Accepted;
			}
		}

		public byte[] Payload
		{
			get
			{
				return null;
			}
		}

		private ConnectionResponse(long localClientId, string remoteEndpointId, Status code, byte[] payload)
		{
			mLocalClientId = 0L;
			mRemoteEndpointId = null;
			mResponseStatus = Status.Accepted;
			mPayload = null;
		}

		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}
	}
}
