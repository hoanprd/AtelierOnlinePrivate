using System;

public class Game_Chara_TM_Base : Game_Chara_Base
{
	private Action m_acMakeCallback;

	public void Init(int iNPCId, Action acCallback = null)
	{
	}

	protected override void InstantiateModel(MakeCharaData mk, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	protected override void Initialize()
	{
	}

	protected override eCharaShaderGroupKind GetShaderGroupKind()
	{
		return eCharaShaderGroupKind.Normal;
	}
}
