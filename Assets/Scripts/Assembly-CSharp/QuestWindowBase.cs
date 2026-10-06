using UnityEngine;

public class QuestWindowBase : UIWindowBase
{
	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	protected Transform m_trTargetDetailRoot;

	protected override void OnCloseEnd()
	{
	}
}
