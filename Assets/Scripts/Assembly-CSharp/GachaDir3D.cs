using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GachaDir3D : GachaDirBase
{
	[SerializeField]
	private GameObject[] m_ago3DObject;

	[SerializeField]
	private GachaDirGem[] m_asGemList;

	[SerializeField]
	private GameObject[] m_agoRingList;

	[SerializeField]
	private GameObject m_goRareParticle;

	private void OnEnable()
	{
	}

	[DebuggerHidden]
	public IEnumerator Play(ShopGachaLot data, List<EGachaResultKind> kind)
	{
		return null;
	}
}
