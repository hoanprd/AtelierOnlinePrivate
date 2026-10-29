using UnityEngine;

public class UIWindowBase : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private AnimationController m_sAnimCtrl;

	public virtual void Bringin()
	{
		gameObject.SetActive(true);
		if (m_sAnim != null)
		{
			m_sAnim.ResetOnFinish();
			m_sAnim.ResetTweenForward();
		}
		else if (m_sAnimCtrl != null)
		{
			m_sAnimCtrl.PlayInAnimation();
		}
		Util.SetEnableButton(gameObject, true);
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound(eSoundID.system_005);
		}
	}

	public virtual void OnClose()
	{
		if (!gameObject.activeSelf)
		{
			OnCloseEnd();
			return;
		}
		Util.SetEnableButton(gameObject, false);
		if (m_sAnim != null)
		{
			m_sAnim.SetOnFinish(new EventDelegate(OnCloseEnd));
			m_sAnim.ResetTweenReverse();
		}
		else if (m_sAnimCtrl != null)
		{
			m_sAnimCtrl.SetOnEndMethod(gameObject, "OnCloseEnd");
			m_sAnimCtrl.PlayOutAnimation();
		}
		else
		{
			OnCloseEnd();
		}
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound(eSoundID.system_003);
		}
	}

	protected virtual void OnCloseEnd()
	{
		gameObject.SetActive(false);
	}
}
