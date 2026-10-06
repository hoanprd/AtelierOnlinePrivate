using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.SignInWithApple
{
	public class SignInWithApple : MonoBehaviour
	{
		[StructLayout((LayoutKind)0, Size = 64)]
		public struct CallbackArgs
		{
			public UserCredentialState credentialState;

			public UserInfo userInfo;

			public string error;
		}

		public delegate void Callback(CallbackArgs args);

		private delegate void LoginCompleted(int result, UserInfo info);

		private delegate void GetCredentialStateCompleted(UserCredentialState state);

		private static Callback s_LoginCompletedCallback;

		private static Callback s_CredentialStateCallback;

		private static readonly Queue<Action> s_EventQueue;

		public SignInWithAppleEvent onLogin;

		public SignInWithAppleEvent onCredentialState;

		public SignInWithAppleEvent onError;

		private static void LoginCompletedCallback(int result, UserInfo info)
		{
		}

		private static void GetCredentialStateCallback(UserCredentialState state)
		{
		}

		public void GetCredentialState(string userID)
		{
		}

		public void GetCredentialState(string userID, Callback callback)
		{
		}

		private void GetCredentialStateInternal(string userID)
		{
		}

		public void Login()
		{
		}

		public void Login(Callback callback)
		{
		}

		private void LoginInternal()
		{
		}

		private void TriggerOnLoginEvent(CallbackArgs args)
		{
		}

		private void TriggerCredentialStateEvent(CallbackArgs args)
		{
		}

		private void TriggerOnErrorEvent(CallbackArgs args)
		{
		}

		public void Update()
		{
		}
	}
}
