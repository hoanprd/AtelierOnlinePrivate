using System.Collections.Generic;
using UnityEngine;

public class Game_Gimmick_UseBombBase : Game_Gimmick_Base
{
	private static readonly float[] sr_fBombScaleAry;

	private static readonly int[,] sr_iNeedBombDFAry;

	protected InventoryInfo[] m_clsItemArray;

	protected Game_Gimmick_BombBase m_scrBomb;

	public eBombKind m_eNeedBombKind;

	public eBombLevel m_eNeedBombLevel;

	public static int GetNeedBombDF(eBombKind eBomb, eBombLevel eLv)
	{
		return 0;
	}

	protected override void Start()
	{
	}

	private List<string> GetNeedAssetPath()
	{
		return null;
	}

	protected virtual string GetBombEffectAssetPath()
	{
		return null;
	}

	protected virtual string GetExecEffectAssetPath()
	{
		return null;
	}

	protected override void OnTriggerEnter(Collider scrColl)
	{
	}

	protected virtual void ExecOwn()
	{
	}

	public void SetResItem(InventoryInfo[] clsItemArray)
	{
	}

	public override bool IsEnable()
	{
		return false;
	}

	public int GetBestBomb()
	{
		return 0;
	}

	public int GetNeedBomb()
	{
		return 0;
	}

	public int GetEnableBombCount()
	{
		return 0;
	}

	public float GetMakeBombScale(int iUseBombDF)
	{
		return 0f;
	}
}
