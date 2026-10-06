using UnityEngine;

public class MapAreaSceneRoot : MonoBehaviour
{
	private static MapAreaSceneRoot s_Instance;

	public GameObject m_goNavmeshRoot;

	public static MapAreaSceneRoot Instance
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
