using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestBarRoot : MonoBehaviour
{
	[Serializable]
	public class Folder
	{
		public GameObject goOpenArrow;

		public UILabel sOpenCloseText;

		public UISprite sFrame;

		public UISprite sBase;

		public GameObject goOpen;

		public GameObject goClose;

		public int iLength;

		private int iBaseHeight;

		public void Close()
		{
		}

		public void Open(int len)
		{
		}

		private void Set(int len, bool immidiate)
		{
		}
	}

	[Serializable]
	public class Chara
	{
		public GameObject goRoot;

		public UITexture txFaceIcon;

		public UILabel sName;

		public UILabel sLV;
	}

	[Serializable]
	public class Side
	{
		public GameObject goRoot;

		public UILabel sName;

		public UILabel sNo;

		public UILabel sProgress;
	}

	public UIButton m_sOpenButton;

	[SerializeField]
	private GameObject m_goNewMark;

	[SerializeField]
	private GameObject m_goCompleteMark;

	[SerializeField]
	private Folder m_sFolder;

	[SerializeField]
	private Chara m_sChara;

	[SerializeField]
	private Side m_sSide;

	private UITweenReset m_sSelectAnim;

	private int m_iID;

	public int ID
	{
		get
		{
			return 0;
		}
	}

	public void UpdateInfo(QuestListWindow.ETabKind kind, List<QuestDetail> playList)
	{
	}

	public void Init(int id, QuestListWindow.ETabKind kind, List<QuestDetail> playList)
	{
	}

	public int GetElementNum()
	{
		return 0;
	}

	public void Open(int len)
	{
	}

	public void Close()
	{
	}

	public void Select(bool sw)
	{
	}
}
