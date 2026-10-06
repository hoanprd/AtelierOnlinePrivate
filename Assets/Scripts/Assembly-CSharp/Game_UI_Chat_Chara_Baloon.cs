using UnityEngine;

public class Game_UI_Chat_Chara_Baloon : Game_UI_Chat_Baloon_Base
{
	public enum eLabel
	{
		Remark = 0,
		Name = 1,
		EnumMax = 2
	}

	public enum eSprite
	{
		Stamp = 0,
		BaloonSquare = 1,
		BaloonArrow = 2,
		RemarkerMark = 3,
		EnumMax = 4
	}

	private static readonly int[] c_iTweenGroupArray;

	private static readonly int c_iBaloonArrowSize;

	private NGUI_Wrapper_Tween[] m_clsTweenWrapper;

	private bool m_bDismissTween;

	private Game_UI_Chat_Screen_Manager.eBaloonArrow m_eArrow;

	private Vector2 m_v2BaloonSize;

	private int m_iPlayerId;

	[SerializeField]
	private UISprite[] m_scrBaloonArrowArray;

	[SerializeField]
	private GameObject m_goOffsetObj;

	[SerializeField]
	private GameObject m_goTweenObj;

	[SerializeField]
	private GameObject m_goNameRoot;

	private const int cs_iDispTextCount = 12;

	protected override int c_iBaloonWidth_Char_PerEm
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonWidth_Char_PerHalf
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonWidth_Char_Origin
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonHeight_Char
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonWidth_Stamp
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonHeight_Stamp
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonWidthOffset
	{
		get
		{
			return 0;
		}
	}

	protected override int c_iBaloonHeightOffset
	{
		get
		{
			return 0;
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetChatData(MultiPlay_ChatData clsChat)
	{
	}

	public void SetArrow(Game_UI_Chat_Screen_Manager.eBaloonArrow eArrow, bool bStartTween)
	{
	}

	public void SetRemarkerUI(bool bActive)
	{
	}

	public Vector2 GetBaloonSize()
	{
		return default(Vector2);
	}

	public void Remove(bool bSoon)
	{
	}
}
