using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BattleTargetItem : UIBase
{
	private MultiPlay_BattleData m_battleData;

	private MultiPlay_CharaData m_charaData;

	private MultiPlay_BattleCharaData m_battleCharaData;

	private MultiPlay_BattleMemberData m_memberData;

	private GameObject m_lockOnObj;

	public void Init(MultiPlay_BattleMemberData memberData)
	{
	}

	[DebuggerHidden]
	private IEnumerator LockOnSizeChange()
	{
		return null;
	}

	public void SetDraw(bool enableFlag)
	{
	}

	private void Update()
	{
	}

	public void DidTap()
	{
	}

	public void Delete()
	{
	}
}
