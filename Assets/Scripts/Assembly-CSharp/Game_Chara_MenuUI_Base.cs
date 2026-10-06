using System.Collections.Generic;
using UnityEngine;

public class Game_Chara_MenuUI_Base : Game_Chara_Base
{
	public List<AnimationClip> animClipList_Academy;

	public int animID;

	private GameObject toolObject_Log;

	protected override void InstantiateModel(MakeCharaData mk, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	protected override void SetAnimSystem(MakeCharaData data, GameObject bodyObj)
	{
	}

	public void SetAnime(int id)
	{
	}
}
