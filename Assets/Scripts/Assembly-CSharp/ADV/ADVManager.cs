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
            get => m_iLastSelectionID;
            set => m_iLastSelectionID = value;
        }

        public EOrderType NowOrder => m_eNowOrder;

        public static ADVManager Instance => s_sIntance;

        public static bool IsInstance => s_sIntance != null;

        public static bool TexEffect
        {
            get => false;
            set { }
        }

        public static bool IsError => s_sIntance != null && s_sIntance.m_bError;

        public static string ErrorLog => s_sIntance != null ? s_sIntance.m_sErrorLog : null;

        public static string VoDirPath
        {
            get
            {
                if (s_sIntance == null || string.IsNullOrEmpty(s_sIntance.m_sADVFilePath))
                    return null;
                return "ADV/Voice/" + s_sIntance.m_sADVFilePath;
            }
        }

        public static bool IsAlmostEnd
        {
            get
            {
                if (IsEnd) return true;
                return s_sIntance != null && s_sIntance.m_eStep == EStep.eEND_WAIT;
            }
        }

        public static bool IsEnd => s_sIntance == null || s_sIntance.m_eStep == EStep.eEND;

        public static bool IsLoading => s_sIntance != null && (int)s_sIntance.m_eStep > (int)EStep.eNONE && (int)s_sIntance.m_eStep < (int)EStep.eSTART;

        public static bool IsSEOK => IsAlmostEnd;

        public bool IsAuto => m_bDebugAuto;

        public bool IsSkip
        {
            get
            {
                if (m_sUI != null && m_sUI.m_sSkipButton != null)
                {
                    return m_sUI.m_sSkipButton.IsActive;
                }
                return m_isSkipActive;
            }
        }

        private void Awake()
        {
            if (s_sIntance != null && s_sIntance != this)
            {
                Destroy(gameObject);
                return;
            }
            s_sIntance = this;
        }

        private void OnDestroy()
        {
            if (s_sIntance == this)
            {
                s_sIntance = null;
            }
        }

        public static void LoadVillage(int id)
        {
            if (Instance != null)
            {
                Instance.LoadStart("Village_" + id);
            }
        }

        public static void Load(string filePath)
        {
            Debug.Log("ADVManager::Load: " + filePath);
            if (Instance != null)
            {
                Instance.LoadStart(filePath);
            }
        }

        public static void Load(ScriptInfo script)
        {
            if (Instance != null)
            {
                Instance.LoadStart(script);
            }
        }

        public void LoadStart(string filePath)
        {
            Init();
            m_sScriptPath = "ADV/Scripts/" + filePath;
            m_sADVFilePath = filePath;
            m_eStep = EStep.eNONE;
        }

        public void LoadStart(ScriptInfo script)
        {
            Init();
            m_sScript = script;
            m_eStep = EStep.eNONE;
        }

        public void SetSkip(bool skip)
        {
            m_isSkipActive = skip;
        }

        public void SetActiveSkipButton(bool active)
        {
            if (m_sUI != null && m_sUI.m_sSkipButton != null)
            {
                m_sUI.m_sSkipButton.gameObject.SetActive(active);
            }
        }

        public void SetNotLoadFieldStatusFlg(bool isSet)
        {
            m_isNotLoadFieldStatus = isSet;
        }

        public void Skip()
        {
            m_isSkipActive = true;
        }

        public bool IsAutoMoveOnly()
        {
            return m_eNowOrder == EOrderType.eCHARA_MOVE;
        }

        private void Init()
        {
            m_iProgress = 0;
            m_bError = false;
            m_sErrorLog = null;
            m_sExec = null;
            m_eNowOrder = EOrderType.eNONE;
        }

        private void SaveFieldStatus()
        {
            Sound_Manager inst = Sound_Manager.GetInst();
            if (inst != null)
            {
                SetRollbackBGM(inst.GetPlayMusicID());
                SetRollbackVolume(Sound_Manager.BGMVolume);
            }

            Game_UI_MA_Manager maMgr = Game_UI_MA_Manager.GetInst();
            if (maMgr != null && maMgr.gameObject != null)
            {
                maMgr.gameObject.SetActive(false);
            }
        }

        public void SetRollbackBGM(eMusicID id)
        {
            if (m_sRollbackInfo == null) m_sRollbackInfo = new RollbackInfo();
            m_sRollbackInfo.eMusic = id;
        }

        public void SetRollbackVolume(float volume)
        {
            if (m_sRollbackInfo == null) m_sRollbackInfo = new RollbackInfo();
            m_sRollbackInfo.fBGMVol = volume;
        }

        private void LoadFieldStatus()
        {
            if (m_isNotLoadFieldStatus) return;

            Game_UI_MA_Manager maMgr = Game_UI_MA_Manager.GetInst();
            if (maMgr != null && maMgr.gameObject != null)
            {
                maMgr.gameObject.SetActive(true);
            }
        }

        private void LoadScript()
        {
            if (m_sUI != null)
            {
                m_sUI.Init();
            }
            m_eStep = EStep.eLOAD_SCRIPT_WAIT;
        }

        private void SetError(string content)
        {
            m_bError = true;
            m_sErrorLog = content;
            if (m_sDownloader != null)
            {
                Destroy(m_sDownloader.gameObject);
                m_sDownloader = null;
            }
        }

        private void LoadAssets()
        {
            m_eStep = EStep.eLOAD_ASSET_WAIT;
        }

        private bool CheckDownloadComplete()
        {
            return m_sDownloader == null || m_sDownloader.IsEnd;
        }

        private void CreateAssetRetryDialog()
        {
            m_bDialog = true;
        }

        private void OnAssetRetryDialog(EButtonKind result)
        {
            m_bDialog = false;
            m_bRetryAsset = (result == EButtonKind.eDECIDE);
        }

        private bool UnloadRetryAsset()
        {
            return true;
        }

        private ScriptBase RegistScript(EOrderType kind)
        {
            if (m_vScripts != null)
            {
                for (int i = 0; i < m_vScripts.Count; i++)
                {
                    if (m_vScripts[i] != null)
                    {
                        return m_vScripts[i];
                    }
                }
            }
            return null;
        }

        private Game_Chara_MA_Mob GetMob()
        {
            return m_sMob;
        }

        private void Update()
        {
            int stepIndex = (int)m_eStep;
            switch (stepIndex)
            {
                case 1: // eLOAD_SCRIPT
                    SaveFieldStatus();
                    LoadScript();
                    m_eStep = EStep.eLOAD_SCRIPT_WAIT;
                    break;

                case 4: // eLOAD_SCRIPT_UNLOAD
                    if (UnloadRetryAsset())
                    {
                        LoadScript();
                        m_eStep = EStep.eLOAD_SCRIPT_WAIT;
                    }
                    break;

                case 5: // eLOAD_ASSET
                    LoadAssets();
                    m_eStep = EStep.eLOAD_ASSET_WAIT;
                    break;

                case 6: // eLOAD_ASSET_WAIT
                    if (AssetBundleManager.IsLoadAll())
                    {
                        if (CheckDownloadComplete())
                        {
                            m_eStep = EStep.eSTART;
                        }
                        else
                        {
                            CreateAssetRetryDialog();
                            m_eStep = EStep.eLOAD_ASSET_DIALOG;
                        }
                    }
                    break;

                case 7: // eLOAD_ASSET_DIALOG
                    if (!m_bDialog)
                    {
                        if (m_bRetryAsset)
                        {
                            m_eStep = EStep.eLOAD_ASSET;
                        }
                        else
                        {
                            SetError("Asset download error");
                        }
                    }
                    break;

                case 8: // eSTART
                    PlayStart();
                    break;

                case 9: // ePLAY
                    PlayOrder();
                    break;

                case 10: // eEND_WAIT
                    if (!m_bDialog)
                    {
                        if (m_bError)
                        {
                            SetError("ADV execution error");
                        }
                        else
                        {
                            m_eStep = EStep.eEND;
                        }
                    }
                    break;

                case 11: // eEND
                    CloseUI();
                    break;
            }

            if (m_sUI != null && m_sUI.m_sTalk != null)
            {
                m_bDispLog = m_sUI.m_sTalk.gameObject.activeSelf;
            }
        }

        private void PlayOrder()
        {
            bool isEnd = ADVLoading.IsEnd;
            bool isBlackOut = ADVLoading.IsBlackOut;

            if (!isEnd && !isBlackOut)
            {
                return;
            }

            bool mouseClick = Input.GetMouseButtonUp(0);

            if (m_sExec != null)
            {
                bool execResult = m_sExec.Exec(mouseClick, IsSkip);
                if (execResult)
                {
                    if (m_eNowOrder == EOrderType.eVOICE_ADV || m_eNowOrder == EOrderType.eSOUNDEFFECT)
                    {
                        Sound_Manager inst = Sound_Manager.GetInst();
                        if (inst != null)
                        {
                            inst.StopADVVoice(true);
                        }
                    }

                    m_eNowOrder = EOrderType.eNONE;
                    Next();
                }
            }
        }

        private void PlayStart()
        {
            m_iProgress = 0;
            m_eStep = EStep.ePLAY;
            Next();
        }

        private void Next()
        {
            while (true)
            {
                if (m_sExec != null)
                {
                    m_iProgress = m_sExec.Next(m_sScript, m_iProgress, IsSkip);
                }
                else
                {
                    m_iProgress++;
                }

                if (m_sScript == null || m_sScript.vOrderList == null || m_iProgress >= m_sScript.vOrderList.Count)
                {
                    break;
                }

                Order nextOrder = m_sScript.vOrderList[m_iProgress];
                if (CreateOrder(nextOrder))
                {
                    return;
                }
            }

            SetEnd();

            if (m_sExec != null)
            {
                Destroy(m_sExec.gameObject);
                m_sExec = null;
            }
        }

        public void SetEnd()
        {
            m_eStep = EStep.eEND;
        }

        private void CloseUI()
        {
            LoadFieldStatus();
            if (m_goUIPrefab != null)
            {
                // Thay 'obj' thành 'm_goUIPrefab'
                if (!UnityEditor.EditorUtility.IsPersistent(m_goUIPrefab))
                {
                    Destroy(m_goUIPrefab);
                }
                m_goUIPrefab = null;
            }
            m_eStep = EStep.eNONE;
        }

        private bool FindCommand(EOrderType order)
        {
            if (m_sScript == null || m_sScript.vOrderList == null) return false;
            for (int i = 0; i < m_sScript.vOrderList.Count; i++)
            {
                if (m_sScript.vOrderList[i] != null && m_sScript.vOrderList[i].eOrder == order)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CreateOrder(Order order)
        {
            if (m_sExec != null)
            {
                Destroy(m_sExec.gameObject);
                m_sExec = null;
            }

            if (order == null) return false;

            m_sExec = RegistScript(order.eOrder);
            if (m_sExec == null) return false;

            m_eNowOrder = order.eOrder;
            m_sExec.InitUI(m_sUI);
            m_sExec.Init(order.vsParam, IsSkip);

            return true;
        }

        public void HideWindow()
        {
            if (m_sUI != null && m_sUI.m_sTalk != null)
            {
                m_sUI.m_sTalk.gameObject.SetActive(false);
            }
        }
    }
}