using System.Collections.Generic;
using UnityEngine;

public class DialogBlazeArts : UIWindowBase
{
	[SerializeField]
	private UILabel m_sSkillName;

	[SerializeField]
	private UILabel m_sLv;

	[SerializeField]
	private UITexture m_sSkillIcon;

	[SerializeField]
	private UILabel m_sContext;

	[SerializeField]
	private GrowBlazeArtsParam m_sSkillStatus;

	[SerializeField]
	private UIGrid m_sSkillStatusRoot;

	[SerializeField]
	private GameObject m_sNextBtn;

	private ActiveSkill m_sMaster;

	private List<GrowBlazeArtsParam> m_sStatusList;

	private bool m_bDestroy;

	private bool m_bBringin;

	public void OnAnimationEnd()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	public void Init(ActiveSkill master, int blazeArtLv)
	{
	}

	private void CreateStatusPrefab()
	{
	}

	public void OnNextButton()
	{
	}

	public static DialogBlazeArts CreateDialog(int df, int lv)
	{
		return null;
	}
}
