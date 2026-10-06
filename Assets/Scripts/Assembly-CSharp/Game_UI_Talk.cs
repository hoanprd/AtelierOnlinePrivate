using UnityEngine;

public class Game_UI_Talk : MonoBehaviour
{
	private enum eMainStep
	{
		Wait = 0,
		Disp = 1,
		EnumMax = 2
	}

	private eMainStep m_mainStep;

	public GameObject m_goTarget;

	public Game_Gimmick_Base m_sTarget;

	public UISprite m_sTalkKindIcon;

	public GameObject m_goMainQuestMark;

	public UITweenReset m_sAnim;

	public GameObject m_targetChild;

	public QuestCategoryMark m_sQuestMark;

	private Vector3 m_originalWorldPos;

	private Vector3 m_offsetPos;

	private float m_visibleDistance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SetAnim()
	{
	}

	public void SetOffset(Vector3 offset)
	{
	}

	public void Init(GameObject target, bool isQuest, int questID, Game_Gimmick_Base targetScr = null)
	{
	}
}
