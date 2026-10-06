using UnityEngine;

public class Game_Gimmick_Base : System_Mover_Base
{
	[SerializeField]
	private SphereCollider m_scrTriggerColl;

	public int m_spotPos;

	public int m_spotNo;

	protected bool m_isExec;

	protected Game_Animal_GimmickFader m_fader;

	protected MultiPlay_GimmickData m_multiPlayGimmickData;

	public virtual void SetSpotPos(int pos)
	{
	}

	public virtual void SetSpotNo(int no)
	{
	}

	public virtual void SetFader(Game_Animal_GimmickFader fader)
	{
	}

	public virtual void UpdateSpotInfo()
	{
	}

	public int GetGimmickNo()
	{
		return 0;
	}

	public void SetMultiPlayGimmickData(MultiPlay_GimmickData data)
	{
	}

	public void SetColliderData(Vector3 v3Center, float fRadius)
	{
	}

	protected virtual void OnTriggerEnter(Collider scrCol)
	{
	}

	protected virtual void OnHitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	protected virtual void OnTriggerExit(Collider scrCol)
	{
	}

	protected virtual void OnExitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	protected virtual void OnDisable()
	{
	}

	public virtual bool IsEnable()
	{
		return false;
	}

	public virtual EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public virtual bool IsImmediate()
	{
		return false;
	}

	public virtual bool IsOnce()
	{
		return false;
	}

	public void ExecMulti(bool perform)
	{
	}

	protected virtual void ExecMultiSub(bool perform)
	{
	}

	public bool IsExec()
	{
		return false;
	}

	public virtual void Send_GimmickReserve(bool bCancel = false)
	{
	}

	public virtual int GetGimmickExecCharaId()
	{
		return 0;
	}

	public virtual void Send_GimmickExec()
	{
	}
}
