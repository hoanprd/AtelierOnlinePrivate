using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.BasicApi.Nearby
{
	[StructLayout((LayoutKind)0, Size = 16)]
	public struct NearbyConnectionConfiguration
	{
		public const int MaxUnreliableMessagePayloadLength = 1168;

		public const int MaxReliableMessagePayloadLength = 4096;

		private readonly Action<InitializationStatus> mInitializationCallback;

		private readonly long mLocalClientId;

		public long LocalClientId
		{
			get
			{
				return 0L;
			}
		}

		public Action<InitializationStatus> InitializationCallback
		{
			get
			{
				return null;
			}
		}

		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
			mInitializationCallback = null;
			mLocalClientId = 0L;
		}
	}
}
