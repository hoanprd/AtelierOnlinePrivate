using UnityEngine;

public class CharaEditSelectItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goSelection;

	[SerializeField]
	private UITweenReset m_sSelectTween;

	public bool Select
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(bool select)
	{
	}
}
