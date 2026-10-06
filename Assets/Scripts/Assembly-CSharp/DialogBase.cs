using UnityEngine;

public class DialogBase : MonoBehaviour
{
	protected int m_iFrontDepth;

	protected int m_iBackDepth;

	protected int GetFrontDepth()
	{
		return 0;
	}

	public int GetBackDepth()
	{
		return 0;
	}

	protected void AddDepth(int offset)
	{
	}

	public void SetFrontDepth()
	{
	}

	public void SetLayer(int layer)
	{
	}

	public void SetLayer(string layer)
	{
	}

	protected void CreateBackground()
	{
	}

	public virtual void Bringin()
	{
	}

	public virtual void Dismiss()
	{
	}
}
