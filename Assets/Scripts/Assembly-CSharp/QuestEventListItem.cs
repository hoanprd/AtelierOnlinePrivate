using System;
using UnityEngine;

public class QuestEventListItem : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txBanner;

	[SerializeField]
	private UILabel m_sLimit;

	[SerializeField]
	private GameObject m_goNewMark;

	private int m_iEventID;

	public int EventID
	{
		get
		{
			return 0;
		}
	}

	public void Init(int id, string texturePath, DateTime limit, bool newMark)
	{
	}
}
