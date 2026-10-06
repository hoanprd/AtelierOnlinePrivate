using System;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBattle : MonoBehaviour
{
	[Serializable]
	public class SpecList
	{
		public List<CharaSpec> PT;
	}

	public BattleStart res;

	public ResponseDataCommon common;

	public SpecList spec;

	public void Init(int num)
	{
	}
}
