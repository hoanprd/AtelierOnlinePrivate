using System.Collections.Generic;
using System.Reflection;
using Photon;

namespace YM
{
	public class YmPhotonDriver
	{
		private const int DURATION_SEND_MS = 200;

		private static Dictionary<string, MethodInfo> mInfoMap;

		private MonoBehaviour _mono;

		private readonly CmdPack _cmdPack;

		private int _lastSendTime;

		private Dictionary<int, Queue<IList<object>>> _callbackQueueMap;

		private const string RPC_FuncName = "Receive_PhotonMessage";

		private PhotonView _photonView
		{
			get
			{
				return null;
			}
		}

		public YmPhotonDriver(MonoBehaviour mono)
		{
		}

		public static void Initialize(MonoBehaviour mono)
		{
		}

		public void DestroyPhotonView()
		{
		}

		public void RPC(string methodName, PhotonTargets target, params object[] parameters)
		{
		}

		public void RpcSecure(string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
		{
		}

		public void RpcImmediate(string methodName, PhotonTargets target, params object[] parameters)
		{
		}

		public void RPC(string methodName, PhotonPlayer targetPlayer, params object[] parameters)
		{
		}

		public void RpcSecure(string methodName, PhotonPlayer targetPlayer, bool encrypt, params object[] parameters)
		{
		}

		public void DoRpc()
		{
		}

		private void _doRpc()
		{
		}

		private void _doRpcSend()
		{
		}

		private bool _isPassedDurationForSend()
		{
			return false;
		}

		private void _doSend(int typeNo, CmdBlock cmdBlock)
		{
		}

		private void _send(int typeNo, CmdFram cmdFram)
		{
		}

		public void Callback(string json, PhotonMessageInfo msgsInfo)
		{
		}

		private void _exeProc(string methodName, object[] args)
		{
		}

		private void _convertType(ParameterInfo[] pInfos, object[] args)
		{
		}
	}
}
