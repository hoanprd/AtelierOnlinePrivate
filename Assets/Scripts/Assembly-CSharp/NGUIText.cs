using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

public static class NGUIText
{
	[DoNotObfuscateNGUI]
	public enum Alignment
	{
		Automatic = 0,
		Left = 1,
		Center = 2,
		Right = 3,
		Justified = 4
	}

	[DoNotObfuscateNGUI]
	public enum SymbolStyle
	{
		None = 0,
		Normal = 1,
		Colored = 2,
		NoOutline = 3
	}

	public class GlyphInfo
	{
		public Vector2 v0;

		public Vector2 v1;

		public Vector2 u0;

		public Vector2 u1;

		public Vector2 u2;

		public Vector2 u3;

		public float advance;

		public int channel;
	}

	public static INGUIFont bitmapFont;

	public static Font dynamicFont;

	public static GlyphInfo glyph = new GlyphInfo();

	public static int fontSize = 16;

	public static float fontScale = 1f;

	public static float pixelDensity = 1f;

	public static FontStyle fontStyle = FontStyle.Normal;

	public static Alignment alignment = Alignment.Left;

	public static Color tint = Color.white;

	public static int rectWidth = 1000000;

	public static int rectHeight = 1000000;

	public static int regionWidth = 1000000;

	public static int regionHeight = 1000000;

	public static int maxLines = 0;

	public static bool gradient = false;

	public static Color gradientBottom = Color.white;

	public static Color gradientTop = Color.white;

	public static bool encoding = false;

	public static float spacingX = 0f;

	public static float spacingY = 0f;

	public static bool premultiply = false;

	public static SymbolStyle symbolStyle;

	public static int finalSize = 0;

	public static float finalSpacingX = 0f;

	public static float finalLineHeight = 0f;

	public static float baseline = 0f;

	public static bool useSymbols = false;

	private static Color mInvisible = new Color(0f, 0f, 0f, 0f);

	private static BetterList<Color> mColors = new BetterList<Color>();

	private static float mAlpha = 1f;

	private static CharacterInfo mTempChar;

	private static BetterList<float> mSizes = new BetterList<float>();

	private static Color s_c0;

	private static Color s_c1;

	private const float sizeShrinkage = 0.75f;

	private static float[] mBoldOffset = new float[8] { -0.25f, 0f, 0.25f, 0f, 0f, -0.25f, 0f, 0.25f };

	public static bool isDynamic
	{
		get
		{
			return bitmapFont == null;
		}
	}

	public static void Update()
	{
		Update(true);
	}

	public static void Update(bool request)
	{
		finalSize = Mathf.RoundToInt((float)fontSize / pixelDensity);
		finalSpacingX = spacingX * fontScale;
		finalLineHeight = ((float)fontSize + spacingY) * fontScale;
		useSymbols = (dynamicFont != null || bitmapFont != null) && encoding && symbolStyle != SymbolStyle.None;
		Font font = dynamicFont;
		if (font != null && request)
		{
			font.RequestCharactersInTexture(")_-", finalSize, fontStyle);
			if (!font.GetCharacterInfo(')', out mTempChar, finalSize, fontStyle) || (float)mTempChar.maxY == 0f)
			{
				font.RequestCharactersInTexture("A", finalSize, fontStyle);
				if (!font.GetCharacterInfo('A', out mTempChar, finalSize, fontStyle))
				{
					baseline = 0f;
					return;
				}
			}
			float top = mTempChar.maxY;
			float bottom = mTempChar.minY;
			baseline = Mathf.Round(top + ((float)finalSize - top + bottom) * 0.5f);
		}
	}

