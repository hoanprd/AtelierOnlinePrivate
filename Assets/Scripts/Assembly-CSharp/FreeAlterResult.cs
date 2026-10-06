using UnityEngine;

public class FreeAlterResult : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private SpawnPrefabData m_sItemData;

	public bool IsAnim
	{
		get
		{
			return false;
		}
	}

	public void Reset()
	{
	}

	public void Init(InventoryInfo result)
	{
	}
}
