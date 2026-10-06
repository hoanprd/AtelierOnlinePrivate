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
		return 0f;
	}

	protected virtual void SetSystemFadeIn()
	{
	}

	protected virtual bool IsSystemFadeInEnd()
	{
		return false;
	}

	protected virtual void SetSystemBlackOut(System_MenuManager.eSystemMenuKind eKind = System_MenuManager.eSystemMenuKind.None)
	{
	}

	protected virtual bool IsSystemBlackOutEnd()
	{
		return false;
	}

	protected virtual void SetSystemCover(bool bEnable)
	{
	}

	protected virtual void SetCover(bool bEnable)
	{
	}
}
