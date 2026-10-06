using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BattleCutInManager : MonoBehaviour
{
	[SerializeField]
	private GameObject m_cutInRoot;

	[SerializeField]
	private UITexture m_charaTexture;

	[SerializeField]
	private UIPanel m_cutInBasePanel;

	[SerializeField]
	private UIPanel m_cutInBaseString;

	[SerializeField]
	private UISprite m_cutInString_back;

	[SerializeField]
	private UISprite m_cutInString_01;

	[SerializeField]
	private UISprite m_cutInString_02;

	[SerializeField]
	private UISprite m_cutInString_03;

	[SerializeField]
	private UISprite m_cutInString_04;

	[SerializeField]
	private UISprite m_cutInString_05;

	[SerializeField]
	private UISprite m_cutInString_06;

	[SerializeField]
	private UISprite m_cutInString_07;

	[SerializeField]
	private UISprite m_cutInString_08;

	[SerializeField]
	private UISprite m_cutInString_09;

	[SerializeField]
	private UISprite m_cutInString_10;

	[SerializeField]
	private UISprite m_cutInString_01_s;

	[SerializeField]
	private UISprite m_cutInString_02_s;

	[SerializeField]
	private UISprite m_cutInString_03_s;

	[SerializeField]
	private UISprite m_cutInString_04_s;

	[SerializeField]
	private UISprite m_cutInString_05_s;

	[SerializeField]
	private UISprite m_cutInString_06_s;

	[SerializeField]
	private UISprite m_cutInString_07_s;

	[SerializeField]
	private UISprite m_cutInString_08_s;

	[SerializeField]
	private UISprite m_cutInString_09_s;

	[SerializeField]
	private UISprite m_cutInString_10_s;

	[SerializeField]
	private float m_cutInSeBeforeWait;

	[SerializeField]
	private eSoundID m_cutInSe;

	private List<UISprite> m_cutInString;

	private bool m_stringMoveFinished;

	private bool m_scaleFinished;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Init(int memberId)
	{
	}

	public void OnCharaMoveFininshed()
	{
	}

	public void OnStringMoveFininshed()
	{
	}

	public void OnScaleFininshed()
	{
	}

	[DebuggerHidden]
	public IEnumerator Play()
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerator PlaySe()
	{
		return null;
	}
}
