using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout((LayoutKind)0, Size = 24)]
	public struct EndpointDetails
	{
		private readonly string mEndpointId;

		private readonly string mName;

		private readonly string mServiceId;

		public string EndpointId
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string ServiceId
		{
			get
			{
				return null;
			}
		}

		public EndpointDetails(string endpointId, string name, string serviceId)
		{
			mEndpointId = null;
			mName = null;
			mServiceId = null;
		}
	}
}
