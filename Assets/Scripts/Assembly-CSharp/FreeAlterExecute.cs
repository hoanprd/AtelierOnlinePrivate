using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class FreeAlterExecute : MonoBehaviour
{
	[Serializable]
	public struct SpoonInfo
	{
		public UILabel sNum;

		public FreeAlterUserInfo sUserInfo;
	}

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private SpawnPrefabData m_sDetail;

	[SerializeField]
	private AlterExecuteEffect m_sExecuteEffect;

	[SerializeField]
	private FreeAlterExecuteButton m_sExecuteButton;

	[SerializeField]
	private AlterKeywordHelpEffect m_sHelpEffect;

	[SerializeField]
	private FreeAlterResult m_sResult;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private SpoonInfo m_sSpoon;

	[SerializeField]
	private GameObject m_goMaterialInfoPrefab;

	[SerializeField]
	private Transform[] m_atrMaterialRoot;

	private FreeAlterMaterialInfo[] m_asMaterialInfo;

	private MultiPlay_AlchemyData m_sMultiplayData;

	private bool m_bDispResult;

	private Action m_sCloseEvent;

	private void Awake()
	{
	}

	public void Dismiss()
	{
	}

	public void Init(MultiPlay_AlchemyData data, Action callback)
	{
	}

	private void ModifyInventory(InventoryInfo result)
	{
	}

	[DebuggerHidden]
	private IEnumerator Execute(InventoryInfo result)
	{
		return null;
	}

	private void Update()
	{
	}
}
