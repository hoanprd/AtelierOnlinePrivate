using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    private static Sound_Manager g_scrInst;

    public static readonly eMusicID sc_eMusicID_None = eMusicID.None;

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
    private eMusicID m_ePrevMusicID = eMusicID.None;
    private eMusicID m_eRecentMusicID = eMusicID.None;
    private bool m_bPlayADVMusic;
    private bool m_bReverbFlag;
    private GameObject m_goADVVoice;
    private Coroutine m_sLoadADVVoice;
    private float m_fBGMVolumeNow = 1f;

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
        set
        {
            PlayerPrefs.SetFloat(SE_VOLUME_KEY, value);
            if (g_scrInst != null)
            {
                g_scrInst.UpdateVolume();
            }
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
        if (transform.parent == null)
        {
            DontDestroyOnLoad(gameObject);
        }
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
        System_GlobalValue.GetUserInfo().stOptionData.Initialize();
        m_scrMusicMain = gameObject.GetComponent<Sound_Music>();
        if (m_scrMusicMain == null)
        {
            m_scrMusicMain = gameObject.AddComponent<Sound_Music>();
        }
        m_acMusicClip = new Dictionary<int, AudioClip>();
        m_acSoundClip = new Dictionary<int, AudioClip>();

        if (m_sSoundList != null)
        {
            if (m_sSoundList.BGM != null)
            {
                for (int i = 0; i < m_sSoundList.BGM.Count; i++)
                {
                    SoundData data = m_sSoundList.BGM[i];
                    if (data != null && !string.IsNullOrEmpty(data.sFilePath))
                    {
                        string cleanName = Path.GetFileNameWithoutExtension(data.sFilePath);
                        AudioClip clip = Resources.Load<AudioClip>("sound/music/" + cleanName);
                        if (clip == null)
                        {
                            clip = Resources.Load<AudioClip>("Sound/Music/" + data.sFilePath);
                        }
                        if (clip != null)
                        {
                            m_acMusicClip[data.iID] = clip;
                        }
                    }
                }
            }
            if (m_sSoundList.SE != null)
            {
                for (int i = 0; i < m_sSoundList.SE.Count; i++)
                {
                    SoundData data = m_sSoundList.SE[i];
                    if (data != null && !string.IsNullOrEmpty(data.sFilePath))
                    {
                        string cleanName = Path.GetFileNameWithoutExtension(data.sFilePath);
                        AudioClip clip = Resources.Load<AudioClip>("sound/sound/" + cleanName);
                        if (clip == null)
                        {
                            clip = Resources.Load<AudioClip>("Sound/Sound/" + data.sFilePath);
                        }
                        if (clip != null)
                        {
                            m_acSoundClip[data.iID] = clip;
                        }
                    }
                }
            }
        }
    }

    public static string BattleVoiceAssetPath(int chara) => $"Voice/Battle/{chara}";
    public static string SystemVoiceAssetPath(int chara) => $"Voice/System/{chara}";

    public string GetAssetBundlePath(eMusicID musicID)
    {
        string assetName = GetMusicAssetName(musicID);
        return string.IsNullOrEmpty(assetName) ? $"sound/music/{musicID}" : $"sound/music/{assetName}";
    }

    public static void SetBGMVolumeLocal(float val)
    {
        if (g_scrInst != null)
        {
            g_scrInst.m_fBGMVolumeNow = val;
            g_scrInst.UpdateVolume();
        }
    }

    public string GetMusicAssetName(eMusicID eID)
    {
        if (m_sSoundList != null && m_sSoundList.BGM != null)
        {
            SoundData found = m_sSoundList.BGM.Find(x => x != null && x.iID == (int)eID);
            if (found != null)
            {
                return found.sFilePath;
            }
        }
        return eID.ToString();
    }

    [DebuggerHidden]
    private IEnumerator DownloadBGM(string fileName, bool bLoop = true, float sample = 0f)
    {
        if (!string.IsNullOrEmpty(fileName))
        {
            string cleanName = Path.GetFileNameWithoutExtension(fileName);
            AudioClip clip = Resources.Load<AudioClip>("sound/music/" + cleanName);
            if (clip == null)
            {
                string abPath = "Sound/Music/" + cleanName;
                AssetBundleManager.Load(abPath);
                while (!AssetBundleManager.IsLoad(abPath))
                {
                    yield return null;
                }
                UnityEngine.Object[] abObjs = AssetBundleManager.Get(abPath);
                if (abObjs != null && abObjs.Length > 0)
                {
                    clip = abObjs[0] as AudioClip;
                }
            }
            if (clip != null && m_scrMusicMain != null)
            {
                m_scrMusicMain.PlayStart(clip, bLoop, sample);
            }
        }
        m_sLoadBGM = null;
    }

    public bool IsOK_MusicReq() => m_scrMusicMain != null && m_scrMusicMain.IsOK_MusicReq();

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
        if (m_sLoadBGM != null)
        {
            StopCoroutine(m_sLoadBGM);
            m_sLoadBGM = null;
        }
        UnityEngine.Debug.Log("♪♪♪ BGM再生リクエスト : " + eID + " ♪♪♪");
        m_bPlayADVMusic = isADV;

        if (m_eRecentMusicID != eID)
        {
            if (m_scrMusicMain != null)
            {
                m_fPrevMusicTime = m_scrMusicMain.GetTime();
            }
            m_ePrevMusicID = m_eRecentMusicID;
            StopMusic(true);
            m_eRecentMusicID = eID;

            if (eID != sc_eMusicID_None && m_sSoundList != null && m_sSoundList.BGM != null)
            {
                SoundData found = m_sSoundList.BGM.Find(x => x != null && x.iID == (int)eID);
                if (found == null)
                {
                    UnityEngine.Debug.LogWarning("まだファイルのないBGM" + eID);
                }
                else if (m_acMusicClip.TryGetValue(found.iID, out AudioClip localClip) && localClip != null)
                {
                    if (m_scrMusicMain != null)
                    {
                        m_scrMusicMain.PlayStart(localClip, bLoop, sample);
                    }
                }
                else
                {
                    m_sLoadBGM = StartCoroutine(DownloadBGM(found.sFilePath, bLoop, sample));
                }
            }
        }
    }

    public void PlayMusic_AudioClip(AudioClip acClip, bool bLoop = true, float sample = 0f)
    {
        if (m_scrMusicMain != null)
        {
            m_fPrevMusicTime = m_scrMusicMain.GetTime();
            StopMusic(true);
            m_scrMusicMain.PlayStart(acClip, bLoop, sample);
        }
    }

    public void StopMusic(bool bFade = true)
    {
        if (m_scrMusicMain != null)
        {
            if ((int)m_eRecentMusicID > (int)sc_eMusicID_None && bFade)
            {
                m_scrMusicMain.SetFadeout();
            }
            else
            {
                m_scrMusicMain.Stop();
            }
        }
        m_eRecentMusicID = sc_eMusicID_None;
    }

    public eMusicID GetPlayMusicID() => m_eRecentMusicID;
    public float GetNowMusicTime() => m_scrMusicMain != null ? m_scrMusicMain.GetTime() : 0f;
    public float GetPrevMusicTime() => m_fPrevMusicTime;
    public eMusicID GetPrevMusicID() => m_ePrevMusicID;
    public bool IsPlayADVMusic() => m_bPlayADVMusic;

    public void StopSoundAll()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Transform child = transform.GetChild(i);
            if (child != null)
            {
                Destroy(child.gameObject);
            }
        }
    }

    public Sound_OneShot PlaySound(string fileName, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            return null;
        }
        if (m_sSoundList != null && m_sSoundList.SE != null)
        {
            SoundData found = m_sSoundList.SE.Find(x => x != null && x.sFilePath == fileName);
            if (found != null && m_acSoundClip.TryGetValue(found.iID, out AudioClip clip) && clip != null)
            {
                return PlaySound_AudioClip(clip, fWaitSec, trTemp, fVolume, bTimeScale);
            }
        }
        AudioClip resClip = Resources.Load<AudioClip>("sound/sound/" + Path.GetFileNameWithoutExtension(fileName));
        if (resClip != null)
        {
            return PlaySound_AudioClip(resClip, fWaitSec, trTemp, fVolume, bTimeScale);
        }
        UnityEngine.Debug.LogWarning("存在しないSE : " + fileName);
        return null;
    }

    public Sound_OneShot PlaySound(eSoundID eID, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (eID == eSoundID.None)
        {
            return null;
        }
        if (m_acSoundClip.TryGetValue((int)eID, out AudioClip cached) && cached != null)
        {
            return PlaySound_AudioClip(cached, fWaitSec, trTemp, fVolume, bTimeScale);
        }
        if (m_sSoundList != null && m_sSoundList.SE != null)
        {
            SoundData found = m_sSoundList.SE.Find(x => x != null && x.iID == (int)eID);
            if (found != null)
            {
                if (m_acSoundClip.TryGetValue(found.iID, out AudioClip clip) && clip != null)
                {
                    return PlaySound_AudioClip(clip, fWaitSec, trTemp, fVolume, bTimeScale);
                }
                if (!string.IsNullOrEmpty(found.sFilePath))
                {
                    AudioClip resClip = Resources.Load<AudioClip>("sound/sound/" + Path.GetFileNameWithoutExtension(found.sFilePath));
                    if (resClip != null)
                    {
                        m_acSoundClip[found.iID] = resClip;
                        return PlaySound_AudioClip(resClip, fWaitSec, trTemp, fVolume, bTimeScale);
                    }
                }
            }
        }
        UnityEngine.Debug.LogWarning("存在しないSE : " + eID);
        return null;
    }

    public Sound_OneShot PlaySound_AudioClip(AudioClip acOrigin, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (acOrigin == null || m_goSound_OneShot == null) return null;

        GameObject obj = MakeAudioObject(false, m_goSound_OneShot, acOrigin, fWaitSec, trTemp, fVolume, bTimeScale);
        if (obj == null) return null;

        Sound_OneShot oneShot = obj.GetComponent<Sound_OneShot>();
        if (oneShot != null)
        {
            oneShot.Initialize();
            oneShot.SetPlayTiming(fWaitSec);
            oneShot.SetTimeScale(bTimeScale);
            if (m_bReverbFlag)
            {
                oneShot.SetReverb(true);
            }
        }
        return oneShot;
    }

    public Sound_Loop PlayLoopSound(eSoundID eID, float fWaitSec = 0f, Transform trTemp = null, float fVolume = 1f, bool bTimeScale = false)
    {
        if (eID == eSoundID.None || m_goSound_Loop == null) return null;
        if (m_acSoundClip.TryGetValue((int)eID, out AudioClip clip) && clip != null)
        {
            return PlayLoopSound_AudioClip(clip, fWaitSec, trTemp, fVolume, bTimeScale);
        }
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
        if (acOrigin == null || goPrefab == null) return null;

        Transform refTr = trTemp != null ? trTemp : transform;
        GameObject soundObj = Instantiate(goPrefab, refTr.position, refTr.rotation);
        AudioSource source = soundObj.GetComponent<AudioSource>();
        if (source == null)
        {
            Destroy(soundObj);
            return null;
        }
        source.clip = acOrigin;
        source.loop = loopFlag;
        float optVol = System_GlobalValue.GetUserInfo().stOptionData.GetSound_Volume(DB_OptionData.eSoundKind.Sound);
        source.volume = Mathf.Clamp01(fVolume * optVol) * SEVolume;
        soundObj.transform.SetParent(transform);
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
    public bool IsLoadedSystemVoice(int chara) => true;
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

    public void StopADVVoice(bool stopCoroutine = true)
    {
        if (stopCoroutine && m_sLoadADVVoice != null)
        {
            StopCoroutine(m_sLoadADVVoice);
            m_sLoadADVVoice = null;
        }
        if (m_goADVVoice != null)
        {
            Destroy(m_goADVVoice);
            m_goADVVoice = null;
        }
    }

    public bool IsPlayADVVoice() => m_goADVVoice != null;

    public void UpdateVolume()
    {
        if (m_scrMusicMain != null)
        {
            m_scrMusicMain.UpdateVolume();
        }
        Sound_OneShot[] oneShots = GetComponentsInChildren<Sound_OneShot>(true);
        for (int i = 0; i < oneShots.Length; i++)
        {
            if (oneShots[i] != null)
            {
                oneShots[i].UpdateVolume();
            }
        }
    }

    public void SetReverb(bool enabled)
    {
        m_bReverbFlag = enabled;
    }
}
