using ADV;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class System_MenuManager : MonoBehaviour
{
    public enum eSystemMenuKind
    {
        None = -1,
        Title = 0,
        Academy = 1,
        Field = 2,
        Opening = 3,
        EnumMax = 4
    }

    private static readonly int LOG_CACHE_MAX = 100;

    private static System_MenuManager g_scrInst;

    [field: SerializeField]
    public bool IsDone { get; set; }

    [SerializeField]
    private eSystemMenuKind m_eSystemMenuKind_Now = eSystemMenuKind.None;

    public eSystemMenuKind m_eSystemMenuKind_Req;

    public GameObject m_goCoverFrontPrefab;

    private GameObject m_goTouchBlockCollision;

    private DialogError m_sErrorDialog;

    private List<string> logList = new List<string>();

    private void Awake()
    {
        if (g_scrInst != null && g_scrInst != this)
        {
            Destroy(gameObject);
            return;
        }

        g_scrInst = this;
        if (transform.parent == null)
        {
            DontDestroyOnLoad(gameObject);
        }

        IsDone = false;
        m_eSystemMenuKind_Now = eSystemMenuKind.None;
        Application.targetFrameRate = 30;
        QualitySettings.vSyncCount = 0;

        System_TimeManager.SetTimeScale_Default();
        System_InputManager.SetMultiTouch(false);
    }

    public static System_MenuManager GetInst()
    {
        return g_scrInst;
    }

    public eSystemMenuKind GetNowMenu()
    {
        return m_eSystemMenuKind_Now;
    }

    public static bool IsMapArea()
    {
        bool isField = IsField();
        var gameMgr = Game_Manager.GetInst();
        if (gameMgr != null)
        {
            int areaKind = (int)gameMgr.GetAreaKind();
            return isField && (areaKind != 2);
        }
        return false;
    }

    public static bool IsField()
    {
        return g_scrInst != null && g_scrInst.m_eSystemMenuKind_Now == eSystemMenuKind.Field;
    }

    public static bool IsVillage()
    {
        bool isField = IsField();
        if (isField)
        {
            var gameMgr = Game_Manager.GetInst();
            if (gameMgr != null)
            {
                int areaKind = (int)gameMgr.GetAreaKind();
                return areaKind == 2;
            }
        }
        return false;
    }

    private float GetDeltaTime()
    {
        return Time.deltaTime;
    }

    [DebuggerHidden]
    private IEnumerator Start()
    {
        while (!IsDone)
        {
            yield return null;
        }
        SetMenuRequest(m_eSystemMenuKind_Req, true, true, true);
    }

    public void SetMenuRequest(eSystemMenuKind eKind, bool force = false, bool fadein = false, bool fadeout = false)
    {
        UnityEngine.Debug.Log("SetMenuRequest: " + eKind);
        if (eKind != eSystemMenuKind.None && (m_eSystemMenuKind_Now != eKind || force))
        {
            StartCoroutine(ChangeScene(eKind, fadein, fadeout));
        }
    }

    [DebuggerHidden]
    private IEnumerator ChangeScene(eSystemMenuKind next, bool fadein, bool fadeout)
    {
        m_eSystemMenuKind_Req = next;

        if (fadein && LoadingManager.IsExist)
        {
            LoadingManager.Enable(0.5f);
            while (!LoadingManager.IsBlackOut)
            {
                yield return null;
            }
        }

        if (PhotonManager.Instance != null && PhotonManager.Instance.IsInRoom())
        {
            PhotonManager.Instance.LeaveRoom(null);
            while (PhotonManager.Instance.IsInRoom())
            {
                yield return null;
            }
        }

        SyncData_MultiPlay.ClearMemberState();
        SyncData_MultiPlay.Clear();
        PhotonMatching.ClearIgnoreRoom();

        SceneManager.LoadScene("Empty");
        System_TimeManager.SetTimeScale_Default();

        if (Game_UI_Common.IsExist)
        {
            Game_UI_Common.Instance.DispDisable();
        }
        if (InformationManager.IsExist)
        {
            InformationManager.Instance.Clear(true);
        }

        if (next == eSystemMenuKind.Title)
        {
            TitleInit();
        }

        yield return StartCoroutine(AssetBundleManager.UnloadForce());
        yield return StartCoroutine(Util.UnusedAssets());

        string sceneName = "Title";
        switch (next)
        {
            case eSystemMenuKind.Title:
                sceneName = "Title";
                break;
            case eSystemMenuKind.Academy:
                sceneName = "Academy";
                break;
            case eSystemMenuKind.Field:
                sceneName = "Field";
                break;
            case eSystemMenuKind.Opening:
                sceneName = "Opening";
                break;
        }

        AsyncOperation asyncOp = SceneManager.LoadSceneAsync(sceneName);
        if (asyncOp != null)
        {
            while (!asyncOp.isDone)
            {
                yield return null;
            }
        }

        m_eSystemMenuKind_Now = next;

        if (fadeout && LoadingManager.IsExist)
        {
            LoadingManager.Disable(0.5f);
            while (!LoadingManager.IsEnd)
            {
                yield return null;
            }
        }
    }

    private void TitleInit()
    {
        var gameState = GameStateManager.Instance;
        if (gameState != null)
        {
            gameState.Init();
        }

        if (Game_UI_Common.IsExist)
        {
            Game_UI_Common.Instance.CreateInstance();
        }

        if (TutorialManager.IsExist)
        {
            TutorialManager.Instance.ForceEnd();
        }

        if (ADVManager.IsInstance && ADVManager.Instance != null)
        {
            ADVManager.Instance.SetEnd();
        }

        PhotonManager.IsTimeOut = false;
        PhotonManager.IsTimeOut_Log = false;

        var photon = PhotonManager.Instance;
        if (photon != null)
        {
            photon.Disconnect();
        }

        SyncData_MultiPlay.Clear();

        var sound = Sound_Manager.GetInst();
        if (sound != null)
        {
            sound.StopSoundAll();
            sound.StopMusic(true);
        }
    }

    public void SetCover(bool bFlag)
    {
        if (bFlag)
        {
            if (m_goTouchBlockCollision == null && m_goCoverFrontPrefab != null)
            {
                m_goTouchBlockCollision = Instantiate(m_goCoverFrontPrefab);
                DontDestroyOnLoad(m_goTouchBlockCollision);
            }
        }
        else if (m_goTouchBlockCollision != null)
        {
            Destroy(m_goTouchBlockCollision);
            m_goTouchBlockCollision = null;
        }
    }

    private void ReceivedLog(string condition, string stackTrace, LogType type)
    {
        logList.Add(condition);
        if (logList.Count > LOG_CACHE_MAX)
        {
            logList.RemoveAt(0);
        }
    }

    private void OnApplicationPause(bool isPaused)
    {
    }
}
