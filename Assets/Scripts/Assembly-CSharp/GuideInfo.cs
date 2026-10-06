using UnityEngine;

public class GuideInfo : MonoBehaviour
{
	protected enum EStep
	{
		eWAIT = 0,
		eBRINGIN = 1,
		eDISP = 2,
		eDISMISS = 3,
		eEND = 4
	}

	public float m_fWaitTime;

	public UITweenReset m_sAnim;

	public UILabel m_sTitle;

	public UISprite m_sRankIcon;

	public ParticleSystem m_sEffect;

	public GameObject m_goMultiRoot;

	protected EStep m_eStep;

	protected float m_fTimer;

	public bool IsEnd
	{
		get
		{
			return false;
		}
	}

	public void Clear(QuestComplete complete, QuestDetail detail = null)
	{
	}

	public void Clear(string name)
	{
	}

	public void Order(QuestDetail detail)
	{
	}

	public virtual void Init(string detail, bool multi = false)
	{
	}

	public void OnAnimEnd()
	{
	}

	private void Update()
	{
	}
}
