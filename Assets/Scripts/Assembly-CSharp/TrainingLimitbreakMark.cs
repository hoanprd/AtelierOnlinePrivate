using System.Collections.Generic;
using UnityEngine;

public class TrainingLimitbreakMark : MonoBehaviour
{
	[SerializeField]
	private UIGrid m_sLargeGrid;

	[SerializeField]
	private UIGrid m_sSmallGrid;

	[SerializeField]
	private GameObject m_goBigPrefab;

	[SerializeField]
	private GameObject m_goSmallPrefab;

	[SerializeField]
	private List<TrainingLimitbreakMarkIcon> m_vLargeList;

	[SerializeField]
	private List<TrainingLimitbreakMarkIcon> m_vSmallList;

	private int m_iNow;

	private int m_iLarge;

	private int m_iSmall;

	private bool Play(int count, List<TrainingLimitbreakMarkIcon> target)
	{
		return false;
	}

	private void Create(int num, List<TrainingLimitbreakMarkIcon> target, GameObject prefab, UIGrid root)
	{
	}

	public void Init(int now)
	{
	}

	public void Play(int next)
	{
	}
}
