using System.Runtime.InteropServices;

namespace UnityEngine.SignInWithApple
{
	[StructLayout((LayoutKind)0, Size = 48)]
	public struct UserInfo
	{
		public string userId;

		public string email;

		public string displayName;

		public string idToken;

		public string error;

		public UserDetectionStatus userDetectionStatus;
	}
}
