using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace Network
{
	public class NetworkRequest : MonoBehaviour
	{
		private const float cfTIMEOUT = 60f;

		private int m_iRetry;

		private APIBase m_sAPI;

		private DialogCommon m_sConfirm;

		private bool m_bGotoTitle;

		private static int m_iSessionID;

		private static int m_iSessionCount;

		public static int SessionID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SessionCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ResponseDataCommon Response
		{
			get
			{
				return null;
			}
		}

		private byte[] GetSession()
		{
			return null;
		}

		[DebuggerHidden]
		public IEnumerator Post(APIBase api, bool dbg = false, bool no_dialog = false)
		{
			return null;
		}

		private void OnRetryConfirm(EButtonKind result)
		{
		}

		public void Notify()
		{
		}

		public void PostProcess()
		{
		}
	}
}
