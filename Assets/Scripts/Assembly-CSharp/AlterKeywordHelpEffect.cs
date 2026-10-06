using UnityEngine;

public class AlterKeywordHelpEffect : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goEffectPrefab;

	[SerializeField]
	private Transform[] m_atrPosList;

	[SerializeField]
	private Animation m_sAnim;

	private GameObject[] m_agoEffectObject;

	private bool m_bInit;

	public bool IsAnim
	{
		get
		{
			return false;
		}
	}

	private void Create()
	{
	}

	public void Reset()
	{
	}

	public void Init(MultiPlay_AlchemyData data)
	{
	}
}
