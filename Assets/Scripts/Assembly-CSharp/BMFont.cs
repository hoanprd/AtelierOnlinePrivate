using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BMFont
{
	[HideInInspector]
	[SerializeField]
	private int mSize = 16;

	[HideInInspector]
	[SerializeField]
	private int mBase;

	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[HideInInspector]
	[SerializeField]
	private int mHeight;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[HideInInspector]
	[SerializeField]
	private List<BMGlyph> mSaved = new List<BMGlyph>();

	private Dictionary<int, BMGlyph> mDict = new Dictionary<int, BMGlyph>();

	public bool isValid
	{
		get
		{
			return (mSaved != null && mSaved.Count > 0) || LegacyCheck();
		}
	}

	public int charSize
	{
		get { return mSize; }
		set { mSize = value; }
	}

	public int baseOffset
	{
		get { return mBase; }
		set { mBase = value; }
	}

	public int texWidth
	{
		get { return mWidth; }
		set { mWidth = value; }
	}

	public int texHeight
	{
		get { return mHeight; }
		set { mHeight = value; }
	}

	public int glyphCount
	{
		get { return isValid ? mSaved.Count : 0; }
	}

	public string spriteName
	{
		get { return mSpriteName; }
		set { mSpriteName = value; }
	}

	public List<BMGlyph> glyphs
	{
		get { return mSaved; }
	}

	private bool LegacyCheck()
	{
		return false;
	}

	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		BMGlyph glyph = null;
		if (mDict == null)
		{
			mDict = new Dictionary<int, BMGlyph>();
		}
		if (mDict.Count == 0 && mSaved != null && mSaved.Count > 0)
		{
			for (int i = 0; i < mSaved.Count; i++)
			{
				BMGlyph bmg = mSaved[i];
				if (bmg != null)
				{
					mDict[bmg.index] = bmg;
				}
			}
		}
		if (!mDict.TryGetValue(index, out glyph) && createIfMissing)
		{
			glyph = new BMGlyph();
			glyph.index = index;
			if (mSaved == null)
			{
				mSaved = new List<BMGlyph>();
			}
			mSaved.Add(glyph);
			mDict.Add(index, glyph);
		}
		return glyph;
	}

	public BMGlyph GetGlyph(int index)
	{
		return GetGlyph(index, false);
	}

	public void Clear()
	{
		if (mDict != null)
		{
			mDict.Clear();
		}
		if (mSaved != null)
		{
			mSaved.Clear();
		}
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
		if (isValid)
		{
			for (int i = 0; i < mSaved.Count; i++)
			{
				BMGlyph glyph = mSaved[i];
				if (glyph != null)
				{
					glyph.Trim(xMin, yMin, xMax, yMax);
				}
			}
		}
	}
}
