using System;
using System.Collections.Generic;
using UnityEngine;

public class Game_Chara_Equip_Base : Game_Chara_Direction
{
	public enum EExMotionKind
	{
		eWAIT = 0,
		eJOY = 1,
		eCONFIRM = 2
	}

	[Serializable]
	public class AnimList
	{
		public List<AnimationClip> equip;

		public List<AnimationClip> extra;
	}

	public AnimList[] anim;

	private string animClipName;

	protected override void InitAnim()
	{
	}

	protected override void SetAnimSystem(MakeCharaData data, GameObject bodyObj)
	{
	}

	public void PlayAnim(string clipName, bool oneShot = false)
	{
	}

	public void SetAnime(EWeaponKind id = EWeaponKind.eKNUCKLE)
	{
	}

	public void SetExAnime(EExMotionKind kind, bool oneShot = false)
	{
	}

	public static Game_Chara_Equip_Base Create(Transform root, bool changeLayer = true, bool orgSize = false, bool orgPosition = false)
	{
		return null;
	}
}
