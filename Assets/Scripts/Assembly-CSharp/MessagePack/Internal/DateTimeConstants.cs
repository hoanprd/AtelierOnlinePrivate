using System;

namespace MessagePack.Internal
{
	internal static class DateTimeConstants
	{
		internal static readonly DateTime UnixEpoch;

		internal const long BclSecondsAtUnixEpoch = 62135596800L;

		internal const int NanosecondsPerTick = 100;
	}
}
