using UnityEngine;

public class PictureWindow : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txPicture;

	[SerializeField]
	private UITweenReset m_sAnim;

	public void Init()
	{
	}

	public void Init(string path)
	{
	}

	public void Out()
	{
	}

	public void SetFinish()
	{
	}

	private void OnCloseEnd()
	{
	}

	public bool IsAnimEnd()
	{
		return false;
	}
}
