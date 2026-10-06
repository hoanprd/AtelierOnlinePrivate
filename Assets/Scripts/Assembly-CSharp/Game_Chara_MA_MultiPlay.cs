using UnityEngine;

public class Game_Chara_MA_MultiPlay : Game_Chara_MA_Player
{
	private int m_roomIndex;

	private Game_UI_MA_PlayerInfo m_info;

	private Game_UI_MA_MultiAlterButton m_alterButton;

	private Texture m_raderTexture;

	private Texture m_raderTextureFar;

	private Vector3 m_prevPos;

	public bool m_isCharaUpdate;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void InitChara(bool isOwner)
	{
	}

	public void UpdateInfo(MultiPlay_CharaData data)
	{
	}

	public void DispInfo(bool bFlag)
	{
	}

	public void UpdateName(MultiPlay_CharaData data)
	{
	}

	public void UpdateAbnormalState(MultiPlay_CharaData data)
	{
	}

	public bool GetAnimationBool(string name)
	{
		return false;
	}

	public bool GetAnimationTrigger(string name)
	{
		return false;
	}

	public int GetAnimationInteger(string name)
	{
		return 0;
	}

	public float GetAnimationFloat(string name)
	{
		return 0f;
	}

	public void SetAnimationBool(string name, bool param)
	{
	}

	public void SetAnimationTrigger(string name)
	{
	}

	public void SetAnimationInteger(string name, int param)
	{
	}

	public void SetAnimationFloat(string name, float param)
	{
	}

	public void UpdatePC(MultiPlay_CharaData data)
	{
	}

	public void UpdatePC_Pause(MultiPlay_CharaData data)
	{
	}

	public void UpdateNPC(MultiPlay_CharaData data)
	{
	}

	protected override void Initialize_Sub()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected override void MoverUpdate_Pause()
	{
	}

	private void SetRoomIndex(int index)
	{
	}

	public override void UpdateRaderMap()
	{
	}
}
