using System.Collections.Generic;
using UnityEngine;

public class BattleContinue : UIBase
{
	private enum ContinueScene
	{
		ReviveItem = 0,
		ReviveCall = 1,
		ReviveCallConf = 2,
		GiveUp = 3,
		GiveUpJoin = 4,
		WaitJoin = 5
	}

	private MultiPlay_BattleData m_battleData;

	private UITweenReset m_Tween;

	private int m_sceneBefore;

	private int m_sceneAfter;

	private float m_count;

	private int m_count_int;

	private int m_count_intBefore;

	public int m_restContinue;

	public bool m_isContinue;

	public bool m_isContinueSelect;

	public int m_lostEther;

	public int m_lostCall;

	public int m_lostItem;

	private bool m_timeLimitFlag;

	public List<GameObject> m_effectList;

	[SerializeField]
	private UILabel m_haveText;

	[SerializeField]
	private UILabel m_lostText;

	[SerializeField]
	private UILabel m_costBefore;

	[SerializeField]
	private UILabel m_costAfter;

	[SerializeField]
	private UITexture m_costIcon;

	[SerializeField]
	private UILabel m_continueBefore;

	[SerializeField]
	private UILabel m_continueAfter;

	[SerializeField]
	private GameObject m_continueArrow;

	[SerializeField]
	private GameObject m_continueRem;

	[SerializeField]
	private GameObject m_continueConf;

	[SerializeField]
	private UILabel m_title;

	[SerializeField]
	private UILabel m_timeLimit;

	[SerializeField]
	private UILabel m_sentence;

	[SerializeField]
	private GameObject m_buttonParent;

	[SerializeField]
	private UIButton m_button1;

	[SerializeField]
	private UIButton m_button2;

	[SerializeField]
	private UILabel m_ExtraContextLab;

	[SerializeField]
	private GameObject m_CostRoot;

	[SerializeField]
	private GameObject m_ContinueRoot;

	public void Init()
	{
	}

	public void Init2()
	{
	}

	public void InitJoin()
	{
	}

	private void InitShare()
	{
	}

	private void Update()
	{
	}

	private void SetRetireExtraObjectActive()
	{
	}

	public void ExtraQuestRetireProc()
	{
	}

	private void DidTapItemNo()
	{
	}

	private void DidTapItemYes()
	{
	}

	private void DidTapCallNo()
	{
	}

	private void DidTapCallYes()
	{
	}

	private void DidTapCallConfNo()
	{
	}

	private void DidTapCallConfYes()
	{
	}

	public void DidTapGiveUpNo()
	{
	}

	public void DidTapGiveUpYes()
	{
	}

	public void DidTapGiveUpJoinNo()
	{
	}

	public void DidTapGiveUpJoinYes()
	{
	}

	public void DidTapWaitJoinCancel()
	{
	}

	public void Continue(int itemDF)
	{
	}

	public void Annihilated()
	{
	}

	public void Withdrawal(int charaID)
	{
	}

	public void ExqRetire(bool isRoomHost, bool isForce = false)
	{
	}
}
