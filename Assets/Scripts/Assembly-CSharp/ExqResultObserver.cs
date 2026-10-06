using System;
using System.Collections;
using System.Diagnostics;
using NAT;
using UnityEngine;

public class ExqResultObserver : MonoBehaviour
{
	private UIRoot uiRoot;

	private DungeonManager dungeonRoot;

	private Game_Spawner_Manager spawnerRoot;

	private MapAreaSceneRoot mapRoot;

	private Game_Chara_MA_MultiPlay[] avatorRootArr;

	public void Init(Action onFinish)
	{
	}

	[DebuggerHidden]
	private IEnumerator Execute(Action onFinish)
	{
		return null;
	}
}
