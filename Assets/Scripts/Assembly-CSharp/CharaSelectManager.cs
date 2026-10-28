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

	private int m_iGender = 2;

	private AppearanceInfo m_sAppearanceInfo;

	private bool m_bFinish;

	public bool IsFinish
	{
		get
		{
			return m_bFinish;
		}
	}

	private void Awake()
	{
		m_bFinish = false;
	}

	public void Init(SalonInfo info)
	{
		m_bFinish = false;
		if (info != null && info.MAKE != null)
		{
			m_sAppearanceInfo = info.MAKE;
		}
		else
		{
			m_sAppearanceInfo = new AppearanceInfo
			{
				NAME = GameUtil.MakeUserName(),
				GEN = 2,
				HAI = 1,
				HAI_C = 1,
				SKI = 1,
				FAC = 1,
				EYE = 1
			};
		}
		m_sAppearanceInfo.GEN = 2;
		m_iGender = 2;
		if (m_sName != null)
		{
			if (m_sName.label != null)
			{
				m_sName.label.maxLineCount = 1;
			}
			m_sName.characterLimit = 8;
			m_sName.Set(m_sAppearanceInfo.NAME, true);
		}
		if (m_asGenderInfo != null)
		{
			for (int i = 0; i < m_asGenderInfo.Length; i++)
			{
				if (m_asGenderInfo[i] != null && m_asGenderInfo[i].sDecideButton != null)
				{
					bool selected = (i + 1) == m_iGender;
					UIToggle toggle = m_asGenderInfo[i].sDecideButton.GetComponent<UIToggle>();
					if (toggle != null)
					{
						toggle.Set(selected, false);
					}
					UIToggledObjects toggledObjs = m_asGenderInfo[i].sDecideButton.GetComponent<UIToggledObjects>();
					if (toggledObjs != null)
					{
						toggledObjs.Reset(selected);
					}
				}
			}
		}
		SetModel();
	}

	public void OnChangeGender(int gender)
	{
		if (m_iGender != gender)
		{
			m_iGender = gender;
			if (m_sAppearanceInfo != null)
			{
				m_sAppearanceInfo.GEN = gender;
			}
			SetModel();
			PlaySelectVoice(gender);
		}
	}

	public void OnDecideConfirm()
	{
		string userName = (m_sName != null && !string.IsNullOrEmpty(m_sName.value)) ? m_sName.value : GameUtil.MakeUserName();
		if (m_sAppearanceInfo != null)
		{
			m_sAppearanceInfo.NAME = userName;
			m_sAppearanceInfo.GEN = m_iGender;
		}
		DialogCommon.CreateYesNODialog("主人公を「" + userName + "」に決定します。\r\nよろしいですか？", OnDecide);
	}

	public void OnChangeName(string value)
	{
		UserNameLimit(false);
	}

	public void OnSubmitName()
	{
		UserNameLimit(true);
	}

	public void Update()
	{
		if (m_sStartButton != null && m_sName != null)
		{
			m_sStartButton.isEnabled = !string.IsNullOrEmpty(m_sName.value);
		}
	}

	public void UserNameLimit(bool force)
	{
		if (m_sName != null && !string.IsNullOrEmpty(m_sName.value) && m_sName.value.Length > 8)
		{
			m_sName.value = m_sName.value.Substring(0, 8);
		}
	}

	private void OnDecide(EButtonKind result)
	{
		if (result == EButtonKind.eDECIDE)
		{
			StartCoroutine(DecideDirection());
		}
	}

	[DebuggerHidden]
	private IEnumerator DecideDirection()
	{
		PlayDeicideSE();
		PlayDecideMotion();
		int charaId = (m_iGender == 1) ? 1 : 2;
		bool apiDone = false;
		NetworkManager.SalonChoose(charaId, m_sAppearanceInfo, delegate
		{
			apiDone = true;
		});
		while (!apiDone)
		{
			yield return null;
		}
		yield return new WaitForSeconds(0.5f);
		OnDecideFinish();
	}

	public void PlayDecideMotion()
	{
		int idx = m_iGender - 1;
		if (m_asGenderInfo != null && idx >= 0 && idx < m_asGenderInfo.Length && m_asGenderInfo[idx] != null)
		{
			if (m_asGenderInfo[idx].goDecideEffect != null)
			{
				m_asGenderInfo[idx].goDecideEffect.SetActive(true);
			}
			if (m_asGenderInfo[idx].sDecideVoice != null && Sound_Manager.GetInst() != null)
			{
				Sound_Manager.GetInst().PlaySound_AudioClip(m_asGenderInfo[idx].sDecideVoice);
			}
		}
		if (m_sDecideAnim != null)
		{
			m_sDecideAnim.Play();
		}
	}

	private void OnDecideFinish()
	{
		m_bFinish = true;
	}

	private void PlayDeicideSE()
	{
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound((eSoundID)94);
		}
	}

	private void PlaySelectVoice(int gender)
	{
		int idx = gender - 1;
		if (m_asGenderInfo != null && idx >= 0 && idx < m_asGenderInfo.Length && m_asGenderInfo[idx] != null && m_asGenderInfo[idx].sSelectVoice != null && Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound_AudioClip(m_asGenderInfo[idx].sSelectVoice);
		}
	}

	private void SetModel()
	{
		if (m_asGenderInfo == null)
		{
			return;
		}
		for (int i = 0; i < m_asGenderInfo.Length; i++)
		{
			if (m_asGenderInfo[i] != null && m_asGenderInfo[i].goModel != null)
			{
				m_asGenderInfo[i].goModel.SetActive((i + 1) == m_iGender);
			}
		}
	}
}
