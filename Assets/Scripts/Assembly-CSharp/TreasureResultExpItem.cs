using UnityEngine;

public class TreasureResultExpItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sLv;

	[SerializeField]
	private UILabel m_sMaxLv;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UISlider m_sExpGauge;

	private int count;

	public void Init(BattleResultCharaInfo data, int charaDF)
	{
	}

	public void SetSkip(BattleResultCharaInfo data, int charaDF)
	{
	}

	public void SetStartLV(int nowLV, int lvcap)
	{
	}

	public void SetStartExp(float exp, int nowEXPcap_H, int nowEXPcap_L)
	{
	}

	public void Lerp(float start, float end, float time, int nowLV, int beforeLV, int nowEXPcap_H, int nowEXPcap_L, int beforeEXPcap_H, int beforeEXPcap_L)
	{
	}
}
