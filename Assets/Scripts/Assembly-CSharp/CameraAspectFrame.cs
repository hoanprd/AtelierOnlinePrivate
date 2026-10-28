using UnityEngine;

public class CameraAspectFrame : MonoBehaviour
{
	public GameObject goTarget;

	public GameObject goBlackout;

	private bool iPhoneX;

	private void Awake()
	{
		iPhoneX = GameDefine.IsiPhoneX();
		if (iPhoneX && goTarget != null)
		{
			goTarget.transform.localPosition = new Vector3(0f, 32f, 0f);
		}
	}

	private void Update()
	{
		SetOffset();
	}

	private void SetOffset()
	{
		if (iPhoneX && goTarget != null)
		{
			goTarget.transform.localPosition = new Vector3(0f, 32f, 0f);
		}
	}

	public void SetBlackOut(bool sw)
	{
		if (goBlackout != null)
		{
			goBlackout.SetActive(sw);
		}
	}
}
