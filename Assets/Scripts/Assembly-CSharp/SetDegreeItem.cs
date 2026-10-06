using UnityEngine;

public class SetDegreeItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goSetMark;

	[SerializeField]
	private Transform m_trMarkRoot;

	private DegreeIcon m_sIcon;

	private DegreeInfo m_sDegree;

	public DegreeInfo Degree
	{
		get
		{
			return null;
		}
	}

	public void Init(DegreeInfo deg, bool set)
	{
	}
}
