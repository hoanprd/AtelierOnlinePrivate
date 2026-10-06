using System.Collections.Generic;
using UnityEngine;

public class Game_UI_GotItemBalloon : MonoBehaviour
{
	private enum EStep
	{
		eWAIT = 0,
		eBRINGIN = 1,
		eDISP_WAIT = 2,
		eDISMISS = 3,
		eEND = 4
	}

	private struct Item
	{
		private enum EState
		{
			eBRINGIN = 1,
			eDISMISS = 2
		}

		public GameObject goBody;

		public UITweenReset sAnim;

		public Game_UI_GotItemBalloonItem sDetail;

		public void Bringin()
		{
		}

		public void Dismiss()
		{
		}
	}

	public UIGrid m_grid;

	public Vector3 m_drawOffset;

	public GameObject m_goPrefab;

	public Transform[] m_atrRootList;

	public UIRoot m_uiRoot;

	public UIPanel m_uiPanel;

	private Item[] m_asItemList;

	private EStep m_eStep;

	private List<InventoryInfo> m_vMaterialList;

	private bool m_bClose;

	private float m_fWaitTime;

	private const float cfWAIT_TIME = 0.5f;

	private const float cfLIMIT_TIME = 3f;

	private void Awake()
	{
	}

	public void CloseRequest()
	{
	}

	public void SetItemList(InventoryInfo[] itemArray)
	{
	}

	private void Update()
	{
	}

	private void End()
	{
	}

	private void InitPosition()
	{
	}

	private void Bringin()
	{
	}

	private void Dismiss()
	{
	}

	private bool IsFinish()
	{
		return false;
	}
}
