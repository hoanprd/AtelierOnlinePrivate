using UnityEngine;

public class FreeAlterMaterialInfo : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goSelect;

	[SerializeField]
	private GameObject m_goReady;

	[SerializeField]
	private UISprite m_sCategoryIcon;

	[SerializeField]
	private FreeAlterUserInfo m_sCharaRoot;

	private int m_iIndex;

	public int Index
	{
		get
		{
			return 0;
		}
	}

	public void Init(int index, int category)
	{
	}

	public void SetData(MultiPlay_AlchemyMaterialData data)
	{
	}
}
