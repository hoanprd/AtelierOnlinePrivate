using UnityEngine;

public class Game_UI_Chat_Window_StampList : MonoBehaviour
{
	private static readonly Vector3 c_v3MakeOffsetPos;

	[SerializeField]
	private GameObject m_goStampBase;

	[SerializeField]
	private UIScrollView m_scrScrollView;

	[SerializeField]
	private UIGrid m_scrGrid;

	[SerializeField]
	private UIScrollListArrow m_scrArrow;

	private void Awake()
	{
	}

	private void OnReposition()
	{
	}

	public void UpdateStamp()
	{
	}

	public void SetScrollBar(UIScrollBar scrBar)
	{
	}
}
