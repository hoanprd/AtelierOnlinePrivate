using System.Collections.Generic;
using UnityEngine;

public class UIPageGrid : MonoBehaviour
{
	public UIGrid m_sGrid;

	public GameObject m_goGridObject;

	public Color m_sNormalColor;

	public Color m_sEnableColor;

	private List<GameObject> m_vgoPageList;

	private GameObject m_goCurrent;

	public int PageNum
	{
		get
		{
			return 0;
		}
	}

	public void Init(int page)
	{
	}

	public void Change(int pageIndex)
	{
	}
}
