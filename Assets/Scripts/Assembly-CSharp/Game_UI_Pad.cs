using System.Collections.Generic;
using UnityEngine;

public class Game_UI_Pad : MonoBehaviour
{
	public Game_InputManager.eControlKind m_targetControlKind;

	public GameObject m_worldPosObject;

	public GameObject m_localPosObject;

	public UIPanel m_localUiPanel;

	private float m_padMove_Start;

	private float m_padMove_PercentScale;

	private float m_padMove_PosScale;

	public GameObject m_localRotObject;

	public GameObject m_delayPosObject;

	private Color m_padObjectColor_Now;

	private Vector3 m_padObjectPos_Origin;

	private Vector3 m_padObjectPos_Now;

	private Vector3 m_padObjectPos_Delay;

	private static readonly float m_padColorAlpha_Min;

	private static readonly float m_padColorAlpha_Max;

	private float m_padActivePercent;

	private bool m_padActiveFlag;

	private float m_padPressSec_Now;

	public GameObject m_houkouObj;

	private float m_houkouActiveMg;

	private List<UIWidget> m_padUIWidget;

	private float m_padPressSec_Action
	{
		get
		{
			return 0f;
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Touch(bool touch)
	{
	}

	private void PadRotate()
	{
	}

	private void SetDrawFlag(bool flag)
	{
	}
}
