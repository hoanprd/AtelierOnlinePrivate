using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
	private static Sound_Manager g_scrInst;

	public static readonly eMusicID sc_eMusicID_None;

	private Dictionary<int, AudioClip> m_acMusicClip;

	private Dictionary<int, AudioClip> m_acSoundClip;

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
			return 0f;
		}
		set
		{
		}
	}

	public static float SEVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public static Sound_Manager GetInst()
	{
		return null;
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
		return false;
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
	}

	public eMusicID GetPlayMusicID()
	{
		return eMusicID.Title;
	}

	public float GetNowMusicTime()
	{
		return 0f;
	}

	public float GetPrevMusicTime()
	{
		return 0f;
	}

	public eMusicID GetPrevMusicID()
	{
		return eMusicID.Title;
	}

	public bool IsPlayADVMusic()
	{
		return false;
	}

	public void StopSoundAll()
	{
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
