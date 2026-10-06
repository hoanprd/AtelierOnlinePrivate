using System.Collections.Generic;
using UnityEngine;

public class BlazeArtsParam : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sSkillName;

	[SerializeField]
	private UITexture m_sSkillIcon;

	[SerializeField]
	private UILabel m_sContext;

	[SerializeField]
	private UILabel m_sLv;

	[SerializeField]
	private GrowBlazeArtsParam m_sSkillStatus;

	[SerializeField]
	private UIGrid m_sSkillStatusRoot;

	[SerializeField]
	private GameObject m_sNextBtn;

	private ActiveSkill m_sMaster;

	private List<GrowBlazeArtsParam> m_sStatusList;

	private void Start()
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

	private void Update()
	{
	}
}
