public class System_PinchManager : SingletonBase<System_PinchManager>
{
	private bool m_bPinch;

	public float m_fBeganDist { get; private set; }

	public float m_fPrevDist { get; private set; }

	public float m_fNowDist { get; private set; }

	private void Update()
	{
	}

	public bool IsPinch()
	{
		return false;
	}

	public float GetPinchPer_Began()
	{
		return 0f;
	}

	public float GetPinchPer_Prev()
	{
		return 0f;
	}

	public void ResetBeganDist()
	{
	}
}
