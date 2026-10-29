using UnityEngine;

public class OpeningManager : MonoBehaviour
{
	public MediaPlayerCtrl scrMedia;

	private bool downloadFlag;

	private void Start()
	{
		if (scrMedia != null)
		{
			scrMedia.OnEnd += OnEnd;
			scrMedia.OnVideoError += OnError;
			scrMedia.OnReady += OnReady;
		}
	}

	private void OnReady()
	{
	}

	private void OnError(MediaPlayerCtrl.MEDIAPLAYER_ERROR errorCode, MediaPlayerCtrl.MEDIAPLAYER_ERROR errorCodeExtr)
	{
		Finish();
	}

	protected virtual void OnDialogCommon(EButtonKind eResult)
	{
	}

	private void Update()
	{
		if (downloadFlag)
		{
			ConnectingIcon.DispRequest();
		}
		if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
		{
			Finish();
		}
	}

	private void Finish()
	{
		if (scrMedia != null)
		{
			scrMedia.Stop();
		}
		if (System_MenuManager.GetInst() != null)
		{
			System_MenuManager.GetInst().SetMenuRequest(System_MenuManager.eSystemMenuKind.Title, false, false, true);
		}
	}

	private void OnEnd()
	{
		if (System_MenuManager.GetInst() != null)
		{
			System_MenuManager.GetInst().SetMenuRequest(System_MenuManager.eSystemMenuKind.Title, false, false, true);
		}
	}

	private void OnDestroy()
	{
		if (scrMedia != null)
		{
			scrMedia.OnEnd -= OnEnd;
			scrMedia.OnVideoError -= OnError;
			scrMedia.OnReady -= OnReady;
		}
	}
}
