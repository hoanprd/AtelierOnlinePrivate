using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestEventList : UIListViewBase<QuestEventListItem>
{
	private class EventList
	{
		public int iID;

		public DateTime sLimit;

		public int dispOrder;
	}

	[SerializeField]
	private AnimationController m_sAnim;

	private Action<int> m_sSelectEvent;

	private int m_iSelect;

	private const string sKEY_EVENT_NEW = "EVENT_NEW";

	private BannerInfo m_bannerInfo;

	public void Init(BannerInfo bannerInfo, Action<int> onCloseEvent)
	{
	}

	public void OnSelect(int select)
	{
	}

	private void OnCloseEnd()
	{
	}

	public List<int> GetAlreadyRead()
	{
		return null;
	}

	public void SaveRead(int id)
	{
	}
}
