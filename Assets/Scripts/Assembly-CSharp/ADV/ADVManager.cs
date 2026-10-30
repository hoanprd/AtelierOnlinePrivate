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

        public static ADVManager Instance
        {
            get
            {
                if (s_sIntance == null)
                {
                    s_sIntance = FindAnyObjectByType<ADVManager>();
                }
                if (s_sIntance == null)
                {
                    GameObject prefab = Resources.Load<GameObject>("system/child/ADV_Manager");
                    if (prefab != null)
                    {
                        GameObject go = Instantiate(prefab);
                        go.name = "ADV_Manager";
                        s_sIntance = go.GetComponent<ADVManager>();
                    }
                }
                if (s_sIntance == null)
                {
                    GameObject go = new GameObject("ADVManager");
                    s_sIntance = go.AddComponent<ADVManager>();
                }
                return s_sIntance;
            }
        }

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
                if (Application.isPlaying)
                {
                    Destroy(gameObject);
                }
                else
                {
                    DestroyImmediate(gameObject);
                }
                return;
            }
            s_sIntance = this;

            if (m_sUI == null && m_goUIPrefab != null && m_trUIRoot != null)
            {
                GameObject uiObj = Util.InstantiateInChildren(m_goUIPrefab, m_trUIRoot);
                if (uiObj != null)
                {
                    m_sUI = uiObj.GetComponent<UIManager>();
                    if (m_sUI != null)
                    {
                        m_sUI.Init();
                    }
                }
            }

            if (m_trUIRoot != null)
            {
                m_trUIRoot.gameObject.SetActive(false);
            }
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
            m_sScript = null;
            m_eStep = EStep.eLOAD_SCRIPT;
        }

        public void LoadStart(ScriptInfo script)
        {
            Init();
            m_sScript = script;
            m_sADVFilePath = (script != null) ? script.name : "";
            m_sScriptPath = "";
            m_eStep = EStep.eLOAD_SCRIPT;
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
            CancelInvoke();
            m_bError = false;
            m_sErrorLog = null;
            m_sExec = null;
            m_eStep = EStep.eLOAD_SCRIPT;
            m_iProgress = 0;
            m_eNowOrder = EOrderType.eNONE;

            if (m_trUIRoot != null)
            {
                m_trUIRoot.gameObject.SetActive(true);
            }

            SetSkip(false);
            m_isNotLoadFieldStatus = false;

            if (m_vScripts != null)
            {
                for (int i = 0; i < m_vScripts.Count; i++)
                {
                    if (m_vScripts[i] != null)
                    {
                        Destroy(m_vScripts[i]);
                    }
                }
                m_vScripts.Clear();
            }
            else
            {
                m_vScripts = new List<ScriptBase>();
            }

            if (m_vLoadAssetPath != null)
            {
                m_vLoadAssetPath.Clear();
            }
            else
            {
                m_vLoadAssetPath = new List<string>();
            }
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

            if (m_sScript != null)
            {
                m_eStep = EStep.eLOAD_ASSET;
                return;
            }

            // Fallback Offline Client Mode
            ScriptInfo loaded = Resources.Load<ScriptInfo>(m_sScriptPath);
            if (loaded == null)
            {
                loaded = Resources.Load<ScriptInfo>("ADV/" + m_sADVFilePath);
            }
            if (loaded == null)
            {
                loaded = CreateOfflineScript(m_sADVFilePath);
            }

            m_sScript = loaded;
            m_eStep = EStep.eLOAD_ASSET;
        }

        public static ScriptInfo CreateOfflineScript(string scriptPath)
        {
            ScriptInfo info = ScriptableObject.CreateInstance<ScriptInfo>();
            info.name = scriptPath;
            info.vOrderList = new List<Order>();

            string scriptKey = scriptPath.Replace("ADV/Scripts/", "").Replace("ADV/", "");

            if (scriptKey == "t_0101")
            {
                // Mở đầu Bressisle: Prologue đảo + Lời tự sự
                info.vOrderList.Add(new Order { eOrder = EOrderType.ePROLOGUE, vsParam = new List<string> { "1" } });
                // BGM Học viện Hoàng Gia
                info.vOrderList.Add(new Order { eOrder = EOrderType.eMUSIC, vsParam = new List<string> { "1" } });
                // Bối cảnh Học viện
                info.vOrderList.Add(new Order { eOrder = EOrderType.eBG, vsParam = new List<string> { "1", "王立アカデミー", "" } });
                // Cutscene thoại bí ẩn mở đầu
                info.vOrderList.Add(new Order { eOrder = EOrderType.eCHARA_TALK, vsParam = new List<string> { "???", "……ごめんね、ウィステリア。いつか、わたし……" } });
                // Chờ ngắn
                info.vOrderList.Add(new Order { eOrder = EOrderType.eWAIT, vsParam = new List<string> { "0.5", "1" } });
            }
            else if (scriptKey == "t_0102")
            {
                // Cắt cảnh tiếp theo tại Học viện
                info.vOrderList.Add(new Order { eOrder = EOrderType.eBG, vsParam = new List<string> { "1", "王立アカデミー", "" } });
                info.vOrderList.Add(new Order { eOrder = EOrderType.eCHARA_TALK, vsParam = new List<string> { "学長", "ようこそ、王立アカデミーへ！" } });
                info.vOrderList.Add(new Order { eOrder = EOrderType.eCHARA_TALK, vsParam = new List<string> { "学長", "これからあなたの冒険が始まります。" } });
                info.vOrderList.Add(new Order { eOrder = EOrderType.eWAIT, vsParam = new List<string> { "0.5", "1" } });
            }
            else
            {
                info.vOrderList.Add(new Order { eOrder = EOrderType.eWAIT, vsParam = new List<string> { "0.1", "1" } });
            }

            return info;
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
            if (m_vScripts == null)
            {
                m_vScripts = new List<ScriptBase>();
            }
            else
            {
                for (int i = 0; i < m_vScripts.Count; i++)
                {
                    if (m_vScripts[i] != null)
                    {
                        Destroy(m_vScripts[i]);
                    }
                }
                m_vScripts.Clear();
            }

            if (m_sScript != null && m_sScript.vOrderList != null)
            {
                for (int i = 0; i < m_sScript.vOrderList.Count; i++)
                {
                    Order order = m_sScript.vOrderList[i];
                    if (order != null)
                    {
                        ScriptBase script = RegistScript(order.eOrder);
                        if (script != null)
                        {
                            script.SetParam(order.vsParam);
                            m_vScripts.Add(script);
                        }
                    }
                }
            }

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
            switch (kind)
            {
                case EOrderType.eFADE: return gameObject.AddComponent<ScriptFade>();
                case EOrderType.eWAIT: return gameObject.AddComponent<ScriptWait>();
                case EOrderType.eMUSIC: return gameObject.AddComponent<ScriptBGM>();
                case EOrderType.eVOICE_ADV: return gameObject.AddComponent<ScriptVoiceADV>();
                case EOrderType.eSOUNDEFFECT: return gameObject.AddComponent<ScriptSE>();
                case EOrderType.eEFFECT_STOP: return gameObject.AddComponent<ScriptEffectDelete>();
                case EOrderType.eCAMERA_ZOOM: return gameObject.AddComponent<ScriptCameraZoom>();
                case EOrderType.eCHARA_TALK: return gameObject.AddComponent<ScriptTalk>();
                case EOrderType.eSELECTION: return gameObject.AddComponent<ScriptSelection>();
                case EOrderType.eANSWER: return gameObject.AddComponent<ScriptAnswer>();
                case EOrderType.eIF_GENDER: return gameObject.AddComponent<ScriptIfGender>();
                case EOrderType.eIF_FAVORITE: return gameObject.AddComponent<ScriptIfFavorite>();
                case EOrderType.eEND_IF: return gameObject.AddComponent<ScriptEndIf>();
                case EOrderType.eBLACK_FILTER: return gameObject.AddComponent<ScriptBlackFilter>();
                case EOrderType.eTUTORIAL_PIC: return gameObject.AddComponent<ScriptPicture>();
                case EOrderType.eTUTORIAL_PIC_OUT: return gameObject.AddComponent<ScriptPictureClose>();
                case EOrderType.eWINDOW_POS: return gameObject.AddComponent<ScriptWindowPos>();
                case EOrderType.eCAMERA_TARGET: return gameObject.AddComponent<ScriptCameraTarget>();
                case EOrderType.eENABLE_SKIP: return gameObject.AddComponent<ScriptEnableSkip>();
                case EOrderType.eFAIRY_APPEAR: return gameObject.AddComponent<ScriptFairyAppear>();
                case EOrderType.eFAIRY_MOVE: return gameObject.AddComponent<ScriptFairyMove>();
                case EOrderType.eFAIRY_MOVE_2D: return gameObject.AddComponent<ScriptFairyMove2D>();
                case EOrderType.eFAIRY_MOVE_3D: return gameObject.AddComponent<ScriptFairyMove3D>();
                case EOrderType.eFAIRY_WAIT: return gameObject.AddComponent<ScriptFairyWait>();
                case EOrderType.eFAIRY_PICK: return gameObject.AddComponent<ScriptFairyPick>();
                case EOrderType.eFAIRY_ROT: return gameObject.AddComponent<ScriptFairyRot>();
                case EOrderType.eFAIRY_ROT_2D: return gameObject.AddComponent<ScriptFairyRot2D>();
                case EOrderType.eFAIRY_ROT_3D: return gameObject.AddComponent<ScriptFairyRot3D>();
                case EOrderType.eFAIRY_BANISH: return gameObject.AddComponent<ScriptFairyBanish>();
                case EOrderType.eBG: return gameObject.AddComponent<ScriptBackground>();
                case EOrderType.eBG_CLOSE: return gameObject.AddComponent<ScriptBackgroundClose>();
                case EOrderType.eBG_SHAKE: return gameObject.AddComponent<ScriptBackgroundShake>();
                case EOrderType.eCHARA_TALK_EMOTION: return gameObject.AddComponent<ScriptTalkCharaEmotion>();
                case EOrderType.eFIELD_PICTURE: return gameObject.AddComponent<ScriptFieldPicture>();
                case EOrderType.eFAIRY_MOVE_WAIT: return gameObject.AddComponent<ScriptFairyMoveWait>();
                case EOrderType.eARROW_UI: return gameObject.AddComponent<ScriptArrowUI>();
                case EOrderType.ePROLOGUE: return gameObject.AddComponent<ScriptPrologue>();
                case EOrderType.eCHARA_EMOTICON:
                case EOrderType.eEMOTICON: return gameObject.AddComponent<ScriptEmoticon>();
                case EOrderType.eFIELD_ANIM: return gameObject.AddComponent<ScriptFieldAnim>();
                case EOrderType.eNPC_POP1: return gameObject.AddComponent<ScriptNPCPop>();
                case EOrderType.eNPC_POP2: return gameObject.AddComponent<ScriptNPCPop2>();
                case EOrderType.eNPC_MOVE: return gameObject.AddComponent<ScriptNPCMove>();
                case EOrderType.eENEMY_POP1: return gameObject.AddComponent<ScriptEnemyPop>();
                case EOrderType.eENEMY_POP2: return gameObject.AddComponent<ScriptEnemyPop2>();
                case EOrderType.eENEMY_MOVE: return gameObject.AddComponent<ScriptEnemyMove>();
                case EOrderType.eENEMY_AI: return gameObject.AddComponent<ScriptEnemyAI>();
                case EOrderType.eNPC_ROTATE: return gameObject.AddComponent<ScriptNPCRotate>();
                case EOrderType.eNPC_ROTATE2: return gameObject.AddComponent<ScriptNPCRotate2>();
                case EOrderType.eENEMY_ROTATE: return gameObject.AddComponent<ScriptEnemyRotate>();
                case EOrderType.eENEMY_ROTATE2: return gameObject.AddComponent<ScriptEnemyRotate2>();
                case EOrderType.eNPC_MOTION: return gameObject.AddComponent<ScriptNPCMotion>();
                case EOrderType.eENEMY_MOTION: return gameObject.AddComponent<ScriptEnemyMotion>();
                case EOrderType.eFAIRY_MOVE_OBJ: return gameObject.AddComponent<ScriptFairyMoveObj>();
                case EOrderType.eEMOTICON_3D: return gameObject.AddComponent<ScriptEmoticon3D>();
                case EOrderType.eBATTLE_ENCOUNT: return gameObject.AddComponent<ScriptBattleEncount>();
                case EOrderType.eRESERVE_BATTLE_DESTROY: return gameObject.AddComponent<ScriptReserveDestroyAfterBattle>();
                case EOrderType.ePLAYER_MOVE: return gameObject.AddComponent<ScriptPlayerMove>();
                case EOrderType.ePLAYER_ROTATE: return gameObject.AddComponent<ScriptPlayerRotate>();
                case EOrderType.ePLAYER_ROTATE2: return gameObject.AddComponent<ScriptPlayerRotate2>();
                case EOrderType.eFAIRY_EMOTICON: return gameObject.AddComponent<ScriptFairyEmoticon>();
                case EOrderType.eEFFECT_POS: return gameObject.AddComponent<ScriptEffect>();
                case EOrderType.eEFFECT_OBJ: return gameObject.AddComponent<ScriptEffectObj>();
                case EOrderType.eFAIRY_EFFECT: return gameObject.AddComponent<ScriptFairyEffect>();
                case EOrderType.eUI_ACTIVE: return gameObject.AddComponent<ScriptUIActive>();
                case EOrderType.eSEPIA: return gameObject.AddComponent<ScriptSepia>();
                case EOrderType.eBG_BLACK: return gameObject.AddComponent<ScriptBackgroundBlack>();
                case EOrderType.eENEMY_EFFECT: return gameObject.AddComponent<ScriptEnemyEffect>();
                case EOrderType.eWINDOW_ITEM: return gameObject.AddComponent<ScriptItemWindow>();
                case EOrderType.eDISP_GUIDE: return gameObject.AddComponent<ScriptGuide>();
                case EOrderType.eJUMP_REQUEST: return gameObject.AddComponent<ScriptJumpRequest>();
                case EOrderType.ePLAYER_APPEAR: return gameObject.AddComponent<ScriptPlayerAppear>();
                case EOrderType.eTARGETARROW: return gameObject.AddComponent<ScriptTargetArrow>();
                case EOrderType.eTARGETARROWOFF: return gameObject.AddComponent<ScriptTargetArrowOFF>();
                case EOrderType.eAUTO_APPEAR: return gameObject.AddComponent<ScriptSkipAppear>();
                case EOrderType.eAUTO_STOP: return gameObject.AddComponent<ScriptSkipStop>();
                case EOrderType.eCAMERA_TARGET_OBJ: return gameObject.AddComponent<ScriptCameraTargetObj>();
                case EOrderType.ePICTURE: return gameObject.AddComponent<ScriptPicture>();
                case EOrderType.ePICTURE_CLOSE: return gameObject.AddComponent<ScriptPictureClose>();
                case EOrderType.eVOICE_ADV_PLAYER: return gameObject.AddComponent<ScriptVoiceADVPlayer>();
                case EOrderType.eTALK_END: return gameObject.AddComponent<ScriptTalkEnd>();
                case EOrderType.eDUNGEON_REQUEST: return gameObject.AddComponent<ScriptDungeonRequest>();
                default:
                    Debug.LogWarning("ADVManager.RegistScript: unhandled order type " + kind);
                    return null;
            }
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

                case 2: // eLOAD_SCRIPT_WAIT
                    m_eStep = EStep.eLOAD_ASSET;
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
                    // Offline Client Mode: All assets ready immediately
                    m_eStep = EStep.eSTART;
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
            else
            {
                Next();
            }
        }

        private void PlayStart()
        {
            Sound_Manager inst = Sound_Manager.GetInst();
            if (inst != null && m_sRollbackInfo != null)
            {
                Sound_Manager.BGMVolume = m_sRollbackInfo.fBGMVol * csSOUND_VOLUME;
                inst.UpdateVolume();
            }

            m_iProgress = 0;
            m_eStep = EStep.ePLAY;

            if (m_sScript != null && m_sScript.vOrderList != null && m_sScript.vOrderList.Count > 0)
            {
                CreateOrder(m_sScript.vOrderList[0]);
            }
            else
            {
                SetEnd();
            }
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
            m_sExec = null;
        }

        public void SetEnd()
        {
            m_eStep = EStep.eEND;
        }

        private void CloseUI()
        {
            LoadFieldStatus();
            if (m_vScripts != null)
            {
                for (int i = 0; i < m_vScripts.Count; i++)
                {
                    if (m_vScripts[i] != null)
                    {
                        Destroy(m_vScripts[i]);
                    }
                }
                m_vScripts.Clear();
            }
            m_sExec = null;

            if (m_sUI != null && m_sUI.m_sTalk != null)
            {
                m_sUI.m_sTalk.gameObject.SetActive(false);
            }
            if (m_trUIRoot != null)
            {
                m_trUIRoot.gameObject.SetActive(false);
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
            if (order == null) return false;

            if (m_vScripts != null && m_iProgress >= 0 && m_iProgress < m_vScripts.Count)
            {
                m_sExec = m_vScripts[m_iProgress];
            }
            else
            {
                m_sExec = RegistScript(order.eOrder);
            }

            if (m_sExec == null) return false;

            m_eNowOrder = order.eOrder;
            m_sExec.InitUI(m_sUI);
            bool finishImmediately = m_sExec.Init(order.vsParam, IsSkip);

            if (finishImmediately)
            {
                m_eNowOrder = EOrderType.eNONE;
                Next();
            }

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
