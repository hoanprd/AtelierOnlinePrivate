using System;
using UnityEngine;
using migrate.Twitter;

namespace migrate
{
	internal class TwitterAuthentication : MonoBehaviour, IAuthentication
	{
		private const string consumer_key = "z4Tdic7SroTRVMJreywcNs8Fx";

		private const string consumer_secret = "7JyAJiiWbGvre2x4W9B1UghNF0iric5LJT23QJADxnzjzKxlpR";

		private const string player_prefs_key = "tt_ret";

		private Action<bool, string> m_callback;

		private WebViewWindow m_web_view;

		private string m_request_token;

		private static TwitterAuthentication s_instance;

		public string ID { get; private set; }

		private TwitterAuthentication()
		{
		}

		public static TwitterAuthentication GetInstance()
		{
			return null;
		}

		public void Init()
		{
		}

		public void Authenticate(Action<bool, string> action)
		{
		}

		public void Failed(Action callback)
		{
		}

		private void RequestTokenCallback(bool success, RequestTokenResponse response)
		{
		}

		private void AuthorizationCallback(bool success, AuthorizationResponse response)
		{
		}

		private void AccessTokenCallback(bool success, AccessTokenResponse response)
		{
		}

		private void ResultSuccess()
		{
		}

		private void ResultFailure()
		{
		}
	}
}
