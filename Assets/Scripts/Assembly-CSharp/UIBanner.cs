using UnityEngine;

public class UIBanner : MonoBehaviour
{
	private string m_sPath;

	private UITexture m_txTarget;

	private UITexture m_txLoadIcon;

	private bool m_bLoadIcon;

	private bool m_bLoad;

	private bool m_bSaveFile;

	private WWW m_sDownloading;

	private WWW m_sLocalDownloading;

	public void Init(string url, UITexture target, bool loadIcon, bool save)
	{
	}

	private void Update()
	{
	}

	private void LoadTexture(WWW w)
	{
	}

	public void Load()
	{
	}

	private void CreateLoadIcon()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Regist(string path, UITexture target, bool loadIcon = true, bool save = true)
	{
	}
}
