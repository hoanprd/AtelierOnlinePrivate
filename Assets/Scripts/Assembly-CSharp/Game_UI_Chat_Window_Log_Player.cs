public class Game_UI_Chat_Window_Log_Player : Game_UI_Chat_Baloon_Base
{
	private enum eLabel
	{
		PlayerName = 0,
		Remark = 1,
		EnumMax = 2
	}

	private enum eSprite
	{
		Stamp = 0,
		PlayerMark = 1,
		Baloon = 2,
		Baloon_Sub = 3,
		EnumMax = 4
	}

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

	public void SetChatData(MultiPlay_ChatData clsChat)
	{
	}
}
