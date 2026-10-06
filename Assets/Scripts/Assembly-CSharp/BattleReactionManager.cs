using UnityEngine;

public class BattleReactionManager : MonoBehaviour
{
	public GameObject m_goWindowPrefab;

	public Transform[] m_atrRoot;

	private BattleReactionWindow[] m_asWindow;

	private void Awake()
	{
	}

	private BattleReactionWindow GetWindow(int charaID)
	{
		return null;
	}

	public void Init()
	{
	}

	public void Bringin(int charaID, string name, string content, Texture2D tex = null)
	{
	}

	public void Dismiss(int charaID)
	{
	}

	public void AddContent(int charaID, string content)
	{
	}
}
