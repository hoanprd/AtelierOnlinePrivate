using System.Collections.Generic;
using ExitGames.Client.Photon;

namespace Photon.Chat
{
	public class ChatPeer : PhotonPeer
	{
		public const string NameServerHost = "ns.exitgames.com";

		public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		public string NameServerAddress
		{
			get
			{
				return null;
			}
		}

		internal virtual bool IsProtocolSecure
		{
			get
			{
				return false;
			}
		}

		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol)
			: base(ConnectionProtocol.Udp)
		{
		}

		private void ConfigUnitySockets()
		{
		}

		private string GetNameServerAddress()
		{
			return null;
		}

		public bool Connect()
		{
			return false;
		}

		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues)
		{
			return false;
		}
	}
}
