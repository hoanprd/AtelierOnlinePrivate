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
		base.Awake();
		SetDisp(sbDisp);
	}

	private void Update()
	{
		if (sbDisp)
		{
			sfDispTime -= Time.unscaledDeltaTime;
			if (sfDispTime <= 0f)
			{
				SetDisp(false);
			}
		}
	}

	private void SetDisp(bool sw)
	{
		sbDisp = sw;
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child != null)
			{
				child.gameObject.SetActive(sw);
			}
		}
	}

	public static void DispRequest(string content = "Connecting")
	{
		if (!IsExist)
		{
			return;
		}
		Instance.sfDispTime = 0.2f;
		if (!Instance.sbDisp)
		{
			Instance.SetDisp(true);
		}
	}
}
