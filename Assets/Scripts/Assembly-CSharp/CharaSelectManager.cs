using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CharaSelectManager : MonoBehaviour
{
	[Serializable]
	public class GenderInfo
	{
		public UIButton sDecideButton;

		public GameObject goModel;

		public Animation sAnim;

		public GameObject goDecideEffect;

		public AudioClip sSelectVoice;

		public AudioClip sDecideVoice;
	}

	[SerializeField]
	private GenderInfo[] m_asGenderInfo;

	[SerializeField]
	private UIButton m_sStartButton;

	[SerializeField]
	private Animation m_sDecideAnim;

	[SerializeField]
	private UIInput m_sName;

	private int m_iGender;

	private AppearanceInfo m_sAppearanceInfo;

	private bool m_bFinish;

	public bool IsFinish
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	public void Init(SalonInfo info)
	{
	}

	public void OnChangeGender(int gender)
	{
	}

	public void OnDecideConfirm()
	{
	}

	public void OnChangeName(string value)
	{
	}

	public void OnSubmitName()
	{
	}

	public void Update()
	{
	}

	public void UserNameLimit(bool force)
	{
	}

	private void OnDecide(EButtonKind result)
	{
	}

	[DebuggerHidden]
	private IEnumerator DecideDirection()
	{
		return null;
	}

	public void PlayDecideMotion()
	{
	}

	private void OnDecideFinish()
	{
	}

	private void PlayDeicideSE()
	{
	}

	private void PlaySelectVoice(int gender)
	{
	}

	private void SetModel()
	{
	}
}
