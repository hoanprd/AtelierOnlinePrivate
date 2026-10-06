using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout((LayoutKind)0, Size = 16)]
	public struct AdvertisingResult
	{
		private readonly ResponseStatus mStatus;

		private readonly string mLocalEndpointName;

		public bool Succeeded
		{
			get
			{
				return false;
			}
		}

		public ResponseStatus Status
		{
			get
			{
				return (ResponseStatus)0;
			}
		}

		public string LocalEndpointName
		{
			get
			{
				return null;
			}
		}

		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
			mStatus = (ResponseStatus)0;
			mLocalEndpointName = null;
		}
	}
}
