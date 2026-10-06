using UnityEngine;

public class OtherMenuItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sBadge;

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UISprite m_sIcon;

	public void Init(string icon, string name, EventDelegate setEvent, float delay)
	{
	}

	public void SetBadge(int num)
	{
	}
}
