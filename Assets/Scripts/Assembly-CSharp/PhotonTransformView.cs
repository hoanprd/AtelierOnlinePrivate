using UnityEngine;

public class PhotonTransformView : MonoBehaviour, IPunObservable
{
	[SerializeField]
	public PhotonTransformViewPositionModel m_PositionModel;

	[SerializeField]
	public PhotonTransformViewRotationModel m_RotationModel;

	[SerializeField]
	public PhotonTransformViewScaleModel m_ScaleModel;

	private PhotonTransformViewPositionControl m_PositionControl;

	private PhotonTransformViewRotationControl m_RotationControl;

	private PhotonTransformViewScaleControl m_ScaleControl;

	private PhotonView m_PhotonView;

	private bool m_ReceivedNetworkUpdate;

	private bool m_firstTake;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}

	private void UpdateRotation()
	{
	}

	private void UpdateScale()
	{
	}

	public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
	{
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	private void DoDrawEstimatedPositionError()
	{
	}
}
