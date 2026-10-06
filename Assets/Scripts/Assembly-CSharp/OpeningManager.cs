using UnityEngine;

public class OpeningManager : MonoBehaviour
{
	public MediaPlayerCtrl scrMedia;

	private bool downloadFlag;

	private void Start()
	{
	}

	private void OnReady()
	{
	}

	private void OnError(MediaPlayerCtrl.MEDIAPLAYER_ERROR errorCode, MediaPlayerCtrl.MEDIAPLAYER_ERROR errorCodeExtr)
	{
	}

	protected virtual void OnDialogCommon(EButtonKind eResult)
	{
	}

	private void Update()
	{
	}

	private void Finish()
	{
	}

	private void OnEnd()
	{
	}

	private void OnDestroy()
	{
	}
}
