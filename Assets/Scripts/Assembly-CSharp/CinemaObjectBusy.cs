using System.Collections.Generic;
using UnityEngine;

public class CinemaObjectBusy : MonoBehaviour
{
	private int m_actionCount;

	private Dictionary<int, int> m_busyCount;

	public bool IsBusy()
	{
		return false;
	}

	public bool IsBusy(int key)
	{
		return false;
	}

	public void BusyOn(int key)
	{
	}

	public void BusyOff(int key)
	{
	}

	private void Awake()
	{
	}
}
