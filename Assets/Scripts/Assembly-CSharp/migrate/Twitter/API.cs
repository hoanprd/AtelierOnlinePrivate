using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace migrate.Twitter
{
	internal class API
	{
		private static readonly string RequestTokenURL;

		private static readonly string AuthorizationURL;

		private static readonly string AccessTokenURL;

		private const string PostTweetURL = "https://api.twitter.com/1.1/statuses/update.json";

		private static readonly string[] OAuthParametersToIncludeInHeader;

		private static readonly string[] SecretParameters;

		[DebuggerHidden]
		public static IEnumerator GetRequestToken(string consumerKey, string consumerSecret, RequestTokenCallback callback)
		{
			return null;
		}

		public static void OpenAuthorizationPage(string requestToken)
		{
		}

		public static void OpenAuthorizationPage(string requestToken, WebViewWindow webView, AuthorizationCallback callback)
		{
		}

		[DebuggerHidden]
		public static IEnumerator GetAccessToken(string consumerKey, string consumerSecret, string requestToken, string pin, AccessTokenCallback callback)
		{
			return null;
		}

		private static WWW WWWRequestToken(string consumerKey, string consumerSecret)
		{
			return null;
		}

		private static WWW WWWAccessToken(string consumerKey, string consumerSecret, string requestToken, string pin)
		{
			return null;
		}

		private static string GetHeaderWithAccessToken(string httpRequestType, string apiURL, string consumerKey, string consumerSecret, AccessTokenResponse response, Dictionary<string, string> parameters)
		{
			return null;
		}

		[DebuggerHidden]
		public static IEnumerator PostTweet(string text, string consumerKey, string consumerSecret, AccessTokenResponse response, PostTweetCallback callback)
		{
			return null;
		}

		private static void AddDefaultOAuthParams(Dictionary<string, string> parameters, string consumerKey, string consumerSecret)
		{
		}

		private static string GetFinalOAuthHeader(string HTTPRequestType, string URL, Dictionary<string, string> parameters)
		{
			return null;
		}

		private static string GenerateSignature(string httpMethod, string url, Dictionary<string, string> parameters)
		{
			return null;
		}

		private static string GenerateTimeStamp()
		{
			return null;
		}

		private static string GenerateNonce()
		{
			return null;
		}

		private static string NormalizeUrl(Uri url)
		{
			return null;
		}

		private static string UrlEncode(string value)
		{
			return null;
		}

		private static string UrlEncode(IEnumerable<KeyValuePair<string, string>> parameters)
		{
			return null;
		}
	}
}
