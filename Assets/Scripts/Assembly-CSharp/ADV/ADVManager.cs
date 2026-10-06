using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ADVManager : MonoBehaviour
	{
		public enum EStep
		{
			eNONE = 0,
			eLOAD_SCRIPT = 1,
			eLOAD_SCRIPT_WAIT = 2,
			eLOAD_SCRIPT_DIALOG = 3,
			eLOAD_SCRIPT_UNLOAD = 4,
			eLOAD_ASSET = 5,
			eLOAD_ASSET_WAIT = 6,
			eLOAD_ASSET_DIALOG = 7,
			eSTART = 8,
			ePLAY = 9,
			eEND_WAIT = 10,
			eEND = 11
		}

		public class RollbackInfo
		{
			public eMusicID eMusic;

			public float fBGMVol;
		}

		private enum EState
		{
			eWAIT = 0,
			eFADEIN = 1,
			eFADEOUT = 2,
			eMOVE = 3,
			eMOTION = 4,
			eROTATION = 5
		}

		public ScriptInfo m_sScript;

		public ScriptBase m_sExec;

		public EStep m_eStep;

		public int m_iProgress;

		public UIManager m_sUI;

		public Camera m_sCamera;

		public bool m_bDebugAuto;

		public List<ScriptBase> m_vScripts;

		public Transform m_trUIRoot;

		public GameObject m_goUIPrefab;

		private int m_iLastSelectionID;

		private EOrderType m_eNowOrder;

		private const float csSOUND_VOLUME = 0.7f;

		private bool m_bDispLog;

		private bool m_isSkipActive;

		private string m_sScriptPath;

		private string m_sADVFilePath;

		private List<string> m_vLoadAssetPath;

		private AssetDownloader m_sDownloader;

		private RollbackInfo m_sRollbackInfo;

		private bool m_bRetryAsset;

		private bool m_bDialog;

		private bool m_bError;

		private string m_sErrorLog;

		private bool m_isNotLoadFieldStatus;

		private static ADVManager s_sIntance;

		private const string csTEXT_EFFECT_KEY = "TEXTEFFECT";

		private EState m_eStat;

		public Game_Chara_MA_Mob m_sMob;

		public Vector3 m_vTarget;

		public Vector3 m_vDir;

		public int LastSelectionID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public EOrderType NowOrder
		{
			get
			{
				return EOrderType.eNONE;
			}
		}

		public static ADVManager Instance
		{
			get
			{
				return null;
			}
		}

		public static bool IsInstance
		{
			get
			{
				return false;
			}
		}

		public static bool TexEffect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsError
		{
			get
			{
				return false;
			}
		}

		public static string ErrorLog
		{
			get
			{
				return null;
			}
		}

		public static string VoDirPath
		{
			get
			{
				return null;
			}
		}

		public static bool IsAlmostEnd
		{
			get
			{
				return false;
			}
		}

		public static bool IsEnd
		{
			get
			{
				return false;
			}
		}

		public static bool IsLoading
		{
			get
			{
				return false;
			}
		}

		public static bool IsSEOK
		{
			get
			{
				return false;
			}
		}

		public bool IsAuto
		{
			get
			{
				return false;
			}
		}

		public bool IsSkip
		{
			get
			{
				return false;
			}
		}

		private void Awake()
		{
		}

		public static void LoadVillage(int id)
		{
		}

		public static void Load(string filePath)
		{
		}

		public static void Load(ScriptInfo script)
		{
		}

		public void LoadStart(string filePath)
		{
		}

		public void LoadStart(ScriptInfo script)
		{
		}

		public void SetSkip(bool skip)
		{
		}

		public void SetActiveSkipButton(bool active)
		{
		}

		public void SetNotLoadFieldStatusFlg(bool isSet)
		{
		}

		public void Skip()
		{
		}

		public bool IsAutoMoveOnly()
		{
			return false;
		}

		private void Init()
		{
		}

		private void SaveFieldStatus()
		{
		}

		public void SetRollbackBGM(eMusicID id)
		{
		}

		public void SetRollbackVolume(float volume)
		{
		}

		private void LoadFieldStatus()
		{
		}

		private void LoadScript()
		{
		}

		private void SetError(string content)
		{
		}

		private void LoadAssets()
		{
		}

		private bool CheckDownloadComplete()
		{
			return false;
		}

		private void CreateAssetRetryDialog()
		{
		}

		private void OnAssetRetryDialog(EButtonKind result)
		{
		}

		private bool UnloadRetryAsset()
		{
			return false;
		}

		private ScriptBase RegistScript(EOrderType kind)
		{
			return null;
		}

		private Game_Chara_MA_Mob GetMob()
		{
			return null;
		}

		private void Update()
		{
		}

		private void PlayOrder()
		{
		}

		private void PlayStart()
		{
		}

		private void Next()
		{
		}

		public void SetEnd()
		{
		}

		private void CloseUI()
		{
		}

		private bool FindCommand(EOrderType order)
		{
			return false;
		}

		private bool CreateOrder(Order order)
		{
			return false;
		}

		public void HideWindow()
		{
		}
	}
}
