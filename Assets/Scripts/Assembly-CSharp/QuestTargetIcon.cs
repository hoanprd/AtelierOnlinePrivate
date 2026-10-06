using UnityEngine;

[ExecuteInEditMode]
public class QuestTargetIcon : MonoBehaviour
{
	private enum EMultiTargetTypeKind
	{
		eENEMY = 0,
		eALTER = 1,
		eSKILL = 2,
		ePICKUP = 3
	}

	[SerializeField]
	private UITexture m_txArea;

	[SerializeField]
	private UITexture m_txFace;

	[SerializeField]
	private UITexture m_txItem;

	[SerializeField]
	private UITexture m_txEnemy;

	[SerializeField]
	private UITexture m_txObj;

	[SerializeField]
	private UISprite m_sKind;

	public void Reset()
	{
	}

	public void Init(MasterQuestInfo master, bool isNotSelectedDummyData = false)
	{
	}

	public void InitItem(int df)
	{
	}

	public void InitChara(int df)
	{
	}

	public void InitEnemy(string path, bool silhouette)
	{
	}

	public void InitArea(int area)
	{
	}

	private void InitKind(EMultiTargetTypeKind kind)
	{
	}
}
