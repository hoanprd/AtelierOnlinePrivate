using Tutorial;
using UnityEngine;

public class TutorialFairyObj : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_scrAnimCtrl;

	[SerializeField]
	private AnimationClip[] m_acAnimAry;

	[SerializeField]
	private GameObject[] m_goStateObj;

	[SerializeField]
	private ParticleSystem m_scrFairyParticle;

	[SerializeField]
	private GameObject m_goEmotePrefab;

	[SerializeField]
	private GameObject m_goEmoteRoot;

	[SerializeField]
	private GameObject[] m_goAnimObjAry;

	private Emoticon m_scrEmote;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void SetStateObj(eFairyState eState)
	{
	}

	public void PlayAnim(eFairyMotion eKind, float fSpeed)
	{
	}

	public void StopAnim()
	{
	}

	public void SetEmote(EEmoticon eEmote)
	{
	}

	public bool IsEmote()
	{
		return false;
	}

	public bool IsAnim()
	{
		return false;
	}
}
