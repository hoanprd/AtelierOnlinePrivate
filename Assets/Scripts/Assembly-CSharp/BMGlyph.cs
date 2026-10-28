using System;
using System.Collections.Generic;

[Serializable]
public class BMGlyph
{
	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<int> kerning;

	public int GetKerning(int previousChar)
	{
		if (kerning != null && previousChar != 0)
		{
			for (int i = 0; i < kerning.Count; i += 2)
			{
				if (kerning[i] == previousChar)
				{
					return kerning[i + 1];
				}
			}
		}
		return 0;
	}

	public void SetKerning(int previousChar, int amount)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 0; i < kerning.Count; i += 2)
		{
			if (kerning[i] == previousChar)
			{
				kerning[i + 1] = amount;
				return;
			}
		}
		kerning.Add(previousChar);
		kerning.Add(amount);
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
		int x1 = x + width;
		int y1 = y + height;
		if (x < xMin)
		{
			int offset = xMin - x;
			x += offset;
			width -= offset;
			offsetX += offset;
		}
		if (y < yMin)
		{
			int offset2 = yMin - y;
			y += offset2;
			height -= offset2;
			offsetY += offset2;
		}
		if (x1 > xMax)
		{
			width -= x1 - xMax;
		}
		if (y1 > yMax)
		{
			height -= y1 - yMax;
		}
	}
}