	public static void Prepare(string text)
	{
		mColors.Clear();
		if (dynamicFont != null && !string.IsNullOrEmpty(text))
		{
			dynamicFont.RequestCharactersInTexture(text, finalSize, fontStyle);
		}
	}

	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return (bitmapFont != null) ? bitmapFont.MatchSymbol(text, index, textLength) : null;
	}

	public static float GetGlyphWidth(int ch, int prev, float fontScale)
	{
		if (bitmapFont != null)
		{
			bool thinSpace = false;
			if (ch == 8201)
			{
				thinSpace = true;
				ch = 32;
			}
			BMGlyph bmg = null;
			if (bitmapFont != null && bitmapFont.bmFont != null)
			{
				bmg = bitmapFont.bmFont.GetGlyph(ch);
			}
			if (bmg != null)
			{
				int adv = bmg.advance;
				if (thinSpace)
				{
					adv >>= 1;
				}
				return fontScale * (float)(adv + bmg.GetKerning(prev));
			}
		}
		else if (dynamicFont != null && dynamicFont.GetCharacterInfo((char)ch, out mTempChar, finalSize, fontStyle))
		{
			return (float)mTempChar.advance * fontScale * pixelDensity;
		}
		return 0f;
	}

	public static GlyphInfo GetGlyph(int ch, int prev, float fontScale = 1f)
	{
		if (bitmapFont != null)
		{
			bool thinSpace = false;
			if (ch == 8201)
			{
				thinSpace = true;
				ch = 32;
			}
			BMGlyph bmg = (bitmapFont.bmFont != null) ? bitmapFont.bmFont.GetGlyph(ch) : null;
			if (bmg != null)
			{
				int kern = ((prev != 0) ? bmg.GetKerning(prev) : 0);
				glyph.v0.x = ((prev != 0) ? (bmg.offsetX + kern) : bmg.offsetX);
				glyph.v1.y = -bmg.offsetY;
				glyph.v1.x = glyph.v0.x + (float)bmg.width;
				glyph.v0.y = glyph.v1.y - (float)bmg.height;
				glyph.u0.x = bmg.x;
				glyph.u0.y = bmg.y + bmg.height;
				glyph.u2.x = bmg.x + bmg.width;
				glyph.u2.y = bmg.y;
				glyph.u1.x = glyph.u0.x;
				glyph.u1.y = glyph.u2.y;
				glyph.u3.x = glyph.u2.x;
				glyph.u3.y = glyph.u0.y;
				int adv = bmg.advance;
				if (thinSpace)
				{
					adv >>= 1;
				}
				glyph.advance = adv + kern;
				glyph.channel = bmg.channel;
				if (fontScale != 1f)
				{
					glyph.v0 *= fontScale;
					glyph.v1 *= fontScale;
					glyph.advance *= fontScale;
				}
				return glyph;
			}
		}
		else if (dynamicFont != null && dynamicFont.GetCharacterInfo((char)ch, out mTempChar, finalSize, fontStyle))
		{
			glyph.v0.x = mTempChar.minX;
			glyph.v1.x = mTempChar.maxX;
			glyph.v0.y = (float)mTempChar.minY - baseline;
			glyph.v1.y = (float)mTempChar.maxY - baseline;
			glyph.u0 = mTempChar.uvBottomLeft;
			glyph.u1 = mTempChar.uvTopLeft;
			glyph.u2 = mTempChar.uvTopRight;
			glyph.u3 = mTempChar.uvBottomRight;
			glyph.advance = mTempChar.advance;
			glyph.channel = 0;
			glyph.v0.x = Mathf.Round(glyph.v0.x);
			glyph.v0.y = Mathf.Round(glyph.v0.y);
			glyph.v1.x = Mathf.Round(glyph.v1.x);
			glyph.v1.y = Mathf.Round(glyph.v1.y);
			float pd = fontScale * pixelDensity;
			if (pd != 1f)
			{
				glyph.v0 *= pd;
				glyph.v1 *= pd;
				glyph.advance *= pd;
			}
			return glyph;
		}
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float ParseAlpha(string text, int index)
	{
		int a = (NGUIMath.HexToDecimal(text[index + 1]) << 4) | NGUIMath.HexToDecimal(text[index + 2]);
		return Mathf.Clamp01((float)a / 255f);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color ParseColor(string text, int offset = 0)
	{
		return ParseColor24(text, offset);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color ParseColor24(string text, int offset = 0)
	{
		int r = (NGUIMath.HexToDecimal(text[offset]) << 4) | NGUIMath.HexToDecimal(text[offset + 1]);
		int g = (NGUIMath.HexToDecimal(text[offset + 2]) << 4) | NGUIMath.HexToDecimal(text[offset + 3]);
		int b = (NGUIMath.HexToDecimal(text[offset + 4]) << 4) | NGUIMath.HexToDecimal(text[offset + 5]);
		float f = 0.003921569f;
		return new Color(f * (float)r, f * (float)g, f * (float)b);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color ParseColor32(string text, int offset)
	{
		int r = (NGUIMath.HexToDecimal(text[offset]) << 4) | NGUIMath.HexToDecimal(text[offset + 1]);
		int g = (NGUIMath.HexToDecimal(text[offset + 2]) << 4) | NGUIMath.HexToDecimal(text[offset + 3]);
		int b = (NGUIMath.HexToDecimal(text[offset + 4]) << 4) | NGUIMath.HexToDecimal(text[offset + 5]);
		int a = (NGUIMath.HexToDecimal(text[offset + 6]) << 4) | NGUIMath.HexToDecimal(text[offset + 7]);
		float f = 0.003921569f;
		return new Color(f * (float)r, f * (float)g, f * (float)b, f * (float)a);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor(Color c)
	{
		return EncodeColor24(c);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor(string text, Color c)
	{
		return "[c][" + EncodeColor24(c) + "]" + text + "[-][/c]";
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeAlpha(float a)
	{
		int val = Mathf.Clamp(Mathf.RoundToInt(a * 255f), 0, 255);
		return NGUIMath.DecimalToHex8(val);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor24(Color c)
	{
		int val = 0xFFFFFF & (NGUIMath.ColorToInt(c) >> 8);
		return NGUIMath.DecimalToHex24(val);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor32(Color c)
	{
		int val = NGUIMath.ColorToInt(c);
		return NGUIMath.DecimalToHex32(val);
	}

	public static bool ParseSymbol(string text, ref int index)
	{
		int sub = 0;
		bool bold = false;
		bool italic = false;
		bool underline = false;
		bool strike = false;
		bool ignoreColor = false;
		return ParseSymbol(text, ref index, null, false, ref sub, ref bold, ref italic, ref underline, ref strike, ref ignoreColor);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool IsHex(char ch)
	{
		return (ch >= '0' && ch <= '9') || (ch >= 'a' && ch <= 'f') || (ch >= 'A' && ch <= 'F');
	}

	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		int length = text.Length;
		if (index + 3 > length || text[index] != '[')
		{
			return false;
		}
		if (text[index + 2] == ']')
		{
			if (text[index + 1] == '-')
			{
				if (colors != null && colors.size > 1)
				{
					colors.RemoveAt(colors.size - 1);
				}
				index += 3;
				return true;
			}
			string sub3 = text.Substring(index, 3);
			switch (sub3)
			{
			case "[b]":
			case "[B]":
				bold = true;
				index += 3;
				return true;
			case "[i]":
			case "[I]":
				italic = true;
				index += 3;
				return true;
			case "[u]":
			case "[U]":
				underline = true;
				index += 3;
				return true;
			case "[s]":
			case "[S]":
				strike = true;
				index += 3;
				return true;
			case "[c]":
			case "[C]":
				ignoreColor = true;
				index += 3;
				return true;
			}
		}
		if (index + 4 > length)
		{
			return false;
		}
		if (text[index + 3] == ']')
		{
			string sub4 = text.Substring(index, 4);
			switch (sub4)
			{
			case "[/b]":
			case "[/B]":
				bold = false;
				index += 4;
				return true;
			case "[/i]":
			case "[/I]":
				italic = false;
				index += 4;
				return true;
			case "[/u]":
			case "[/U]":
				underline = false;
				index += 4;
				return true;
			case "[/s]":
			case "[/S]":
				strike = false;
				index += 4;
				return true;
			case "[/c]":
			case "[/C]":
				ignoreColor = false;
				index += 4;
				return true;
			default:
			{
				char ch0 = text[index + 1];
				char ch1 = text[index + 2];
				if (IsHex(ch0) && IsHex(ch1))
				{
					int a = (NGUIMath.HexToDecimal(ch0) << 4) | NGUIMath.HexToDecimal(ch1);
					mAlpha = (float)a / 255f;
					index += 4;
					return true;
				}
				break;
			}
			}
		}
		if (index + 5 > length)
		{
			return false;
		}
		if (text[index + 4] == ']')
		{
			string sub5 = text.Substring(index, 5);
			switch (sub5)
			{
			case "[sub]":
			case "[SUB]":
				sub = 1;
				index += 5;
				return true;
			case "[sup]":
			case "[SUP]":
				sub = 2;
				index += 5;
				return true;
			}
		}
		if (index + 6 > length)
		{
			return false;
		}
		if (text[index + 5] == ']')
		{
			string sub6 = text.Substring(index, 6);
			switch (sub6)
			{
			case "[/sub]":
			case "[/SUB]":
			case "[/sup]":
			case "[/SUP]":
				sub = 0;
				index += 6;
				return true;
			case "[/url]":
			case "[/URL]":
				index += 6;
				return true;
			}
		}
		if (text[index + 1] == 'u' && text[index + 2] == 'r' && text[index + 3] == 'l' && text[index + 4] == '=')
		{
			int closingBracket = text.IndexOf(']', index + 4);
			if (closingBracket != -1)
			{
				index = closingBracket + 1;
				return true;
			}
			index = text.Length;
			return true;
		}
		if (index + 8 > length)
		{
			return false;
		}
		if (text[index + 7] == ']')
		{
			if (IsHex(text[index + 1]) && IsHex(text[index + 2]) && IsHex(text[index + 3]) && IsHex(text[index + 4]) && IsHex(text[index + 5]) && IsHex(text[index + 6]))
			{
				Color c = ParseColor24(text, index + 1);
				if (colors != null && colors.size > 0)
				{
					c.a = colors.buffer[colors.size - 1].a;
					if (premultiply && c.a != 1f)
					{
						c = Color.Lerp(mInvisible, c, c.a);
					}
					colors.Add(c);
				}
				index += 8;
				return true;
			}
		}
		if (index + 10 > length)
		{
			return false;
		}
		if (text[index + 9] == ']')
		{
			if (IsHex(text[index + 1]) && IsHex(text[index + 2]) && IsHex(text[index + 3]) && IsHex(text[index + 4]) && IsHex(text[index + 5]) && IsHex(text[index + 6]) && IsHex(text[index + 7]) && IsHex(text[index + 8]))
			{
				Color c2 = ParseColor32(text, index + 1);
				if (colors != null)
				{
					if (premultiply && c2.a != 1f)
					{
						c2 = Color.Lerp(mInvisible, c2, c2.a);
					}
					colors.Add(c2);
				}
				index += 10;
				return true;
			}
		}
		return false;
	}

	public static string StripSymbols(string text)
	{
		if (text != null)
		{
			int i = 0;
			int imax = text.Length;
			while (i < imax)
			{
				char c = text[i];
				if (c == '[')
				{
					int sub = 0;
					bool bold = false;
					bool italic = false;
					bool underline = false;
					bool strike = false;
					bool ignoreColor = false;
					int retVal = i;
					if (ParseSymbol(text, ref retVal, null, false, ref sub, ref bold, ref italic, ref underline, ref strike, ref ignoreColor))
					{
						text = text.Remove(i, retVal - i);
						imax = text.Length;
						continue;
					}
				}
				i++;
			}
		}
		return text;
	}

	public static void Align(List<Vector3> verts, int indexOffset, float printedWidth, int elements = 4)
	{
		switch (alignment)
		{
		case Alignment.Right:
		{
			float padding = (float)rectWidth - printedWidth;
			if (padding < 0f)
			{
				return;
			}
			for (int j = indexOffset; j < verts.Count; j++)
			{
				Vector3 v2 = verts[j];
				v2.x += padding;
				verts[j] = v2;
			}
			break;
		}
		case Alignment.Center:
		{
			float padding2 = ((float)rectWidth - printedWidth) * 0.5f;
			if (padding2 < 0f)
			{
				return;
			}
			int diff = Mathf.RoundToInt((float)rectWidth - printedWidth);
			int intWidth = Mathf.RoundToInt(rectWidth);
			bool oddDiff = (diff & 1) == 1;
			bool oddWidth = (intWidth & 1) == 1;
			if ((oddDiff && !oddWidth) || (!oddDiff && oddWidth))
			{
				padding2 += 0.5f * fontScale;
			}
			for (int i = indexOffset; i < verts.Count; i++)
			{
				Vector3 v = verts[i];
				v.x += padding2;
				verts[i] = v;
			}
			break;
		}
		case Alignment.Justified:
		{
			if (printedWidth < (float)rectWidth * 0.65f)
			{
				return;
			}
			float padding3 = ((float)rectWidth - printedWidth) * 0.5f;
			if (padding3 < 1f)
			{
				return;
			}
			int count = (verts.Count - indexOffset) / elements;
			if (count < 2)
			{
				return;
			}
			float progressPerChar = 1f / (float)(count - 1);
			float scale = (float)rectWidth / printedWidth;
			int k = indexOffset + elements;
			int charIndex = 1;
			while (k < verts.Count)
			{
				float x0 = verts[k].x;
				float x1 = verts[k + elements / 2].x;
				float w = x1 - x0;
				float x0a = x0 * scale;
				float x1a = x0a + w;
				float x1b = x1 * scale;
				float x0b = x1b - w;
				float progress = (float)charIndex * progressPerChar;
				x1 = Mathf.Lerp(x1a, x1b, progress);
				x0 = Mathf.Lerp(x0a, x0b, progress);
				x0 = Mathf.Round(x0);
				x1 = Mathf.Round(x1);
				if (elements == 4)
				{
					Vector3 v;
					v = verts[k]; v.x = x0; verts[k++] = v;
					v = verts[k]; v.x = x0; verts[k++] = v;
					v = verts[k]; v.x = x1; verts[k++] = v;
					v = verts[k]; v.x = x1; verts[k++] = v;
				}
				else
				{
					for (int e = 0; e < elements; e++)
					{
						Vector3 v = verts[k];
						v.x = ((e % 4 < 2) ? x0 : x1);
						verts[k++] = v;
					}
				}
				charIndex++;
			}
			break;
		}
		}
	}

	public static int GetExactCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
	{
		for (int i = 0; i < indices.Count; i++)
		{
			int i0 = i << 1;
			int i1 = i0 + 1;
			if (i1 >= verts.Count) break;
			float x0 = verts[i0].x;
			if (pos.x >= x0)
			{
				float x1 = verts[i1].x;
				if (pos.x <= x1)
				{
					float y0 = verts[i0].y;
					if (pos.y >= y0)
					{
						float y1 = verts[i1].y;
						if (pos.y <= y1)
						{
							return indices[i];
						}
					}
				}
			}
		}
		return 0;
	}

	public static int GetApproximateCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
	{
		float bestX = float.MaxValue;
		float bestY = float.MaxValue;
		int bestIndex = 0;
		for (int i = 0; i < verts.Count; i++)
		{
			float diffY = Mathf.Abs(pos.y - verts[i].y);
			if (diffY <= bestY)
			{
				float diffX = Mathf.Abs(pos.x - verts[i].x);
				if (diffY < bestY)
				{
					bestY = diffY;
					bestX = diffX;
					bestIndex = i;
				}
				else if (diffX < bestX)
				{
					bestX = diffX;
					bestIndex = i;
				}
			}
		}
		return (bestIndex < indices.Count) ? indices[bestIndex] : 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool IsSpace(int ch)
	{
		return ch == 32 || ch == 8202 || ch == 8203 || ch == 8201;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static void EndLine(ref StringBuilder s)
	{
		int i = s.Length - 1;
		if (i > 0 && IsSpace(s[i]))
		{
			s[i] = '\n';
		}
		else
		{
			s.Append('\n');
		}
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
		int i = s.Length - 1;
		if (i > 0 && IsSpace(s[i]))
		{
			s[i] = '\n';
		}
	}

	public static Vector2 CalculatePrintedSize(string text)
	{
		Vector2 v = Vector2.zero;
		if (!string.IsNullOrEmpty(text))
		{
			Prepare(text);
			int prev = 0;
			int sub = 0;
			bool bold = false;
			bool italic = false;
			bool underline = false;
			bool strike = false;
			bool ignoreColor = false;
			float x = 0f;
			float y = 0f;
			float maxX = 0f;
			int textLength = text.Length;
			for (int i = 0; i < textLength; i++)
			{
				int ch = text[i];
				if (ch == 10)
				{
					if (x > maxX)
					{
						maxX = x;
					}
					x = 0f;
					y += finalLineHeight;
					prev = 0;
				}
				else if (ch < 32)
				{
					prev = 0;
				}
				else if (encoding && ParseSymbol(text, ref i, mColors, premultiply, ref sub, ref bold, ref italic, ref underline, ref strike, ref ignoreColor))
				{
					i--;
				}
				else
				{
					BMSymbol symbol = (useSymbols ? GetSymbol(text, i, textLength) : null);
					float scale = ((sub == 0) ? fontScale : (fontScale * 0.75f));
					if (symbol != null)
					{
						float w = (float)symbol.advance * scale;
						x += w + finalSpacingX;
						i += symbol.sequence.Length - 1;
						prev = 0;
					}
					else
					{
						GlyphInfo glyphInfo = GetGlyph(ch, prev, scale);
						if (glyphInfo != null)
						{
							prev = ch;
							x += glyphInfo.advance + finalSpacingX;
						}
					}
				}
			}
			if (x > maxX)
			{
				maxX = x;
			}
			if (maxX > 0f)
			{
				maxX -= finalSpacingX;
			}
			v.x = Mathf.Ceil(maxX);
			v.y = Mathf.Ceil(y + finalLineHeight);
		}
		return v;
	}

	public static int CalculateOffsetToFit(string text)
	{
		if (string.IsNullOrEmpty(text) || regionWidth < 1)
		{
			return 0;
		}
		Prepare(text);
		int textLength = text.Length;
		int prev = 0;
		mSizes.Clear();
		for (int i = 0; i < textLength; i++)
		{
			BMSymbol symbol = (useSymbols ? GetSymbol(text, i, textLength) : null);
			if (symbol == null)
			{
				float w = GetGlyphWidth(text[i], prev, fontScale);
				mSizes.Add(w + finalSpacingX);
				prev = text[i];
			}
			else
			{
				mSizes.Add((float)symbol.advance * fontScale + finalSpacingX);
				int j = 0;
				int jmax = symbol.sequence.Length - 1;
				for (; j < jmax; j++)
				{
					mSizes.Add(0f);
				}
				i += symbol.sequence.Length - 1;
				prev = 0;
			}
		}
		float remainingWidth = regionWidth;
		int currentCharacterIndex = mSizes.size;
		while (currentCharacterIndex > 0 && remainingWidth > 0f)
		{
			remainingWidth -= mSizes.buffer[--currentCharacterIndex];
		}
		return currentCharacterIndex;
	}

	public static string GetEndOfLineThatFits(string text)
	{
		int textLength = text.Length;
		int offset = CalculateOffsetToFit(text);
		return text.Substring(offset, textLength - offset);
	}

	public static bool WrapText(string text, out string finalText, bool wrapLineColors = false)
	{
		return WrapText(text, out finalText, false, wrapLineColors, false);
	}

	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis = false)
	{
		if (regionWidth < 1 || regionHeight < 1 || finalLineHeight < 1f)
		{
			finalText = "";
			return false;
		}
		float height = ((maxLines > 0) ? Mathf.Min(regionHeight, finalLineHeight * (float)maxLines) : ((float)regionHeight));
		int maxLineCount = ((maxLines > 0) ? maxLines : 1000000);
		maxLineCount = Mathf.FloorToInt(Mathf.Min(maxLineCount, height / finalLineHeight) + 0.01f);
		if (maxLineCount == 0)
		{
			finalText = "";
			return false;
		}
		if (string.IsNullOrEmpty(text))
		{
			text = " ";
		}
		Prepare(text);
		StringBuilder sb = new StringBuilder();
		int textLength = text.Length;
		float remainingWidth = regionWidth;
		int start = 0;
		int offset = 0;
		int lineCount = 1;
		int prev = 0;
		bool lineIsEmpty = true;
		bool fits = true;
		int sub = 0;
		bool bold = false;
		bool italic = false;
		bool underline = false;
		bool strike = false;
		bool ignoreColor = false;
		mColors.Clear();
		mColors.Add(tint);
		for (; offset < textLength; offset++)
		{
			char ch = text[offset];
			if (ch > '\u2fff')
			{
				start = offset;
			}
			if (ch == '\n')
			{
				if (lineCount == maxLineCount)
				{
					break;
				}
				remainingWidth = regionWidth;
				if (start < offset)
				{
					sb.Append(text.Substring(start, offset - start + 1));
				}
				else
				{
					sb.Append(ch);
				}
				lineIsEmpty = true;
				lineCount++;
				start = offset + 1;
				prev = 0;
				continue;
			}
			if (encoding && ParseSymbol(text, ref offset, mColors, premultiply, ref sub, ref bold, ref italic, ref underline, ref strike, ref ignoreColor))
			{
				offset--;
				continue;
			}
			BMSymbol symbol = (useSymbols ? GetSymbol(text, offset, textLength) : null);
			float scale = ((sub == 0) ? fontScale : (fontScale * 0.75f));
			float glyphWidth;
			if (symbol == null)
			{
				float w = GetGlyphWidth(ch, prev, scale);
				if (w == 0f && !IsSpace(ch))
				{
					continue;
				}
				glyphWidth = finalSpacingX + w;
			}
			else
			{
				glyphWidth = finalSpacingX + (float)symbol.advance * scale;
			}
			remainingWidth -= glyphWidth;
			if (IsSpace(ch) && !lineIsEmpty && start < offset)
			{
				int end = offset - start + 1;
				if (lineCount == maxLineCount && remainingWidth <= 0f && offset < textLength)
				{
					char next = text[offset];
					if (next < ' ' || IsSpace(next))
					{
						end--;
					}
				}
				sb.Append(text.Substring(start, end));
				lineIsEmpty = false;
				start = offset + 1;
			}
			if (Mathf.RoundToInt(remainingWidth) < 0)
			{
				if (lineIsEmpty || lineCount == maxLineCount)
				{
					sb.Append(text.Substring(start, Mathf.Max(0, offset - start)));
					bool space = IsSpace(ch);
					if (!space && ch <= '\u2fff')
					{
						fits = false;
					}
					if (lineCount++ == maxLineCount)
					{
						start = offset;
						break;
					}
					if (keepCharCount)
					{
						ReplaceSpaceWithNewline(ref sb);
					}
					else
					{
						EndLine(ref sb);
					}
					lineIsEmpty = true;
					if (space)
					{
						start = offset + 1;
						remainingWidth = regionWidth;
					}
					else
					{
						start = offset;
						remainingWidth = (float)regionWidth - glyphWidth;
					}
					prev = 0;
				}
				else
				{
					lineIsEmpty = true;
					remainingWidth = regionWidth;
					offset = start - 1;
					prev = 0;
					if (lineCount++ == maxLineCount)
					{
						break;
					}
					if (keepCharCount)
					{
						ReplaceSpaceWithNewline(ref sb);
					}
					else
					{
						EndLine(ref sb);
					}
					continue;
				}
			}
			else
			{
				prev = ch;
			}
			if (symbol != null)
			{
				offset += symbol.length - 1;
				prev = 0;
			}
		}
		if (start < offset)
		{
			sb.Append(text.Substring(start, offset - start));
		}
		finalText = sb.ToString();
		mColors.Clear();
		return fits && (offset == textLength || lineCount <= Mathf.Min(maxLines > 0 ? maxLines : 1000000, maxLineCount));
	}

	public static void Print(string text, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		int indexOffset = verts.Count;
		Prepare(text);
		mColors.Clear();
		mColors.Add(Color.white);
		mAlpha = 1f;
		int prev = 0;
		float x = 0f;
		float y = 0f;
		float maxX = 0f;
		float sizeF = finalSize;
		Color gb = tint * gradientBottom;
		Color gt = tint * gradientTop;
		Color gc = tint;
		int textLength = text.Length;
		Rect uvRect = default(Rect);
		float invX = 0f;
		float invY = 0f;
		float sizePD = sizeF * pixelDensity;
		if (bitmapFont != null)
		{
			uvRect = bitmapFont.uvRect;
			invX = uvRect.width / (float)bitmapFont.texWidth;
			invY = uvRect.height / (float)bitmapFont.texHeight;
		}
		int sub = 0;
		bool bold = false;
		bool italic = false;
		bool underline = false;
		bool strike = false;
		bool ignoreColor = false;
		for (int i = 0; i < textLength; i++)
		{
			int ch = text[i];
			float v0x = x;
			if (ch == 10)
			{
				if (x > maxX)
				{
					maxX = x;
				}
				if (alignment != Alignment.Left)
				{
					Align(verts, indexOffset, x - finalSpacingX);
					indexOffset = verts.Count;
				}
				x = 0f;
				y += finalLineHeight;
				prev = 0;
				continue;
			}
			if (ch < 32)
			{
				prev = ch;
				continue;
			}
			if (encoding && ParseSymbol(text, ref i, mColors, premultiply, ref sub, ref bold, ref italic, ref underline, ref strike, ref ignoreColor))
			{
				Color fc = (ignoreColor ? mColors.buffer[mColors.size - 1] : (tint * mColors.buffer[mColors.size - 1]));
				fc.a *= mAlpha;
				gc = fc;
				int bmax = mColors.size - 2;
				for (int b = 0; b < bmax; b++)
				{
					fc.a *= mColors.buffer[b].a;
				}
				if (premultiply && fc.a != 1f)
				{
					fc = Color.Lerp(mInvisible, fc, fc.a);
				}
				gc = fc;
				i--;
				continue;
			}
			BMSymbol symbol = (useSymbols ? GetSymbol(text, i, textLength) : null);
			float scale = ((sub == 0) ? fontScale : (fontScale * 0.75f));
			if (symbol != null)
			{
				float x0 = x + (float)symbol.offsetX * fontScale;
				float x1 = x0 + (float)symbol.width * fontScale;
				float y1 = 0f - (y + (float)symbol.offsetY * fontScale);
				float y0 = y1 - (float)symbol.height * fontScale;
				Rect uv = symbol.uvRect;
				x += finalSpacingX + (float)symbol.advance * scale;
				i += symbol.length - 1;
				prev = 0;
				verts.Add(new Vector3(x0, y0));
				verts.Add(new Vector3(x0, y1));
				verts.Add(new Vector3(x1, y1));
				verts.Add(new Vector3(x1, y0));
				uvs.Add(new Vector2(uv.xMin, uv.yMin));
				uvs.Add(new Vector2(uv.xMin, uv.yMax));
				uvs.Add(new Vector2(uv.xMax, uv.yMax));
				uvs.Add(new Vector2(uv.xMax, uv.yMin));
				Color cSym = ((symbolStyle == SymbolStyle.Colored) ? gc : Color.white);
				cSym.a = gc.a;
				for (int s = 0; s < 4; s++)
				{
					cols.Add(cSym);
				}
				continue;
			}
			GlyphInfo g = GetGlyph(ch, prev, scale);
			if (g == null)
			{
				continue;
			}
			prev = ch;
			float gx0 = g.v0.x + x;
			float gx1 = g.v1.x + x;
			float gy0 = g.v0.y - y;
			float gy1 = g.v1.y - y;
			if (sub != 0)
			{
				if (sub == 1)
				{
					float f = fontScale * (float)fontSize * 0.4f;
					gy0 -= f;
					gy1 -= f;
				}
				else
				{
					float f2 = fontScale * (float)fontSize * 0.05f;
					gy0 += f2;
					gy1 += f2;
				}
			}
			x += finalSpacingX + g.advance;
			if (IsSpace(ch))
			{
				continue;
			}
			Vector2 u0 = g.u0;
			Vector2 u1 = g.u1;
			Vector2 u2 = g.u2;
			Vector2 u3 = g.u3;
			if (bitmapFont != null)
			{
				u0.x = uvRect.xMin + invX * u0.x;
				u2.x = uvRect.xMin + invX * u2.x;
				u0.y = uvRect.yMax - invY * u0.y;
				u2.y = uvRect.yMax - invY * u2.y;
				u1.x = u0.x;
				u1.y = u2.y;
				u3.x = u2.x;
				u3.y = u0.y;
			}
			Color c0 = gc;
			Color c1 = gc;
			if (gradient)
			{
				float min = sizePD + g.v0.y / fontScale;
				float max = sizePD + g.v1.y / fontScale;
				min /= sizePD;
				max /= sizePD;
				s_c0 = Color.Lerp(gb, gt, min);
				s_c1 = Color.Lerp(gb, gt, max);
				s_c0.a *= mAlpha;
				s_c1.a *= mAlpha;
				c0 = s_c0 * mColors.buffer[mColors.size - 1];
				c1 = s_c1 * mColors.buffer[mColors.size - 1];
			}
			if (!bold)
			{
				uvs.Add(u0);
				uvs.Add(u1);
				uvs.Add(u2);
				uvs.Add(u3);
				cols.Add(c0);
				cols.Add(c1);
				cols.Add(c1);
				cols.Add(c0);
				if (!italic)
				{
					verts.Add(new Vector3(gx0, gy0));
					verts.Add(new Vector3(gx0, gy1));
					verts.Add(new Vector3(gx1, gy1));
					verts.Add(new Vector3(gx1, gy0));
				}
				else
				{
					float slant = (float)fontSize * 0.1f * ((gy1 - gy0) / (float)fontSize);
					verts.Add(new Vector3(gx0 - slant, gy0));
					verts.Add(new Vector3(gx0 + slant, gy1));
					verts.Add(new Vector3(gx1 + slant, gy1));
					verts.Add(new Vector3(gx1 - slant, gy0));
				}
			}
			else
			{
				for (int j = 0; j < 4; j++)
				{
					uvs.Add(u0);
					uvs.Add(u1);
					uvs.Add(u2);
					uvs.Add(u3);
					cols.Add(c0);
					cols.Add(c1);
					cols.Add(c1);
					cols.Add(c0);
					float bx = mBoldOffset[j * 2];
					float by = mBoldOffset[j * 2 + 1];
					float slant2 = (italic ? ((float)fontSize * 0.1f * ((gy1 - gy0) / (float)fontSize)) : 0f);
					verts.Add(new Vector3(gx0 + bx - slant2, gy0 + by));
					verts.Add(new Vector3(gx0 + bx + slant2, gy1 + by));
					verts.Add(new Vector3(gx1 + bx + slant2, gy1 + by));
					verts.Add(new Vector3(gx1 + bx - slant2, gy0 + by));
				}
			}
		}
		if (alignment != Alignment.Left && indexOffset < verts.Count)
		{
			Align(verts, indexOffset, x - finalSpacingX);
		}
		mColors.Clear();
	}

	public static void PrintApproximateCharacterPositions(string text, List<Vector3> verts, List<int> indices)
	{
	}

	public static void PrintExactCharacterPositions(string text, List<Vector3> verts, List<int> indices)
	{
	}

	public static void PrintCaretAndSelection(string text, int start, int end, List<Vector3> caret, List<Vector3> highlight)
	{
	}

	public static bool ReplaceLink(ref string text, ref int index, string type, string prefix = null, string suffix = null)
	{
		return false;
	}

	public static bool InsertHyperlink(ref string text, ref int index, string keyword, string link, string prefix = null, string suffix = null)
	{
		return false;
	}

	public static void ReplaceLinks(ref string text, string prefix = null, string suffix = null)
	{
	}
}
