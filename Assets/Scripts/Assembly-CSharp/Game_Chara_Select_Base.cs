using System.Collections.Generic;
using UnityEngine;

public class Game_Chara_Select_Base : Game_Chara_Base
{
	public AnimationClip stay;

	public List<AnimationClip> decideList;

	protected override void SetAnimSystem(MakeCharaData data, GameObject bodyObj)
	{
	}

	protected override void InstantiateModel(MakeCharaData mk, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	public void SetDecideAnim(int gender)
	{
	}
}
