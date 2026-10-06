using UnityEngine;

public class SystemVoice : VoiceSet
{
	public override string GetAssetPath(int id)
	{
		return null;
	}

	public override bool IsExist(int chara, int id)
	{
		return false;
	}

	public override AudioClip GetAudioClip(int chara, int id)
	{
		return null;
	}
}
