using ADV;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

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
    private eSystemMenuKind m_eSystemMenuKind_Now;

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
        DontDestroyOnLoad(gameObject);

        IsDone = false;
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
        yield return null;
        if (m_eSystemMenuKind_Now == eSystemMenuKind.Title)
        {
            TitleInit();
        }
        SetMenuRequest(m_eSystemMenuKind_Req, true, true, true);
    }

    public void SetMenuRequest(eSystemMenuKind eKind, bool force = false, bool fadein = false, bool fadeout = false)
    {
        UnityEngine.Debug.Log("SetMenuRequest: " + eKind);
        if (eKind != eSystemMenuKind.None && (m_eSystemMenuKind_Req != eKind || force))
        {
            m_eSystemMenuKind_Req = eKind;
            StartCoroutine(ChangeScene(eKind, fadein, fadeout));
        }
    }

    [DebuggerHidden]
    private IEnumerator ChangeScene(eSystemMenuKind next, bool fadein, bool fadeout)
    {
        if (fadein && m_goCoverFrontPrefab != null)
        {
            Instantiate(m_goCoverFrontPrefab);
        }

        m_eSystemMenuKind_Now = next;
        yield return new WaitForSeconds(0.3f);

        if (next == eSystemMenuKind.Title)
        {
            TitleInit();
        }

        if (fadeout && m_goCoverFrontPrefab != null)
        {
            // Xử lý hiệu ứng che/mở màn hình
        }

        IsDone = true;
    }

    private void TitleInit()
    {
        // 1. Khởi tạo lại GameState
        var gameState = GameStateManager.Instance;
        if (gameState != null)
        {
            gameState.Init();
        }

        // 2. Xử lý Background UI nếu cần
        var uiBg = UIBackgroundManager.Instance;
        if (uiBg != null)
        {
            // Thêm các thao tác với uiBg nếu cần thiết tại đây
        }

        // 3. Buộc kết thúc Tutorial (Gọi qua Instance vì ForceEnd() là phương thức non-static)
        var tutorialMgr = TutorialManager.Instance;
        if (tutorialMgr != null)
        {
            tutorialMgr.ForceEnd();
        }

        // 4. Kết thúc ADV Manager
        var advMgr = ADVManager.Instance;
        if (advMgr != null)
        {
            advMgr.SetEnd();
        }

        // 5. Reset trạng thái Photon / Mạng
        PhotonManager.IsTimeOut = false;
        PhotonManager.IsTimeOut_Log = false;

        var photon = PhotonManager.Instance;
        if (photon != null)
        {
            photon.Disconnect();
        }

        // 6. Xóa dữ liệu Multiplayer tạm thời
        SyncData_MultiPlay.Clear();

        // 7. Dừng toàn bộ âm thanh và nhạc nền
        var sound = Sound_Manager.GetInst();
        if (sound != null)
        {
            sound.StopSoundAll();
            sound.StopMusic(true);
        }
    }

    public void SetCover(bool bFlag)
    {
        if (m_goCoverFrontPrefab != null)
        {
            m_goCoverFrontPrefab.SetActive(bFlag);
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
        // Xử lý trạng thái khi ứng dụng tạm dừng
    }
}