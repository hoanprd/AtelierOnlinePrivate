using System.Collections.Generic;
using UnityEngine;

public class Battle_Sound_Manager : MonoBehaviour
{
	private static Battle_Sound_Manager g_scrInst;

	private Dictionary<int, Sound_OneShot> voiceDictionary = new Dictionary<int, Sound_OneShot>();

	private void Awake()
	{
		g_scrInst = this;
		Initialize();
	}

	private void Initialize()
	{
		if (voiceDictionary == null)
		{
			voiceDictionary = new Dictionary<int, Sound_OneShot>();
		}
		else
		{
			voiceDictionary.Clear();
		}
	}

	public static Battle_Sound_Manager GetInst()
	{
		return g_scrInst;
	}

	public void PlayVoice(int charaID, EBattleVoiceID voiceID)
	{
	}

	public void PlayVoice(eEnemyKind enemyKind, EBattleVoiceID voiceID)
	{
	}
}
