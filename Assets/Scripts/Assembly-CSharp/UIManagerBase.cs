using UnityEngine;

public class UIManagerBase : MonoBehaviour
{
	public ECommonUIKind m_eKind;

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public virtual void Bringin()
	{
	}

	public virtual void Dismiss()
	{
	}

	public virtual void Suspend()
	{
	}

	public virtual void Resume()
	{
	}

	public virtual void OnClose()
	{
	}

	public virtual void OnExit()
	{
	}
}
