using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class AreaTitle : MonoBehaviour
{
	private GameObject m_goTitle;

	private Animation m_scrAnime;

	private float m_fPlaySpeed;

	private bool m_bPlay;

	private string m_prefabPath;

	private void Update()
	{
	}

	private void UpdateSpeed()
	{
	}

	public bool Load(int iAreaId, bool bPlay = true)
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator Download(string path, bool bPlay)
	{
		return null;
	}

	private void InstantiateObject(Object prefab, bool bPlay)
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void SetSpeed(float fSpeed)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Kill()
	{
	}
}
