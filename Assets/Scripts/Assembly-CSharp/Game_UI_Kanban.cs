using UnityEngine;

public class Game_UI_Kanban : MonoBehaviour
{
	private enum eMainStep
	{
		Wait = 0,
		Fade_I = 1,
		Visible = 2,
		Fade_O = 3,
		EnumMax = 4
	}

	private static readonly int c_baloonWidth_PerChar_Em;

	private static readonly int c_baloonWidth_PerChar_Half;

	private static readonly int c_baloonWidth_Origin;

	private static readonly int c_baloonHeight_PerChar;

	private static readonly int c_baloonHeight_Origin;

	private eMainStep m_mainStep;

	private UITweenReset m_uiTweenReset;

	public GameObject m_targetChild;

	private Vector3 m_originalWorldPos;

	private Vector3 m_offsetPos;

	public UILabel m_uiLabel_Kanban;

	public UISprite m_uiSprite_Base;

	private float m_visibleDistance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetKanbanText(Vector3 pos, string text, float distance, Vector3 offsetPos)
	{
	}
}
