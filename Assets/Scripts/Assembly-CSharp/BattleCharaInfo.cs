using System.Collections.Generic;
using UnityEngine;

public abstract class BattleCharaInfo : UIBase
{
	protected MultiPlay_BattleMemberData m_memberData;

	private LongTapButton m_longButton;

	protected GameObject m_longTapObj;

	private UITweenReset m_longTapOuttweens;

	private List<GameObject> m_ElementObjList;

	private List<GameObject> m_StateObjList;

	private GameObject m_ElementTempObj;

	private GameObject m_StateTempObj;

	public virtual void Init(MultiPlay_BattleMemberData memberData, LongTapButton longButton)
	{
	}

	protected abstract Object[] IconChange();

	protected abstract void IconChangeOnLongTapStart();

	private void OnLongTapStart()
	{
	}

	private void GetElementText()
	{
	}

	private void GetState()
	{
	}

	private void OnLongTapFinished()
	{
	}

	private void OnOutFinished()
	{
	}

	public void SetDraw(bool enableFlag)
	{
	}

	public void Delete()
	{
	}
}
