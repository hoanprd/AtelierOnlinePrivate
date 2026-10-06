using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TrainingFoodWindow : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private SpawnPrefabData m_sDirection;

	[SerializeField]
	private UIButton m_sExecuteButton;

	[SerializeField]
	private TrainingParam m_sParam;

	[SerializeField]
	private UILabel m_sNow;

	[SerializeField]
	private UILabel m_sMaxNum;

	[SerializeField]
	private GameObject m_goInfo;

	[SerializeField]
	private Transform m_trItemDetailRoot;

	[SerializeField]
	private GameObject m_goFoodItemPrefab;

	[SerializeField]
	private Transform[] m_atrFoodRoot;

	[SerializeField]
	private GameObject[] m_agoFoodEffect;

	[SerializeField]
	private FoodSelectWindow m_sSelectWindow;

	[SerializeField]
	private GameObject m_goExecuteEffect;

	[SerializeField]
	private GameObject[] m_agoExecuteFoodEffect;

	private GrowCharaData m_sTarget;

	private MasterChara.Fdm m_sInfo;

	private List<InventoryInfo> m_vInventoryList;

	private List<InventoryInfo> m_vFoodList;

	private List<TrainingFoodItem> m_vFoodInfoList;

	private Action m_sOnExit;

	private bool m_bLack;

	private bool m_bLock;

	private ItemDetailWindow m_sItemDetailWindow;

	private bool m_bCloseMaterialNow;

	public bool IsLack
	{
		get
		{
			return false;
		}
	}

	public bool IsLock
	{
		get
		{
			return false;
		}
	}

	public int NowMissionID
	{
		get
		{
			return 0;
		}
	}

	public bool IsEnableExecute
	{
		get
		{
			return false;
		}
	}

	public List<long> Feeds
	{
		get
		{
			return null;
		}
	}

	public List<InventoryInfo> FeedInventory
	{
		get
		{
			return null;
		}
	}

	private void Create()
	{
	}

	public void Execute()
	{
	}

	public void UpdateInfo(GrowCharaData target, ResponseDataCommon common, FoodInfo info, bool anim)
	{
	}

	private void UpdateInfo(GrowCharaData target, ResponseDataCommon common, FoodInfo info)
	{
	}

	private void InitNone(GrowCharaData target)
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateFoodMenu(GrowCharaData target, ResponseDataCommon common, FoodInfo info)
	{
		return null;
	}

	public void Init(GrowCharaData target, ResponseDataCommon common, FoodInfo info, Action onExit)
	{
	}

	public void OnAlterMaterial(TrainingFoodItem item)
	{
	}

	private void OnAlterResult(bool alter, List<InventoryInfo> create, List<InventoryInfo> use)
	{
	}

	public void OnMaterialSelect(TrainingFoodItem item)
	{
	}

	public void OnChangeMaterial()
	{
	}

	public void OnClose()
	{
	}

	private void OnChooseMaterial(List<InventoryInfo> select)
	{
	}

	private void OnCloseEnd()
	{
	}
}
