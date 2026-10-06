using System.Collections.Generic;
using UnityEngine;

public class NGUI_Wrapper_Tween : NGUI_Wrapper_Base
{
	public bool m_useGroupID;

	public int m_groupID;

	private List<UITweener> m_scrTweenerList;

	public void SetScript(Transform trTemp, string strChildObjName, bool includeChilds, int groupID = -1)
	{
	}

	public void SetScript(Transform parent, bool includeChilds, int groupID = -1)
	{
	}

	protected void Initialize(Transform parent, bool includeChilds, int groupID = -1)
	{
	}

	protected void GetTweenScript(Transform parent, bool includeChilds)
	{
	}

	public void StopTween()
	{
	}

	public void PlayTween(bool forward)
	{
	}

	public bool IsTweenFinished()
	{
		return false;
	}
}
