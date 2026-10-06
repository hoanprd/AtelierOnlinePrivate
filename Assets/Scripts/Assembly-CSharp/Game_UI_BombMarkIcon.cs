using UnityEngine;

public class Game_UI_BombMarkIcon : MonoBehaviour
{
	private enum eMainStep
	{
		FadeI_Init = 0,
		FadeI_Wait = 1,
		FadeO_Init = 2,
		FadeO_Wait = 3
	}

	private NGUI_Wrapper_Tween m_nguiTween_Main;

	public Vector3 m_drawOffset;

	public Vector3 m_targetPos;

	private eMainStep m_eMainStep;

	private bool m_notifyFlag;

	public UISprite m_itemMarkSprite;

	public void SetNotify(bool flag, Vector3 vecPos)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
