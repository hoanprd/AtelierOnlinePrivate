using DunGen;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
	public enum DoorState
	{
		Open = 0,
		Closed = 1,
		Opening = 2,
		Closing = 3
	}

	public GameObject Door;

	public Vector3 OpenOffset;

	public float Speed;

	private Vector3 closedPosition;

	private DoorState currentState;

	private float currentFramePosition;

	private Door doorComponent;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
