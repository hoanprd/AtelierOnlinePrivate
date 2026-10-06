using System.Collections.Generic;
using UnityEngine;

public class Game_UI_Chat_Window_PhraseList : MonoBehaviour
{
	private static readonly Vector3 c_v3MakeOffsetPos;

	[SerializeField]
	private GameObject m_goPhraseBase;

	[SerializeField]
	private UIScrollView m_scrScrollView;

	[SerializeField]
	private UIGrid m_scrGrid;

	[SerializeField]
	private UIScrollListArrow m_scrArrow;

	private List<Game_UI_Chat_Button_Phrase> m_scrPhraseList;

	private void Awake()
	{
	}

	private void OnReposition()
	{
	}

	private void Start()
	{
	}

	public void UpdatePhrase()
	{
	}

	public void SetScrollBar(UIScrollBar scrBar)
	{
	}
}
