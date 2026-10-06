using UnityEngine;

public class UIAssetBundleTexture : MonoBehaviour
{
	private string m_sPath;

	private UITexture m_txTarget;

	private UITexture m_txLoadIcon;

	private void Update()
	{
	}

	public void Init(string path, UITexture target, bool loadIcon)
	{
	}

	private void OnDestroy()
	{
	}

	public static UIAssetBundleTexture Regist(string path, UITexture target, bool loadIcon = true)
	{
		return null;
	}
}
