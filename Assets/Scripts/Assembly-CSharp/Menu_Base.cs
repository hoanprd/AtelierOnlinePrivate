using UnityEngine;

public class Menu_Base : MonoBehaviour
{
	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void Update()
	{
		if (SessionOutCheck())
		{
			SetSessionOut();
			return;
		}
		if (ExtraQuestManager.Instance != null && ExtraQuestManager.Instance.IsExtraQuestMode())
		{
			ExtraQuestManager.Instance.ConfirmNotExistsOwner();
		}
		MenuUpdate();
	}

	protected virtual bool SessionOutCheck()
	{
		return false;
	}

	protected virtual void SetSessionOut()
	{
	}

	protected virtual void MenuUpdate()
	{
	}

	protected float GetDeltaTime()
	{
		return Time.deltaTime;
	}

	protected virtual void SetSystemFadeIn()
	{
		LoadingManager.Disable(0.5f);
	}

	protected virtual bool IsSystemFadeInEnd()
	{
		return LoadingManager.IsEnd;
	}

	protected virtual void SetSystemBlackOut(System_MenuManager.eSystemMenuKind eKind = System_MenuManager.eSystemMenuKind.None)
	{
		LoadingManager.Enable(0.5f);
	}

	protected virtual bool IsSystemBlackOutEnd()
	{
		return LoadingManager.IsBlackOut;
	}

	protected virtual void SetSystemCover(bool bEnable)
	{
		if (System_MenuManager.GetInst() != null)
		{
			System_MenuManager.GetInst().SetCover(bEnable);
		}
	}

	protected virtual void SetCover(bool bEnable)
	{
	}
}
