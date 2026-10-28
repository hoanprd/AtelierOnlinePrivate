using System.Collections.Generic;
using UnityEngine;

public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate;

	public List<GameObject> deactivate;

	[HideInInspector]
	[SerializeField]
	private GameObject target;

	[HideInInspector]
	[SerializeField]
	private bool inverse;

	private void Awake()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse) deactivate.Add(target);
				else activate.Add(target);
			}
			else target = null;
		}
		UIToggle toggle = GetComponent<UIToggle>();
		if (toggle != null) EventDelegate.Add(toggle.onChange, Toggle);
	}

	public void Reset(bool select)
	{
		if (enabled)
		{
			for (int i = 0; i < activate.Count; i++) Set(activate[i], select);
			for (int j = 0; j < deactivate.Count; j++) Set(deactivate[j], !select);
		}
	}

	public void Toggle()
	{
		bool val = (UIToggle.current != null) && UIToggle.current.value;
		if (enabled)
		{
			for (int i = 0; i < activate.Count; i++) Set(activate[i], val);
			for (int j = 0; j < deactivate.Count; j++) Set(deactivate[j], !val);
		}
	}

	private void Set(GameObject go, bool state)
	{
		if (go != null) NGUITools.SetActive(go, state);
	}
}
