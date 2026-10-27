using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    private static Sound_Manager g_scrInst;

    public static readonly eMusicID sc_eMusicID_None;

    private Dictionary<int, AudioClip> m_acMusicClip = new Dictionary<int, AudioClip>();
    private Dictionary<int, AudioClip> m_acSoundClip = new Dictionary<int, AudioClip>();

    private BattleVoice m_sBattleVoice;
    private EnemyVoice m_sEnemyVoice;
    private SystemVoice m_sSystemVoice;
    private Coroutine m_sLoadBGM;

    public GameObject m_goSound_Loop;
    public GameObject m_goSound_OneShot;
    public GameObject m_goVoice_OneShot;
    public MasterSoundList m_sSoundList;

    private Sound_Music m_scrMusicMain;
    private float m_fPrevMusicTime;
    private eMusicID m_ePrevMusicID;
    private eMusicID m_eRecentMusicID;
    private bool m_bPlayADVMusic;
    private bool m_bReverbFlag;
    private GameObject m_goADVVoice;
    private Coroutine m_sLoadADVVoice;
    private float m_fBGMVolumeNow;

    private const string BGM_VOLUME_KEY = "BGMVOLUME";
    private const string SE_VOLUME_KEY = "SEVOLUME";

    public static float BGMVolume
    {
        get => PlayerPrefs.GetFloat(BGM_VOLUME_KEY, 1f);
        set
        {
            PlayerPrefs.SetFloat(BGM_VOLUME_KEY, value);
            if (g_scrInst != null)
            {
                g_scrInst.UpdateVolume();
            }
        }
    }

    public static float SEVolume
    {
        get => PlayerPrefs.GetFloat(SE_VOLUME_KEY, 1f);
        set => PlayerPrefs.SetFloat(SE_VOLUME_KEY, value);
    }

    private void Awake()
    {
        if (g_scrInst != null && g_scrInst != this)
        {
            Destroy(gameObject);
            return;
        }
        g_scrInst = this;
        DontDestroyOnLoad(gameObject);
        Initialize();
    }

    private void OnDestroy()
    {
        if (g_scrInst == this)
        {
            g_scrInst = null;
        }
    }

    public static Sound_Manager GetInst() => g_scrInst;

    private void Initialize()
    {
        // Khởi tạo các thành phần cơ bản nếu cần
    }

    public static string BattleVoiceAssetPath(int chara) => $"Voice/Battle/{chara}";
    public static string SystemVoiceAssetPath(int chara) => $"Voice/System/{chara}";

    public string GetAssetBundlePath(eMusicID musicID)
    {
        return $"Audio/BGM/{musicID.ToString()}";
    }

    public static void SetBGMVolumeLocal(float val)
    {
        BGMVolume = val;
    }

    public string GetMusicAssetName(eMusicID eID)
    {
        return eID.ToString();
    }

    [DebuggerHidden]
    private IEnumerator DownloadBGM(string path, bool bLoop = true, float sample = 0f)
    {
        // Xử lý tải AssetBundle hoặc AudioClip từ path
        yield return null;
    }

    public bool IsOK_MusicReq() => true;

    public void PlayPrevMusic(bool bLoop = true)
    {
        if (m_ePrevMusicID != sc_eMusicID_None)
        {
            PlayMusic(m_ePrevMusicID, bLoop, m_fPrevMusicTime);
        }
    }

    public void PlayMusic_ADV(eMusicID eID, bool bLoop = true, float sample = 0f)
    {
        PlayMusic(eID, bLoop, sample, true);
    }

    public void PlayMusic(eMusicID eID, bool bLoop = true, float sample = 0f, bool isADV = false)
    {
        m_ePrevMusicID = m_eRecentMusicID;
        m_eRecentMusicID = eID;
        m_bPlayADVMusic = isADV;

        // Logic gọi phát nhạc chính thông qua m_scrMusicMain
        if (m_sLoadBGM != null)
        {
            StopCoroutine(m_sLoadBGM);
        }
        m_sLoadBGM = StartCoroutine(DownloadBGM(GetAssetBundlePath(eID), bLoop, sample));
    }

    public void PlayMusic_AudioClip(AudioClip acClip, bool bLoop = true, float sample = 0f)
    {
        StopMusic(true);
        if (m_scrMusicMain != null)
        {
            // Cài đặt phát trực tiếp AudioClip
        }
    }

    public void StopMusic(bool bFade = true)
    {
        if (m_scrMusicMain != null)
        {
            if (m_scrMusicMain.gameObject != null)
            {
                Destroy(m_scrMusicMain.gameObject);
            }
            m_scrMusicMain = null;
        }
    }

    public eMusicID GetPlayMusicID() => m_eRecentMusicID;
    public float GetNowMusicTime() => m_scrMusicMain != null ? 0f : 0f; // Lấy thời gian hiện tại từ AudioSource nếu có
    public float GetPrevMusicTime() => m_fPrevMusicTime;
    public eMusicID GetPrevMusicID() => m_ePrevMusicID;
    public bool IsPlayADVMusic() => m_bPlayADVMusic;

    public void StopSoundAll()
    {
        if (m_goSound_OneShot != null)
        {
            foreach (Transform child in m_goSound_OneShot.transform)
            {
                if (child != null) Destroy(child.gameObject);
            }
        }
        if (m_goSound_Loop != null)
        {
            foreach (Transform child in m_goSound_Loop.transform)
            {
                if (child != null) Destroy(child.gameObject);
            }
        }
    }

    public Sound_OneShot PlaySound(string fileName, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        // Tải và phát SE từ tên file
        return null;
    }

    public Sound_OneShot PlaySound(eSoundID eID, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return PlaySound(eID.ToString(), fWaitSec, trTemp, fVolume, bTimeScale);
    }

    public Sound_OneShot PlaySound_AudioClip(AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (acOrigin == null || m_goSound_OneShot == null) return null;

        GameObject obj = MakeAudioObject(false, m_goSound_OneShot, acOrigin, fWaitSec, trTemp, fVolume, bTimeScale);
        return obj != null ? obj.GetComponent<Sound_OneShot>() : null;
    }

    public Sound_Loop PlayLoopSound(eSoundID eID, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (m_goSound_Loop == null) return null;
        // Logic phát loop sound tương tự
        return null;
    }

    public Sound_Loop PlayLoopSound_AudioClip(AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (acOrigin == null || m_goSound_Loop == null) return null;

        GameObject obj = MakeAudioObject(true, m_goSound_Loop, acOrigin, fWaitSec, trTemp, fVolume, bTimeScale);
        return obj != null ? obj.GetComponent<Sound_Loop>() : null;
    }

    private GameObject MakeAudioObject(bool loopFlag, GameObject goPrefab, AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (goPrefab == null) return null;
        GameObject soundObj = Instantiate(goPrefab, trTemp != null ? trTemp.position : Vector3.zero, Quaternion.identity);
        soundObj.transform.SetParent(goPrefab.transform);

        AudioSource source = soundObj.GetComponent<AudioSource>();
        if (source != null)
        {
            source.clip = acOrigin;
            source.loop = loopFlag;
            source.volume = fVolume * SEVolume;
            if (fWaitSec > 0f) source.PlayDelayed(fWaitSec);
            else source.Play();
        }
        return soundObj;
    }

    public void LoadBattleVoice(List<int> charaList, List<int> enemyList = null) { }
    public bool IsLoadingVoice() => false;
    public void ReleaseBattleVoice() { }

    public Sound_OneShot PlayVoice(int chara, EBattleVoiceID eID) => null;
    public Sound_OneShot PlayVoice(eEnemyKind kind, EBattleVoiceID eID) => null;
    public bool IsExistVoice(int charaDF, EBattleVoiceID eID) => false;

    public void LoadSystemVoice(List<int> charaList) { }
    public void LoadSystemVoice(int chara) { }
    public bool IsLoadingSystemVoice() => false;
    public bool IsLoadedSystemVoice(int chara) => false;
    public void ReleaseSystemVoice() { }
    public void ReleaseSystemVoice(int chara) { }
    public bool IsExistVoice(int chara, ESystemVoiceID eID) => false;
    public Sound_OneShot PlayWhoVoice(int chara, ESystemVoiceID eID) => null;
    public Sound_OneShot PlayVoice(int chara, ESystemVoiceID eID) => null;
    public void PlayVoice(int chara, EOtherVoice eID) { }
    public void PlayTitleCallVoice() { }

    [DebuggerHidden]
    private IEnumerator DownloadSystemVoice(int chara, EOtherVoice eID)
    {
        yield return null;
    }

    public void PlayVoice(string path, bool adv = true) { }

    [DebuggerHidden]
    private IEnumerator DownloadVoice(string path, bool adv)
    {
        yield return null;
    }

    public void StopADVVoice(bool stopCoroutine = true) { }
    public bool IsPlayADVVoice() => false;

    public void UpdateVolume()
    {
        // Cập nhật âm lượng cho các AudioSource đang chạy
    }

    public void SetReverb(bool enabled)
    {
        m_bReverbFlag = enabled;
    }
}