using UnityEngine;

public class ItemBarChara : MonoBehaviour
{
	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private UILabel m_sName;

	private int m_iCharaDF;

	public int CharaDF
	{
		get
		{
			return 0;
		}
	}

	public void Init(int charaDF)
	{
	}
}
