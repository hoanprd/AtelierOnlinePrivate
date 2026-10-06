using System;
using System.Collections.Generic;

public class UITutorialSwitchButton : UITutorialSwitchBase
{
	public enum EStatus
	{
		eOFF = 0,
		eDISABLE = 1
	}

	[Serializable]
	public class Info
	{
		public EStatus stat;

		public EFlag kind;
	}

	public UIButton m_sTarget;

	public LockMark m_sLockMark;

	public List<Info> m_vCondition;

	private bool m_bForce;

	protected override void Start()
	{
	}

	public void SetStatus(bool enable, bool disp)
	{
	}

	public override void UpdateStatus()
	{
	}
}
