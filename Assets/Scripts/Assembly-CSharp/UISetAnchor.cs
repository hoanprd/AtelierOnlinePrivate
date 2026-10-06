using System;
using UnityEngine;

public class UISetAnchor : MonoBehaviour
{
	[Serializable]
	public class Info
	{
		public float fRelative;

		public int iValue;

		public void Copy(UIRect.AnchorPoint anchor)
		{
		}
	}

	public Info m_sLeft;

	public Info m_sRight;

	public Info m_sBottom;

	public Info m_sTop;

	private void Start()
	{
	}

	private void Copy()
	{
	}

	private void Apply()
	{
	}
}
