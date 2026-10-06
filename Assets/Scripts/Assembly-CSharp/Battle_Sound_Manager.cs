using System.Collections.Generic;
using UnityEngine;

public class Battle_Sound_Manager : MonoBehaviour
{
	private static Battle_Sound_Manager g_scrInst;

	private Dictionary<int, Sound_OneShot> voiceDictionary;

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	public static Battle_Sound_Manager GetInst()
	{
		return null;
	}

	public void PlayVoice(int charaID, EBattleVoiceID voiceID)
	{
	}

	public void PlayVoice(eEnemyKind enemyKind, EBattleVoiceID voiceID)
	{
	}
}
