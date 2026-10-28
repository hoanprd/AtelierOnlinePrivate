using UnityEngine;

public class RenderFrontThanUIPanel : MonoBehaviour
{
	[SerializeField]
	public UIPanel panel;

	[SerializeField]
	public int queueOffset = 1;

	[SerializeField]
	public bool isChild = true;

	private int m_renderq = -1;

	private void LateUpdate()
	{
		if (panel == null)
		{
			panel = NGUITools.FindInParents<UIPanel>(gameObject);
		}
		if (panel != null)
		{
			int targetQueue = panel.startingRenderQueue + panel.drawCalls.Count + queueOffset;
			if (m_renderq != targetQueue)
			{
				m_renderq = targetQueue;
				UpdateRenderQueue(transform);
			}
		}
	}

	private void UpdateRenderQueue(Transform _transform)
	{
		if (_transform == null) return;
		Renderer ren = _transform.GetComponent<Renderer>();
		if (ren != null && ren.materials != null)
		{
			Material[] mats = ren.materials;
			for (int i = 0; i < mats.Length; i++)
			{
				if (mats[i] != null)
				{
					mats[i].renderQueue = m_renderq;
				}
			}
		}
		if (isChild)
		{
			for (int j = 0; j < _transform.childCount; j++)
			{
				UpdateRenderQueue(_transform.GetChild(j));
			}
		}
	}
}
