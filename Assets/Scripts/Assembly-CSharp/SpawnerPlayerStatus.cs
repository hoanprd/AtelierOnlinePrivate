using UnityEngine;

public class SpawnerPlayerStatus : MonoBehaviour
{
	[SerializeField]
	private bool m_bEnableBuyCall;

	[SerializeField]
	private bool m_bDispCall;

	[SerializeField]
	private bool m_bDispEther;

	[SerializeField]
	private bool m_bSpoon;

	[SerializeField]
	private Transform m_trRoot;

	private Game_UI_Status m_uiStatus;

	private void Awake()
	{
	}

	public Game_UI_Status GetUIStatus()
	{
		return null;
	}
}
