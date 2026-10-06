using UnityEngine;

public class Game_UI_DamageNumber : MonoBehaviour
{
	public UILabel m_sNumber;

	public UILabel m_sShadow;

	public UITweenReset m_sTween;

	private Vector3 m_vTarget;

	private Vector3 m_vOffset;

	public virtual void OnFinished()
	{
	}

	public void ChangePos(Vector3 pos)
	{
	}

	public void Init(Vector3 pos, int num, bool rotRandom)
	{
	}

	private void Update()
	{
	}
}
