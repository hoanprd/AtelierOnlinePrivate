using System.Collections.Generic;
using UnityEngine;

public class SpringBone : MonoBehaviour
{
	public Transform child;

	public Vector3 boneAxis;

	public float radius;

	public float stiffnessForce;

	public float dragForce;

	public Vector3 springForce;

	public List<SpringCollider> colliders;

	public bool debug;

	private float springLength;

	private Quaternion localRotation;

	private Transform trs;

	private Vector3 currTipPos;

	private Vector3 prevTipPos;

	private float scale;

	public List<string> colliderNames;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetScale(float value)
	{
	}

	public float GetRadius()
	{
		return 0f;
	}

	public void UpdateSpring()
	{
	}

	public void SettingCollider(List<SpringCollider> list)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
