using System.Collections.Generic;
using UnityEngine;

public class ScrollPanelTestPage : MonoBehaviour
{
	public int m_iPage;

	public UILabel m_sPage;

	public GameObject m_goIconPrefab;

	public UIGrid m_sIconRoot;

	public List<ScrollPanelTestIcon> m_vIconList;

	private void Awake()
	{
	}

	public void Init(int page)
	{
	}

	private ScrollPanelTestIcon GetObject()
	{
		return null;
	}
}
