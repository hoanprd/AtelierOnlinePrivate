using UnityEngine;

public class Game_UI_Town_Manager : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_scrInoutAnim;

	[SerializeField]
	private Game_UI_FieldLauncher m_scrLauncher;

	public INNManager m_scrINN;

	public Game_UI_FieldLauncher Launcher
	{
		get
		{
			return null;
		}
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void OnDismiss()
	{
	}

	public void OpenLauncher()
	{
	}

	public void CloseLauncher()
	{
	}

	public bool IsOpenLauncher()
	{
		return false;
	}

	public bool IsEndLauncherAnimation()
	{
		return false;
	}
}
