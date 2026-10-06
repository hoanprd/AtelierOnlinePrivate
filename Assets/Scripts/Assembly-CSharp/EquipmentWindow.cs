using UnityEngine;

public class EquipmentWindow : MonoBehaviour
{
	public EEquipWindowKind m_eStatus;

	public AnimationController[] m_asWindows;

	private bool m_bAnimEnd;

	public bool IsAnimEnd
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

	private void OnBringinEnd()
	{
	}

	private void OnDismissEnd()
	{
	}
}
