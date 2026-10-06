using UnityEngine;

public class EquipmentTitle : MonoBehaviour
{
	public AnimationController m_sAnim;

	public UILabel m_sTitle;

	public UISprite m_sIcon;

	public UISprite m_sCategoryIcon;

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public bool IsAnimEnd()
	{
		return false;
	}

	public void Init(EEquipUIStatus status, EEquipKind kind, int index, bool visualMode)
	{
	}
}
