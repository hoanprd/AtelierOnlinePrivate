using System.Collections.Generic;
using UnityEngine;

public class Emoticon : MonoBehaviour
{
	private enum ETweenKind
	{
		eBRINGIN = 1,
		eDISMISS = 2
	}

	private List<GameObject> m_vgoEmoticon;

	private EEmoticon m_eKind;

	private bool m_bAnimEnd;

	public bool IsAnimEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsDisp
	{
		get
		{
			return false;
		}
	}

	private void Init()
	{
	}

	public void Play(EEmoticon kind)
	{
	}

	private void PlayAnim(GameObject target, ETweenKind tweenKind)
	{
	}

	private void OnAnimEnd()
	{
	}
}
