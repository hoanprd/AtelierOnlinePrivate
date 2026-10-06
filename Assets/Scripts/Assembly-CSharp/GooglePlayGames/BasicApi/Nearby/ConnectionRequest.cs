using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout((LayoutKind)0, Size = 32)]
	public struct ConnectionRequest
	{
		private readonly EndpointDetails mRemoteEndpoint;

		private readonly byte[] mPayload;

		public EndpointDetails RemoteEndpoint
		{
			get
			{
				return default(EndpointDetails);
			}
		}

		public byte[] Payload
		{
			get
			{
				return null;
			}
		}

		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
			mRemoteEndpoint = default(EndpointDetails);
			mPayload = null;
		}
	}
}
