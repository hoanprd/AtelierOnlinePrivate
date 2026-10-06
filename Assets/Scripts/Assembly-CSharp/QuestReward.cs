using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestReward : MonoBehaviour
{
	[Serializable]
	public class Item
	{
		private class Detail
		{
			public ItemBar sBar;

			public MasterQuestInfo.Rwd_item item;

			public MasterQuestInfo.Rwd_wth wth;

			public int rankPoint;

			public int chara;
		}

		public GameObject goRoot;

		public GameObject goRootSecret;

		public UIGrid sGrid;

		private List<Detail> vItemBar;

		private int iRegistNum;

		public void Init_SecretItem()
		{
		}

		public void Init(MasterQuestInfo master, ItemBarEvent onDetail)
		{
		}

		private Detail GetItembar()
		{
			return null;
		}

		public void OnDetail(ItemBar target, Transform root)
		{
		}
	}

	[Serializable]
	public class Skil
	{
		public GameObject goRoot;

		public UILabel sName;

		public UILabel sDetail;
	}

	[SerializeField]
	private Item m_sItemInfo;

	[SerializeField]
	private Skil m_sSkillInfo;

	[SerializeField]
	private ItemBarChara m_sCharaInfo;

	[SerializeField]
	private SpawnPrefabData m_sCharaDetail;

	private Transform m_trDetailRoot;

	public void Init(MasterQuestInfo master, Transform detailRoot, bool isSecret = false)
	{
	}

	public void OnDetail(ItemBar target)
	{
	}

	public void OnCharaDetail(ItemBarChara target)
	{
	}
}
