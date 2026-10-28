using UnityEngine;

public class DialogBase : MonoBehaviour
{
	protected int m_iFrontDepth;

	protected int m_iBackDepth;

	protected int GetFrontDepth()
	{
		UIPanel[] panels = GetComponentsInChildren<UIPanel>(true);
		int maxDepth = 0;
		for (int i = 0; i < panels.Length; i++)
		{
			if (panels[i] != null && panels[i].depth > maxDepth)
			{
				maxDepth = panels[i].depth;
			}
		}
		return maxDepth;
	}

	public int GetBackDepth()
	{
		UIPanel[] panels = GetComponentsInChildren<UIPanel>(true);
		int minDepth = -1;
		for (int i = 0; i < panels.Length; i++)
		{
			if (panels[i] != null && panels[i].transform.parent == transform)
			{
				int d = panels[i].depth;
				if (minDepth < 0 || d < minDepth)
				{
					minDepth = d;
				}
			}
		}
		return minDepth;
	}

	protected void AddDepth(int offset)
	{
		UIPanel[] panels = GetComponentsInChildren<UIPanel>(true);
		for (int i = 0; i < panels.Length; i++)
		{
			if (panels[i] != null)
			{
				panels[i].depth += offset;
			}
		}
	}

	public void SetFrontDepth()
	{
		UIPanel[] allPanels = Object.FindObjectsByType<UIPanel>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
		int highest = 100;
		for (int i = 0; i < allPanels.Length; i++)
		{
			if (allPanels[i] != null && !allPanels[i].transform.IsChildOf(transform) && allPanels[i].gameObject.layer == gameObject.layer)
			{
				if (allPanels[i].depth > highest)
				{
					highest = allPanels[i].depth;
				}
			}
		}
		int back = GetBackDepth();
		if (back < 0)
		{
			back = 0;
		}
		AddDepth(highest + 10 - back);
		m_iFrontDepth = GetFrontDepth();
		m_iBackDepth = GetBackDepth();
	}

	public void SetLayer(int layer)
	{
		Util.SetLayerRecursively(gameObject, layer);
		UIRoot[] roots = Object.FindObjectsByType<UIRoot>(FindObjectsInactive.Include, FindObjectsSortMode.None);
		for (int i = 0; i < roots.Length; i++)
		{
			if (roots[i] != null && roots[i].gameObject.layer == layer)
			{
				transform.SetParent(roots[i].transform, false);
				transform.localPosition = Vector3.zero;
				transform.localScale = Vector3.one;
				break;
			}
		}
	}

	public void SetLayer(string layer)
	{
		int layerId = LayerMask.NameToLayer(layer);
		if (layerId >= 0)
		{
			SetLayer(layerId);
		}
	}

	protected void CreateBackground()
	{
		GameObject bg = GameObject.Find("Black_BoxC");
		if (bg == null)
		{
			Object prefab = Resources.Load("Menu/Black_BoxC");
			if (prefab == null)
			{
				return;
			}
			bg = Object.Instantiate(prefab) as GameObject;
			if (bg == null)
			{
				return;
			}
			bg.name = "Black_BoxC";
		}
		Util.SetLayerRecursively(bg, gameObject.layer);
		bg.transform.SetParent(transform, false);
		bg.transform.localPosition = Vector3.zero;
		bg.transform.localScale = Vector3.one;
		UIPanel panel = bg.GetComponentInChildren<UIPanel>();
		if (panel != null)
		{
			panel.depth = GetBackDepth() - 1;
		}
	}

	public virtual void Bringin()
	{
	}

	public virtual void Dismiss()
	{
	}
}
