using System;
using System.Collections.Generic;
using UnityEngine;

public class NGUIAtlas : ScriptableObject, INGUIAtlas
{
	private enum Coordinates
	{
		Pixels = 0,
		TexCoords = 1
	}

	[HideInInspector]
	[SerializeField]
	private Material material;

	[HideInInspector]
	[SerializeField]
	private List<UISpriteData> mSprites;

	[HideInInspector]
	[SerializeField]
	private float mPixelSize;

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mReplacement;

	[NonSerialized]
	private int mPMA;

	[NonSerialized]
	private Dictionary<string, int> mSpriteIndices;

	public Material spriteMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool premultipliedAlpha
	{
		get
		{
			return false;
		}
	}

	public List<UISpriteData> spriteList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Texture texture
	{
		get
		{
			return null;
		}
	}

	public float pixelSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public INGUIAtlas replacement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	public void MarkSpriteListAsChanged()
	{
	}

	public void SortAlphabetically()
	{
	}

	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	public bool References(INGUIAtlas atlas)
	{
		return false;
	}

	public void MarkAsChanged()
	{
	}
}
