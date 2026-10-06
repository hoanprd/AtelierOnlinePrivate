using UnityEngine;

public class BattleReactionWindow : MonoBehaviour
{
	public UILabel m_sCharaName;

	public UITexture m_tFace;

	public GameObject m_goLabelPrefab;

	public Transform m_trLabelRoot;

	public UITweenReset m_sAnim;

	private int m_iUseLabelIndex;

	private BattleReactionLabel[] m_asLabel;

	private int m_iCharaID;

	private bool m_bDismiss;

	private const int ciLABEL_NUM = 3;

	public int CharaID
	{
		get
		{
			return 0;
		}
	}

	public bool IsEnable
	{
		get
		{
			return false;
		}
	}

	public void Init()
	{
	}

	public void Init(int charaID, string name, Texture2D face = null)
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss()
	{
	}

	public void AddContent(string content)
	{
	}
}
