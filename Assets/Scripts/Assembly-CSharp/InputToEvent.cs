using UnityEngine;

public class InputToEvent : MonoBehaviour
{
	private GameObject lastGo;

	public static Vector3 inputHitPos;

	public bool DetectPointedAtGameObject;

	private Vector2 pressedPosition;

	private Vector2 currentPos;

	public bool Dragging;

	private Camera m_Camera;

	public static GameObject goPointedAt { get; private set; }

	public Vector2 DragVector
	{
		get
		{
			return default(Vector2);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Press(Vector2 screenPos)
	{
	}

	private void Release(Vector2 screenPos)
	{
	}

	private GameObject RaycastObject(Vector2 screenPos)
	{
		return null;
	}
}
