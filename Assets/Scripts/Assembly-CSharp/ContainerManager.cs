using UnityEngine;

public class ContainerManager : UIWindowBase
{
	[SerializeField]
	private ContainerInventorySorceList m_sSource;

	[SerializeField]
	private ContainerInventoryList m_sDest;

	[SerializeField]
	private ContainerConfirmDialog m_sConfirm;

	[SerializeField]
	private Animation m_sChangeAnim;

	private GameObject m_goCollision;

	public void Init()
	{
	}

	public void OnChangeRequest()
	{
	}

	private void ChangeRequest()
	{
	}

	public void OnChange()
	{
	}

	public void OnChangeEnd()
	{
	}

	public void OnExecute()
	{
	}

	private void Send()
	{
	}

	public override void OnClose()
	{
	}
}
