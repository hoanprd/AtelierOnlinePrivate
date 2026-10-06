using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LevelUpManager : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private UILabel m_sCharaName;

	[SerializeField]
	private UITexture m_sCharaIcon;

	[SerializeField]
	private UILabel m_sAfterLevel;

	[SerializeField]
	private UILabel m_sBeforeLevel;

	[SerializeField]
	private GameObject m_sStatus;

	[SerializeField]
	private GameObject m_sNewSkillRoot;

	[SerializeField]
	private GameObject m_sNewSkill;

	[SerializeField]
	private GameObject m_goOKButton;

	[SerializeField]
	private GameObject m_goSkipButton;

	[SerializeField]
	private UICenterOnChild m_sCenter;

	[SerializeField]
	private UIPageGrid m_sPage;

	[SerializeField]
	private UILabel m_sNewLab;

	private List<GameObject> m_sSkillAndBlazeList;

	private int m_iBlazePage;

	private int m_iCharaDF;

	private int m_iAfterLevel;

	private const string c_sNewSkill = "NEWス";

	private const string c_sNewBlaze = "NEWブレ\ufffd";

	private void Test()
	{
	}

	private void Awake()
	{
	}

	public void Init(CharaDetail charaDetail, int afterLevel)
	{
	}

	private void SetCenter(GameObject obj)
	{
	}

	public void OnSkip()
	{
	}

	public void OnOK()
	{
	}

	private void Clear()
	{
	}

	private void SetCoroutine()
	{
	}

	[DebuggerHidden]
	private IEnumerator LevelUpSound()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Execute()
	{
		return null;
	}

	public static LevelUpManager Create(Transform root)
	{
		return null;
	}
}
