using UnityEngine;

public class RenderFrontThanUIPanel : MonoBehaviour
{
	[SerializeField]
	public UIPanel panel;

	[SerializeField]
	public int queueOffset;

	[SerializeField]
	public bool isChild;

	private int m_renderq;

	private void LateUpdate()
	{
	}

	private void UpdateRenderQueue(Transform _transform)
	{
	}
}
