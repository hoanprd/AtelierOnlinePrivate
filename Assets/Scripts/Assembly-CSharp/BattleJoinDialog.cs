using System;
using UnityEngine;

public class BattleJoinDialog : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goHostMark;

	[SerializeField]
	private UISprite m_scrIconSprite;

	[SerializeField]
	private UILabel m_scrPlayerName;

	[SerializeField]
	private UITweenReset m_scrTweenRest;

	private EButtonKind m_eResult;

	private Action<EButtonKind> m_acCallback;

	public void Init(MultiPlay_CharaData clsChara, Action<EButtonKind> acCallback = null)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void OnDecide()
	{
	}

	public void OnCancel()
	{
	}

	private void Close()
	{
	}

	private void OnClose()
	{
	}
}
