using System;
using UnityEngine;

public class LimitbreakWindow : UIWindowBase
{
	[Serializable]
	public class Param
	{
		public UILabel sNowLV;

		public TrainingLimitbreakMark sLimitbreak;

		public TrainingParam sParam;
	}

	[SerializeField]
	private Param[] m_asParam;

	[SerializeField]
	private LimitbreakConfirmWindow m_sConfirm;

	private CharaDetail m_sTarget;

	public void Init(CharaDetail target)
	{
	}

	public override void OnClose()
	{
	}

	public void OnConfirm()
	{
	}

	public void OnDecide()
	{
	}
}
