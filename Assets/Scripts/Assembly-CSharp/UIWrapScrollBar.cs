using UnityEngine;

[ExecuteInEditMode]
public class UIWrapScrollBar : MonoBehaviour
{
	[SerializeField]
	private int m_iDispItemNum;

	[SerializeField]
	private UIScrollBar m_sScrollBar;

	[SerializeField]
	private UIWrapContent m_sWrapContent;

	[SerializeField]
	private UIScrollView m_sScroll;

	[SerializeField]
	private UIPanel m_sPanel;

	private float m_fEndPos;

	private int m_iItemNum;

	private int m_iItemColumn;

	private bool m_bDisp;

	private Vector3 m_vStartPos;

	public int ItemNum
	{
		get
		{
			return 0;
		}
	}

	public void Init(int dispNum)
	{
	}

	public void Init()
	{
	}

	private void Awake()
	{
	}

	private void UpdateScrollbar()
	{
	}

	private void OnScrollBarPressed(GameObject go, bool isPressed)
	{
	}

	private void OnScrollBarDragged(GameObject go, Vector2 delta)
	{
	}

	private void OnScrollBarChanged()
	{
	}

	private void OnSpringPanelFinished()
	{
	}

	public void UpdateScrollBarSize()
	{
	}

	private void UpdateScrollBarSize(float contentMin, float contentMax, float contentSize, float viewSize)
	{
	}

	private void LateUpdate()
	{
	}
}
