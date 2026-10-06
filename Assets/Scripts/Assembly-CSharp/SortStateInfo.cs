using UnityEngine;

public class SortStateInfo : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UISprite m_sIcon;

	[SerializeField]
	private UISprite m_sOrder;

	public void Init(EOrder order, ESortKind sort)
	{
	}
}
