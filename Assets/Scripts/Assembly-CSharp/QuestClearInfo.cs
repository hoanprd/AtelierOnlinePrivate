using System;
using UnityEngine;

public class QuestClearInfo : MonoBehaviour
{
	[Serializable]
	public class Have
	{
		public GameObject goRoot;

		public UILabel sRuck;

		public UILabel sContainer;
	}

	[SerializeField]
	private UILabel m_sContent;

	[SerializeField]
	private UISprite m_sTypeIcon;

	[SerializeField]
	private QuestTargetIcon m_sTargetIcon;

	[SerializeField]
	private UILabel m_sTargetName;

	[SerializeField]
	private UILabel m_sTargetNum;

	[SerializeField]
	private UILabel m_sTargetNumPrefix;

	[SerializeField]
	private UILabel m_sTargetNumSuffix;

	[SerializeField]
	private Have m_sHaveInfo;

	[SerializeField]
	private UIButton m_sInfoButton;

	public void Init(MasterQuestInfo master, QuestShow progress = null, InventoryList inv = null)
	{
	}

	private void InitText(MasterQuestInfo master, QuestShow progress, InventoryList inv = null)
	{
	}

	public void Init_NotSelect(EQuestType questType = EQuestType.Subjugation)
	{
	}

	private void SetFontColor(bool enough)
	{
	}
}
