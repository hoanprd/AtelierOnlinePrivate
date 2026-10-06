using UnityEngine;

public class GetDegreePerform : SingletonBase<GetDegreePerform>
{
	private DegreeIcon m_scrIcon;

	[SerializeField]
	private UITweenReset m_scrTween;

	[SerializeField]
	private Transform m_trIconRoot;

	private void Start()
	{
	}

	private void OnEndTween()
	{
	}

	public void SetDegree(MasterDegreeInfo clsDeg)
	{
	}
}
