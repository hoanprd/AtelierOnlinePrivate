using DunGen;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float MinYaw;

	public float MaxYaw;

	public float MinPitch;

	public float MaxPitch;

	public float LookSensitivity;

	public float MoveSpeed;

	public float TurnSpeed;

	protected CharacterController movementController;

	protected Camera playerCamera;

	protected Camera overheadCamera;

	protected bool isControlling;

	protected float yaw;

	protected float pitch;

	protected Generator gen;

	protected Vector3 velocity;

	protected virtual void Start()
	{
	}

	protected virtual void OnGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
	{
	}

	protected virtual void Update()
	{
	}

	protected float ClampAngle(float angle)
	{
		return 0f;
	}

	protected float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	protected void ToggleControl()
	{
	}

	protected void FrameObjectWithCamera(GameObject gameObject)
	{
	}
}
