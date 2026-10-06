using UnityEngine;

public class Game_UI_Chat_Baloon_Base : MonoBehaviour
{
	[SerializeField]
	protected UILabel[] m_scrLabelArray;

	[SerializeField]
	protected UISprite[] m_scrSpriteArray;

	protected virtual int c_iBaloonWidth_Char_PerEm
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonWidth_Char_PerHalf
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonWidth_Char_Origin
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonHeight_Char
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonWidth_Stamp
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonHeight_Stamp
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonWidthOffset
	{
		get
		{
			return 0;
		}
	}

	protected virtual int c_iBaloonHeightOffset
	{
		get
		{
			return 0;
		}
	}

	protected virtual void SetLabelText(int iIndex, string strText)
	{
	}

	protected virtual void SetLabelActive(int iIndex, bool bActive)
	{
	}

	protected virtual bool IsExistLabel(int iIndex)
	{
		return false;
	}

	protected virtual void SetSprite(int iIndex, string strSpriteName, bool bStamp = false)
	{
	}

	protected virtual void SetSpriteSize_Phrase(int iIndex, string strPhrase)
	{
	}

	protected virtual void SetSpriteSize_Stamp(int iIndex)
	{
	}

	protected virtual void SetSpriteSize(int iIndex, int iWidth, int iHeight)
	{
	}

	protected virtual void SetSpriteColor(int iIndex, Color cColor)
	{
	}

	protected virtual void SetSpriteColor(UISprite scrSprite, Color cColor)
	{
	}

	protected virtual void SetSpriteActive(int iIndex, bool bActive)
	{
	}

	protected virtual Vector2 GetSpriteSize(int iIndex)
	{
		return default(Vector2);
	}

	protected virtual bool IsExistSprite(int iIndex)
	{
		return false;
	}
}
