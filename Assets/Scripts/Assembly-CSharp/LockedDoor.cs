using DunGen;
using UnityEngine;

public class LockedDoor : MonoBehaviour, IKeyLock
{
	public float OpenDuration;

	public Vector3 OpenPositionOffset;

	[HideInInspector]
	[SerializeField]
	private int keyID;

	[HideInInspector]
	[SerializeField]
	private KeyManager keyManager;

	private Vector3 initialPosition;

	private float openTime;

	private bool isOpening;

	private Door door;

	public Key Key
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	public void OnKeyAssigned(Key key, KeyManager keyManager)
	{
	}

	private void OnTriggerEnter(Collider c)
	{
	}

	private void Update()
	{
	}

	private void Open()
	{
	}
}
