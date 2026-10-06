using System;
using UnityEngine;

public class OverwriteConfrimDialog : MonoBehaviour
{
	[SerializeField]
	private OverwriteSkillInfo m_sNowSkill;

	[SerializeField]
	private OverwriteSkillInfo m_sNextSkill;

	private Action<EButtonKind> m_sOnResult;

	public void Init(int now, int next, Action<EButtonKind> onResult)
	{
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}
}
