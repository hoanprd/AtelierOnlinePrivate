using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FreeAlterManager : MonoBehaviour
{
	private enum EState
	{
		eBRINGIN = 0,
		eSELECT_KEYWORD = 1,
		eWAIT = 2,
		eSELECT_MATERIAL = 3,
		eDISMISS = 4
	}

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private GameObject m_goPlayerStatusPrefab;

	[SerializeField]
	private Transform m_trPlayerStatusRoot;

	[SerializeField]
	private FreeAlterExecute m_sExecuteWindow;

	[SerializeField]
	private AlterKeywordSelect m_sKeywordSelect;

	[SerializeField]
	private AlterExecuteMaterialSelect m_sMaterialSelect;

	[SerializeField]
	private Transform m_trDetailRoot;

	[SerializeField]
	private AlterExecuteMaterialSelect m_sSelectDecide;

	[SerializeField]
	private Transform m_trSelectWindowRoot;

	[SerializeField]
	private GameObject m_goSelectWindowPrefab;

	private ItemDetailWindow m_sDetailWindow;

	private Game_UI_Status m_sPlayerStatus;

	private ItemSelectWindow m_sSelectWindow;

	private int m_iRoomID;

	private int m_iSelectIndex;

	private EState m_eState;

	private MultiPlay_AlchemyData m_sMultiplayData;

	private Action m_sCallback;

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public void OnCloseButton()
	{
	}

	private void OnCloseConfirm(EButtonKind result)
	{
	}

	private void OnClose()
	{
	}

	public void OnExecute()
	{
	}

	public void Init(int host = 0)
	{
	}

	private void OnSelectKeyword()
	{
	}

	[DebuggerHidden]
	private IEnumerator StartAlchemy()
	{
		return null;
	}

	public void OnSelectMaterial(FreeAlterMaterialInfo btn)
	{
	}

	[DebuggerHidden]
	private IEnumerator SelectMaterial(int index)
	{
		return null;
	}

	private void OnDecideMaterials(List<InventoryInfo> select)
	{
	}

	public void OnDecideMaterial()
	{
	}

	private void OnDetail(InventoryInfo mat)
	{
	}

	private void Update()
	{
	}
}
