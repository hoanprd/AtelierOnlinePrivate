using UnityEngine;

public class EquipParamItem : MonoBehaviour
{
	[SerializeField]
	protected UILabel m_sTitle;

	[SerializeField]
	protected UILabel m_sSubTitle;

	[SerializeField]
	protected UISprite m_sKindIcon;

	[SerializeField]
	protected UILabel m_sValue;

	[SerializeField]
	protected UISprite m_sElementIcon;

	public void InitKind(EParamKind kind)
	{
	}

	public virtual void SetValue(int now, int element = 0)
	{
	}

	public void Init(EParamKind kind, int now, int element = 0)
	{
	}
}
