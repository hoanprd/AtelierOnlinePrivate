using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIFont : MonoBehaviour, INGUIFont
{
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Rect mUVRect = new Rect(0f, 0f, 1f, 1f);

	[HideInInspector]
	[SerializeField]
	private BMFont mFont = new BMFont();

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mAtlas;

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mReplacement;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols = new List<BMSymbol>();

	[HideInInspector]
	[SerializeField]
	private Font mDynamicFont;

	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize = 16;

	[HideInInspector]
	[SerializeField]
	private FontStyle mDynamicFontStyle;

	[NonSerialized]
	private UISpriteData mSprite;

	[NonSerialized]
	private int mPMA = -1;

	[NonSerialized]
	private int mPacked = -1;

	public BMFont bmFont
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.bmFont : mFont;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.bmFont = value;
			}
			else
			{
				mFont = value;
			}
		}
	}

	public int texWidth
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.texWidth : ((mFont != null) ? mFont.texWidth : 1);
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.texWidth = value;
			}
			else if (mFont != null)
			{
				mFont.texWidth = value;
			}
		}
	}

	public int texHeight
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.texHeight : ((mFont != null) ? mFont.texHeight : 1);
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.texHeight = value;
			}
			else if (mFont != null)
			{
				mFont.texHeight = value;
			}
		}
	}

	public bool hasSymbols
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.hasSymbols : (mSymbols != null && mSymbols.Count != 0);
		}
	}

	public List<BMSymbol> symbols
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.symbols : mSymbols;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.symbols = value;
			}
			else
			{
				mSymbols = value;
			}
		}
	}

	public INGUIAtlas atlas
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.atlas : (mAtlas as INGUIAtlas);
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.atlas = value;
			}
			else if (mAtlas as INGUIAtlas != value)
			{
				mPMA = -1;
				mAtlas = value as UnityEngine.Object;
				if (value != null)
				{
					mMat = value.spriteMaterial;
					if (sprite != null)
					{
						mUVRect = uvRect;
					}
				}
				MarkAsChanged();
			}
		}
	}

	public Material material
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.material;
			}
			INGUIAtlas ia = mAtlas as INGUIAtlas;
			if (ia != null)
			{
				return ia.spriteMaterial;
			}
			if (mMat != null)
			{
				if (mDynamicFont != null && mMat != mDynamicFont.material)
				{
					mMat.mainTexture = mDynamicFont.material.mainTexture;
				}
				return mMat;
			}
			if (mDynamicFont != null)
			{
				return mDynamicFont.material;
			}
			return null;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.material = value;
			}
			else if (mMat != value)
			{
				mPMA = -1;
				mMat = value;
				MarkAsChanged();
			}
		}
	}

	[Obsolete]
	public bool premultipliedAlpha
	{
		get
		{
			return premultipliedAlphaShader;
		}
	}

	public bool premultipliedAlphaShader
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.premultipliedAlphaShader;
			}
			INGUIAtlas ia = mAtlas as INGUIAtlas;
			if (ia != null)
			{
				return ia.premultipliedAlpha;
			}
			if (mPMA == -1)
			{
				Material mat = material;
				mPMA = ((mat != null && mat.shader != null && mat.shader.name.Contains("Premultiplied")) ? 1 : 0);
			}
			return mPMA == 1;
		}
	}

	public bool packedFontShader
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.packedFontShader;
			}
			if (mAtlas != null)
			{
				return false;
			}
			if (mPacked == -1)
			{
				Material mat = material;
				mPacked = ((mat != null && mat.shader != null && mat.shader.name.Contains("Packed")) ? 1 : 0);
			}
			return mPacked == 1;
		}
	}

	public Texture2D texture
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.texture;
			}
			Material mat = material;
			return (mat != null) ? (mat.mainTexture as Texture2D) : null;
		}
	}

	public Rect uvRect
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.uvRect;
			}
			return (mAtlas != null && sprite != null) ? mUVRect : new Rect(0f, 0f, 1f, 1f);
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.uvRect = value;
			}
			else if (sprite == null && mUVRect != value)
			{
				mUVRect = value;
				MarkAsChanged();
			}
		}
	}

	public string spriteName
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.spriteName : mFont.spriteName;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.spriteName = value;
			}
			else if (mFont.spriteName != value)
			{
				mFont.spriteName = value;
				MarkAsChanged();
			}
		}
	}

	public bool isValid
	{
		get
		{
			return mDynamicFont != null || mFont.isValid;
		}
	}

	[Obsolete]
	public int size
	{
		get { return defaultSize; }
		set { defaultSize = value; }
	}

	public int defaultSize
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.defaultSize;
			}
			if (isDynamic || mFont == null)
			{
				return mDynamicFontSize;
			}
			return mFont.charSize;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.defaultSize = value;
			}
			else
			{
				mDynamicFontSize = value;
			}
		}
	}

	public UISpriteData sprite
	{
		get
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				return rep.sprite;
			}
			INGUIAtlas ia = mAtlas as INGUIAtlas;
			if (mSprite == null && ia != null && mFont != null && !string.IsNullOrEmpty(mFont.spriteName))
			{
				mSprite = ia.GetSprite(mFont.spriteName);
				if (mSprite == null)
				{
					mSprite = ia.GetSprite(name);
				}
				if (mSprite == null)
				{
					mFont.spriteName = null;
				}
				else
				{
					UpdateUVRect();
				}
				if (mSymbols != null)
				{
					for (int i = 0; i < mSymbols.Count; i++)
					{
						symbols[i].MarkAsChanged();
					}
				}
			}
			return mSprite;
		}
	}

	public INGUIFont replacement
	{
		get
		{
			return mReplacement as INGUIFont;
		}
		set
		{
			INGUIFont rep = value;
			if (rep == (INGUIFont)this)
			{
				rep = null;
			}
			if (mReplacement as INGUIFont != rep)
			{
				if (rep != null && rep.replacement == (INGUIFont)this)
				{
					rep.replacement = null;
				}
				if (mReplacement != null)
				{
					MarkAsChanged();
				}
				mReplacement = rep as UnityEngine.Object;
				if (rep != null)
				{
					mPMA = -1;
					mMat = null;
					mFont = null;
					mDynamicFont = null;
				}
				MarkAsChanged();
			}
		}
	}

	public INGUIFont finalFont
	{
		get
		{
			INGUIFont fnt = this;
			for (int i = 0; i < 10; i++)
			{
				INGUIFont rep = fnt.replacement;
				if (rep != null)
				{
					fnt = rep;
				}
			}
			return fnt;
		}
	}

	public bool isDynamic
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.isDynamic : (mDynamicFont != null);
		}
	}

	public Font dynamicFont
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.dynamicFont : mDynamicFont;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.dynamicFont = value;
			}
			else if (mDynamicFont != value)
			{
				if (mDynamicFont != null)
				{
					material = null;
				}
				mDynamicFont = value;
				MarkAsChanged();
			}
		}
	}

	public FontStyle dynamicFontStyle
	{
		get
		{
			INGUIFont rep = replacement;
			return (rep != null) ? rep.dynamicFontStyle : mDynamicFontStyle;
		}
		set
		{
			INGUIFont rep = replacement;
			if (rep != null)
			{
				rep.dynamicFontStyle = value;
			}
			else if (mDynamicFontStyle != value)
			{
				mDynamicFontStyle = value;
				MarkAsChanged();
			}
		}
	}

	public UISpriteData GetSprite(string spriteName)
	{
		INGUIAtlas ia = atlas;
		return (ia != null) ? ia.GetSprite(spriteName) : null;
	}

	private void Trim()
	{
		INGUIAtlas ia = mAtlas as INGUIAtlas;
		if (ia != null && ia.texture != null && mSprite != null)
		{
			Rect full = NGUIMath.ConvertToPixels(mUVRect, texture.width, texture.height, true);
			Rect trimmed = new Rect(mSprite.x, mSprite.y, mSprite.width, mSprite.height);
			int xMin = Mathf.RoundToInt(trimmed.xMin - full.xMin);
			int yMin = Mathf.RoundToInt(trimmed.yMin - full.yMin);
			int xMax = Mathf.RoundToInt(trimmed.xMax - full.xMin);
			int yMax = Mathf.RoundToInt(trimmed.yMax - full.yMin);
			mFont.Trim(xMin, yMin, xMax, yMax);
		}
	}

	public bool References(INGUIFont font)
	{
		if (font == null)
		{
			return false;
		}
		if (font == (INGUIFont)this)
		{
			return true;
		}
		INGUIFont rep = replacement;
		return rep != null && rep.References(font);
	}

	public void MarkAsChanged()
	{
		INGUIFont rep = replacement;
		if (rep != null)
		{
			rep.MarkAsChanged();
		}
		mSprite = null;
		UILabel[] labels = NGUITools.FindActive<UILabel>();
		for (int i = 0; i < labels.Length; i++)
		{
			UILabel lbl = labels[i];
			if (lbl.enabled && NGUITools.GetActive(lbl.gameObject) && NGUITools.CheckIfRelated(this, lbl.bitmapFont))
			{
				INGUIFont fnt = lbl.bitmapFont;
				lbl.bitmapFont = null;
				lbl.bitmapFont = fnt;
			}
		}
		if (mSymbols != null)
		{
			for (int j = 0; j < symbols.Count; j++)
			{
				symbols[j].MarkAsChanged();
			}
		}
	}

	public void UpdateUVRect()
	{
		if (mAtlas == null)
		{
			return;
		}
		Texture tex = (mAtlas as INGUIAtlas).texture;
		if (tex != null)
		{
			mUVRect = new Rect(mSprite.x - mSprite.paddingLeft, mSprite.y - mSprite.paddingTop, mSprite.width + mSprite.paddingLeft + mSprite.paddingRight, mSprite.height + mSprite.paddingTop + mSprite.paddingBottom);
			mUVRect = NGUIMath.ConvertToTexCoords(mUVRect, tex.width, tex.height);
			if (mSprite.hasPadding)
			{
				Trim();
			}
		}
	}

	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		for (int i = 0; i < mSymbols.Count; i++)
		{
			BMSymbol sym = mSymbols[i];
			if (sym.sequence == sequence)
			{
				return sym;
			}
		}
		if (createIfMissing)
		{
			BMSymbol sym2 = new BMSymbol();
			sym2.sequence = sequence;
			mSymbols.Add(sym2);
			return sym2;
		}
		return null;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		int count = mSymbols.Count;
		if (count == 0)
		{
			return null;
		}
		textLength -= offset;
		for (int i = 0; i < count; i++)
		{
			BMSymbol sym = mSymbols[i];
			int len = sym.length;
			if (len == 0 || textLength < len)
			{
				continue;
			}
			bool match = true;
			for (int j = 0; j < len; j++)
			{
				if (text[offset + j] != sym.sequence[j])
				{
					match = false;
					break;
				}
			}
			if (match && sym.Validate(atlas))
			{
				return sym;
			}
		}
		return null;
	}

	public void AddSymbol(string sequence, string spriteName)
	{
		BMSymbol symbol = GetSymbol(sequence, true);
		symbol.spriteName = spriteName;
		MarkAsChanged();
	}

	public void RemoveSymbol(string sequence)
	{
		BMSymbol symbol = GetSymbol(sequence, false);
		if (symbol != null)
		{
			symbols.Remove(symbol);
		}
		MarkAsChanged();
	}

	public void RenameSymbol(string before, string after)
	{
		BMSymbol symbol = GetSymbol(before, false);
		if (symbol != null)
		{
			symbol.sequence = after;
		}
		MarkAsChanged();
	}

	public bool UsesSprite(string s)
	{
		if (!string.IsNullOrEmpty(s))
		{
			if (s.Equals(spriteName))
			{
				return true;
			}
			for (int i = 0; i < symbols.Count; i++)
			{
				BMSymbol sym = symbols[i];
				if (s.Equals(sym.spriteName))
				{
					return true;
				}
			}
		}
		return false;
	}
}
