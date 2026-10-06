using System.Collections.Generic;
using UnityEngine;

public class Game_MA_MazeHintManager : MonoBehaviour
{
	private static Game_MA_MazeHintManager s_scrInstance;

	public List<Game_MA_MazeHintColl> m_scrCollList;

	public static Game_MA_MazeHintManager Instance
	{
		get
		{
			return null;
		}
	}

	public void UpdateRoute(bool bReturn)
	{
	}

	private void Awake()
	{
	}
}
