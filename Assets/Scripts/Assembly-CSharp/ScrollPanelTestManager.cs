using UnityEngine;

public class ScrollPanelTestManager : MonoBehaviour
{
	public int m_iPageMax;

	public int m_iPageNum;

	public UILabel m_sPageNum;

	public UIGrid m_sPageRoot;

	public UICenterOnChild m_sCenterCheck;

	public UIWrapContent m_sWrap;

	public GameObject m_goPagePrefab;

	public int m_iPageNow;

	public ScrollPanelTestPage m_sCenterPage;

	private void Start()
	{
	}

	private void OnCenterPage(GameObject obj)
	{
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}
}
