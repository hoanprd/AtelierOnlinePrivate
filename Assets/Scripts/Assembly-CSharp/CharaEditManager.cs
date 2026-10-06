using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CharaEditManager : MonoBehaviour
{
	[SerializeField]
	private UIButton m_sDecideButton;

	[SerializeField]
	private UIButton m_sBackButton;

	[SerializeField]
	private AnimationController m_sTabAnim;

	[SerializeField]
	private AnimationController m_sSelectWindowAnim;

	[SerializeField]
	private UICurveLabel m_sPlayerName;

	[SerializeField]
	private EquipmentModel m_sModel;

	[SerializeField]
	private GameObject m_goDecideButton;

	[SerializeField]
	private GameObject[] m_agoDecideEffect;

	[SerializeField]
	private UILabel m_sSelectTitle;

	[SerializeField]
	private CharaEditUserName m_sSelectName;

	[SerializeField]
	private CharaEditGender m_sSelectGender;

	[SerializeField]
	private CharaEditHead m_sSelectHead;

	private bool m_bChange;

	private Action<bool> m_sOnExit;

	private bool m_bFirst;

	private bool m_bInit;

	private ECharaMakePartKind m_eSelectKind;

	private MakeCharaData m_sMakeCharaData;

	private int m_iPrevGender;

	private SalonInfo m_sInfo;

	public void Init(SalonInfo info, Action<bool> onExit, bool enableBack = true)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnDecide()
	{
	}

	public void OnChangeName(string value)
	{
	}

	private void SendCharaData(bool decideSE = true)
	{
	}

	private void PlayDeicideSE()
	{
	}

	public void OnChangeTab(CharaEditTabItem tab)
	{
	}

	[DebuggerHidden]
	private IEnumerator ChangeSelectWindow()
	{
		return null;
	}

	private void InitSelectWindow()
	{
	}

	public static CharaEditManager Create(Transform root)
	{
		return null;
	}
}
