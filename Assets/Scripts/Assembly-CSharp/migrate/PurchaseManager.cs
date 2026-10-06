using System;
using UnityEngine;
using UnityEngine.Purchasing;

namespace migrate
{
	public class PurchaseManager : MonoBehaviour, IStoreListener
	{
		private enum State
		{
			None = 0,
			StoreServerFinish = 1,
			GameServerStart = 2,
			GameServerWait = 3,
			GameServerFinish = 4,
			PurchaseError = 5,
			Num = 6
		}

		private enum SaveProcessState
		{
			None = 0,
			BuyRequest = 1,
			StoreBought = 2,
			GameServerRequest = 3,
			GameServerResponsed = 4,
			Complete = 5,
			Failed = 6
		}

		private static GameObject m_obj;

		private static PurchaseManager m_instance;

		private const string save_process_key = "PurchaseProcess";

		private IStoreController m_controller;

		private IExtensionProvider m_extensions;

		private ConfigurationBuilder m_builder;

		private int m_free_coal;

		private int m_pay_coal;

		private object m_lock;

		private bool m_require_purchase;

		private string m_purchasing_product_id;

		private Action<bool> m_initialized_callback;

		private Action<bool, string> m_restore_callback;

		private Action<bool, string> m_finish_callback;

		public bool IsInitialized { get; private set; }

		public static PurchaseManager GetInstance()
		{
			return null;
		}

		public static void Clear()
		{
		}

		private void SaveProcess(SaveProcessState proc)
		{
		}

		public static bool IsExistInterruptInfo()
		{
			return false;
		}

		private void Awake()
		{
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

        public void OnInitializeFailed(InitializationFailureReason error, string message)
        {
        }

        public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
		{
		}

		public void Initialize(ProductInfoList list, Action<bool> initialized_callback, Action<bool, string> restore_callback)
		{
		}

		public void Purchase(string product_id, Action<bool, string> callback)
		{
		}

		private void OnPurchaseComplete(bool result, PurchaseEventArgs e)
		{
		}

		private void OnFinish(bool result, string product_id)
		{
		}

		private bool IsRestore(string product_id)
		{
			return false;
		}

		private bool IsNeedRestoreNortify()
		{
			return false;
		}

		private void OnRestoreStart()
		{
		}

		private void OnRestoreFinish(bool result, string product_id)
		{
		}

		private void OnPurchaseFinish(bool result, string product_id)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return PurchaseProcessingResult.Complete;
		}

		public static string ExtractFromAndroidReceipt(string receipt)
		{
			return null;
		}

		public static string ExtractFromAndroidSignature(string receipt)
		{
			return null;
		}
	}
}
