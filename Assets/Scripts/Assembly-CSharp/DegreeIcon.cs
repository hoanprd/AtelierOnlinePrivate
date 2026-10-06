using UnityEngine;

public class DegreeIcon : MonoBehaviour
{
	[SerializeField]
	private Color[] m_asBackgroundColor;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UITexture m_txIcon;

	[SerializeField]
	private UISprite m_sBackground;

	public void Init(MasterDegreeInfo degree)
	{
	}

	public static DegreeIcon Create(Transform root)
	{
		return null;
	}

	public void setTitleDisp(bool flg)
	{
	}
}
