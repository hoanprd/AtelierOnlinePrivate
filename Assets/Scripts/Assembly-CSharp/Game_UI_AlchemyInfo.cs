using System;
using UnityEngine;

public class Game_UI_AlchemyInfo : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sLevel;

	[SerializeField]
	private UISlider m_sSlider;

	public AlterLvUpWindow m_LvUpWindow;

	private AlchemyUserInfo m_sNow;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateStatus()
	{
	}

	public void StartUpdateStatus(Action onClose)
	{
	}

	private void Update()
	{
	}

	private void Lerp(UILabel label, ref int value, int target)
	{
	}
}
