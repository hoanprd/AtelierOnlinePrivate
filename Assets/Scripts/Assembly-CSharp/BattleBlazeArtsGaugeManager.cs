using UnityEngine;

public class BattleBlazeArtsGaugeManager : MonoBehaviour
{
	[SerializeField]
	private UISlider m_sliderObj;

	[SerializeField]
	private GameObject m_maxObj;

	[SerializeField]
	private float m_incAttack;

	[SerializeField]
	private float m_incSkill;

	[SerializeField]
	private float m_incItem;

	[SerializeField]
	private float m_perSkillChain;

	private MultiPlay_BattleData m_battleData;

	private MultiPlay_BattleCharaData m_charaData;

	public bool Init(int charaID)
	{
		return false;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void IncreaseAttack()
	{
	}

	public void IncreaseSkill()
	{
	}

	public void IncreaseItem()
	{
	}

	private void Increase(float inc)
	{
	}

	public void Consumption()
	{
	}

	public void SetDraw(bool enableFlag)
	{
	}

	public float GetGaugeValue()
	{
		return 0f;
	}

	public void SetGaugeValue(float value)
	{
	}
}
