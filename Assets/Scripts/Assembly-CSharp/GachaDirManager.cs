using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GachaDirManager : MonoBehaviour
{
	private delegate EGachaResultKind GetResultKindMethod(ShopGachaLot.LotResult result);

	private delegate IEnumerator SingleDirectionMethod(ShopGachaLotResponse data, ShopGachaLot.LotResult result, EGachaResultKind kind);

	private delegate IEnumerator MultiDirectionMethod(ShopGachaLotResponse data, List<EGachaResultKind> kind, GachaInfo.SellInfo price, GachaInfo.Data info);

	[SerializeField]
	private GachaDir3D m_s3DAnim;

	[SerializeField]
	private GachaDirSingle m_goSingle;

	[SerializeField]
	private GachaDirMulti m_goMulti;

	private int m_iProductID;

	private GachaInfo.Data m_sInfo;

	private GachaInfo.SellInfo m_sPrice;

	private ShopGachaLotResponse m_sResponse;

	private ShopGachaLot m_sResult;

	private ShopGachaDisassemble[] m_asDecomposeResult;

	private bool m_bSending;

	private bool m_bExit;

	private bool m_bOnlyDecompose;

	private ShopGachaDisassembleResponse m_sDisassembleResoponse;

	public ShopGachaDisassembleResponse DisassembleResponse
	{
		get
		{
			return null;
		}
	}

	[DebuggerHidden]
	public IEnumerator Play(int df, ShopGachaLotResponse data, GachaInfo.SellInfo price = null, GachaInfo.Data info = null, bool isAfterDirection = false)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Decompose(List<ShopGachaLot.LotResult> decomposeList)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Retry()
	{
		return null;
	}

	private void OnGachaLot(ShopGachaLotResponse res)
	{
	}

	private void OnDecompose(ShopGachaDisassembleResponse res)
	{
	}

	private List<EGachaResultKind> GetResultKindList(List<ShopGachaLot.LotResult> resultList, GetResultKindMethod getMethod)
	{
		return null;
	}
}
