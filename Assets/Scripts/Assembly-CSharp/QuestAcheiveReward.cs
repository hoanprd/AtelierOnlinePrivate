using UnityEngine;

public class QuestAcheiveReward : MonoBehaviour
{
	public GameObject m_goItemBarPrefab;

	public Transform m_trItemBarRoot;

	public ItemBar m_scrItemBar;

	public void Init(int df, int quality, int num = 0, int trt = 0)
	{
	}

	public void Init(EWealthKind kind, int num)
	{
	}
}
