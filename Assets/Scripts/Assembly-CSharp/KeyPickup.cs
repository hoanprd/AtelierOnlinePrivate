using DunGen;
using UnityEngine;

public class KeyPickup : MonoBehaviour, IKeyLock
{
	[HideInInspector]
	[SerializeField]
	private int keyID;

	[HideInInspector]
	[SerializeField]
	private KeyManager keyManager;

	public Key Key
	{
		get
		{
			return null;
		}
	}

	public void OnKeyAssigned(Key key, KeyManager keyManager)
	{
	}

	private void OnTriggerEnter(Collider c)
	{
	}
}
