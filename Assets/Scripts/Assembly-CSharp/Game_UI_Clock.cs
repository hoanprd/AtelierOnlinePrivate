using UnityEngine;

public class Game_UI_Clock : MonoBehaviour
{
	public GameObject m_targetClock;

	public UISprite m_targetSprite;

	public UISprite m_moveSprite;

	public UITweener m_move;

	private int m_sectionLog;

	private string[] m_sectionIconNameArray;

	private int[] m_sectionTimeArray;

	protected void Update()
	{
	}
}
