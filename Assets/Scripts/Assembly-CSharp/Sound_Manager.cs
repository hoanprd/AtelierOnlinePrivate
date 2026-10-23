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
        get
        {
            return PlayerPrefs.GetFloat(BGM_VOLUME_KEY, 1f);
        }
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
        get
        {
            return PlayerPrefs.GetFloat(SE_VOLUME_KEY, 1f);
        }
        set
        {
            PlayerPrefs.SetFloat(SE_VOLUME_KEY, value);
        }
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
    }

    private void OnDestroy()
    {
        if (g_scrInst == this)
        {
            g_scrInst = null;
        }
    }

    public static Sound_Manager GetInst()
    {
        return g_scrInst;
    }

    public static string BattleVoiceAssetPath(int chara)
    {
        return null;
    }

    public static string SystemVoiceAssetPath(int chara)
    {
        return null;
    }

    public string GetAssetBundlePath(eMusicID musicID)
    {
        return null;
    }

    public static void SetBGMVolumeLocal(float val)
    {
        BGMVolume = val;
    }

    public string GetMusicAssetName(eMusicID eID)
    {
        return null;
    }

    [DebuggerHidden]
    private IEnumerator DownloadBGM(string path, bool bLoop = true, float sample = 0f)
    {
        return null;
    }

    private void Initialize()
    {
    }

    public bool IsOK_MusicReq()
    {
        return true;
    }

    public void PlayPrevMusic(bool bLoop = true)
    {
    }

    public void PlayMusic_ADV(eMusicID eID, bool bLoop = true, float sample = 0f)
    {
    }

    public void PlayMusic(eMusicID eID, bool bLoop = true, float sample = 0f, bool isADV = false)
    {
    }

    public void PlayMusic_AudioClip(AudioClip acClip, bool bLoop = true, float sample = 0f)
    {
    }

    public void StopMusic(bool bFade = true)
    {
        if (m_scrMusicMain != null)
        {
            Destroy(m_scrMusicMain.gameObject);
            m_scrMusicMain = null;
        }
    }

    public eMusicID GetPlayMusicID()
    {
        return m_eRecentMusicID;
    }

    public float GetNowMusicTime()
    {
        return 0f;
    }

    public float GetPrevMusicTime()
    {
        return m_fPrevMusicTime;
    }

    public eMusicID GetPrevMusicID()
    {
        return m_ePrevMusicID;
    }

    public bool IsPlayADVMusic()
    {
        return m_bPlayADVMusic;
    }

    public void StopSoundAll()
    {
        if (m_goSound_OneShot != null)
        {
            foreach (Transform child in m_goSound_OneShot.transform)
            {
                Destroy(child.gameObject);
            }
        }
        if (m_goSound_Loop != null)
        {
            foreach (Transform child in m_goSound_Loop.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }

    public Sound_OneShot PlaySound(string fileName, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return null;
    }

    public Sound_OneShot PlaySound(eSoundID eID, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return null;
    }

    public Sound_OneShot PlaySound_AudioClip(AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return null;
    }

    public Sound_Loop PlayLoopSound(eSoundID eID, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return null;
    }

    public Sound_Loop PlayLoopSound_AudioClip(AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return null;
    }

    private GameObject MakeAudioObject(bool loopFlag, GameObject goPrefab, AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        return null;
    }

    public void LoadBattleVoice(List<int> charaList, List<int> enemyList = null)
    {
    }

    public bool IsLoadingVoice()
    {
        return false;
    }

    public void ReleaseBattleVoice()
    {
    }

    public Sound_OneShot PlayVoice(int chara, EBattleVoiceID eID)
    {
        return null;
    }

    public Sound_OneShot PlayVoice(eEnemyKind kind, EBattleVoiceID eID)
    {
        return null;
    }

    public bool IsExistVoice(int charaDF, EBattleVoiceID eID)
    {
        return false;
    }

    public void LoadSystemVoice(List<int> charaList)
    {
    }

    public void LoadSystemVoice(int chara)
    {
    }

    public bool IsLoadingSystemVoice()
    {
        return false;
    }

    public bool IsLoadedSystemVoice(int chara)
    {
        return false;
    }

    public void ReleaseSystemVoice()
    {
    }

    public void ReleaseSystemVoice(int chara)
    {
    }

    public bool IsExistVoice(int chara, ESystemVoiceID eID)
    {
        return false;
    }

    public Sound_OneShot PlayWhoVoice(int chara, ESystemVoiceID eID)
    {
        return null;
    }

    public Sound_OneShot PlayVoice(int chara, ESystemVoiceID eID)
    {
        return null;
    }

    public void PlayVoice(int chara, EOtherVoice eID)
    {
    }

    public void PlayTitleCallVoice()
    {
    }

    [DebuggerHidden]
    private IEnumerator DownloadSystemVoice(int chara, EOtherVoice eID)
    {
        return null;
    }

    public void PlayVoice(string path, bool adv = true)
    {
    }

    [DebuggerHidden]
    private IEnumerator DownloadVoice(string path, bool adv)
    {
        return null;
    }

    public void StopADVVoice(bool stopCoroutine = true)
    {
    }

    public bool IsPlayADVVoice()
    {
        return false;
    }

    public void UpdateVolume()
    {
    }

    public void SetReverb(bool enabled)
    {
    }
}