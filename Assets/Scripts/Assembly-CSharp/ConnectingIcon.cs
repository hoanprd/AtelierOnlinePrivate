using UnityEngine;

public class ConnectingIcon : SingletonBase<ConnectingIcon>
{
	[SerializeField]
	private UICurveLabel sLabel;

	[SerializeField]
	private GameObject goCollision;

	private float sfDispTime;

	private bool sbDisp;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	private void SetDisp(bool sw)
	{
	}

	public static void DispRequest(string content = "Connecting")
	{
	}
}
