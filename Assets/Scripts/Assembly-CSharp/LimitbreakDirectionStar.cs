using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LimitbreakDirectionStar : MonoBehaviour
{
	public UIGrid m_sGrid;

	public GameObject m_goStarPrefab;

	private List<Animation> m_vStarList;

	public void Init(int max)
	{
	}

	public void InitDefault(int now)
	{
	}

	public void InitAdd(int num)
	{
	}

	[DebuggerHidden]
	private IEnumerator ExecAddAnim(int num)
	{
		return null;
	}
}
