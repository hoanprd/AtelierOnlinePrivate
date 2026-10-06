using System;

namespace Google.Play.Billing.Internal
{
	public class Purchase
	{
		public class Identifiers
		{
			private string _obfuscatedAccountId;

			private string _obfuscatedProfileId;

			public string ObfuscatedAccountId
			{
				get
				{
					return null;
				}
			}

			public string ObfuscatedProfileId
			{
				get
				{
					return null;
				}
			}

			public Identifiers(string obfuscatedAccountId, string obfuscatedProfileId)
			{
			}
		}

		[Serializable]
		private class PurchaseData
		{
			public string productId;

			public string packageName;

			public string orderId;

			public string token;

			public string purchaseToken;

			public int purchaseState;

			public long purchaseTime;

			public bool acknowledged;

			public bool autoRenewing;

			public string obfuscatedAccountId;

			public string obfuscatedProfileId;
		}

		[Serializable]
		private class PurchaseReceipt
		{
			public string json;

			public string signature;

			public PurchaseReceipt(string jsonPurchaseData, string signature)
			{
			}
		}

		public enum State
		{
			UnspecifiedState = 0,
			Purchased = 1,
			Pending = 2
		}

		private readonly PurchaseData _purchaseData;

		private readonly Identifiers _identifiers;

		private readonly PurchaseReceipt _purchaseReceipt;

		public string ProductId
		{
			get
			{
				return null;
			}
		}

		public string PackageName
		{
			get
			{
				return null;
			}
		}

		public string OrderId
		{
			get
			{
				return null;
			}
		}

		public string PurchaseToken
		{
			get
			{
				return null;
			}
		}

		public State PurchaseState
		{
			get
			{
				return State.UnspecifiedState;
			}
		}

		public long PurchaseTime
		{
			get
			{
				return 0L;
			}
		}

		public bool Acknowledged
		{
			get
			{
				return false;
			}
		}

		public bool AutoRenewing
		{
			get
			{
				return false;
			}
		}

		public Identifiers AccountIdentifiers
		{
			get
			{
				return null;
			}
		}

		public string JsonReceipt
		{
			get
			{
				return null;
			}
		}

		public string TransactionId
		{
			get
			{
				return null;
			}
		}

		private Purchase(PurchaseData purchaseData, string jsonPurchaseData, string signature)
		{
		}

		public static bool FromJson(string jsonPurchaseData, string signature, out Purchase purchase)
		{
			purchase = null;
			return false;
		}
	}
}
