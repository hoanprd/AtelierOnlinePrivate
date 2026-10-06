using UnityEngine;

public class Game_UI_GotItemBalloonItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRareEffect;

	[SerializeField]
	private Transform m_trItemRoot;

	private ItemBar m_sDetail;

	public void Init(InventoryInfo info)
	{
	}
}
