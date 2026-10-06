using UnityEngine;

public class TargetArrow : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goRoot;

	private float m_fDistance;

	private Vector3 m_vTarget;

	private GameObject m_goTarget;

	private int m_iID;

	private bool m_bFix;

	private float m_fAngle;

	private GameObject m_goRader;

	private const int ciOFFSET = 30;

	public int ID
	{
		get
		{
			return 0;
		}
	}

	private void OnDestroy()
	{
	}

	public void Init(int id, Vector3 target, float distance)
	{
	}

	public void Init(int id, GameObject target, float angle, float distance = 0f)
	{
	}

	public void SetActive(bool active)
	{
	}

	private void Update()
	{
	}

	public float GetAngle(Vector2 p1, Vector2 p2)
	{
		return 0f;
	}
}
