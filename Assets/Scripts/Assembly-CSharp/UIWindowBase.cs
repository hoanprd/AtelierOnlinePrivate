using UnityEngine;

public class UIWindowBase : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private AnimationController m_sAnimCtrl;

	public virtual void Bringin()
	{
	}

	public virtual void OnClose()
	{
	}

	protected virtual void OnCloseEnd()
	{
	}
}
