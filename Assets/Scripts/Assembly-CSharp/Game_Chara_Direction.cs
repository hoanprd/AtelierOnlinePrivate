using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Game_Chara_Direction : Game_Chara_Base
{
	private string m_sCharaDirectionPath;

	private string m_sCharaBattleAnimPath;

	private bool m_bPlayDirection;

	private bool m_bUseVO;

	private Sound_OneShot m_sPlayVO;

	public void Play(AnimationClip clip)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void ReleaseResource()
	{
	}

	public override void MakeCharaObject(MakeCharaData data, bool springFlag, bool ignoreOptionParts = false, eAnimator anim = eAnimator.EnumMax)
	{
	}

	private bool IsAvailableCoroutine()
	{
		return false;
	}

	public bool Play(ESystemVoiceID voiID = ESystemVoiceID.eINTRODUCTION, bool returnMotion = false)
	{
		return false;
	}

	public bool PlaySilent(bool returnMotion = false)
	{
		return false;
	}

	public bool Play(int charaID, ESystemVoiceID voiID = ESystemVoiceID.eINTRODUCTION, bool returnMotion = false)
	{
		return false;
	}

	[DebuggerHidden]
	protected virtual IEnumerator PlayDirection(int charaID, int voID, bool returnMotion)
	{
		return null;
	}
}
