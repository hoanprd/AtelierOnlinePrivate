using System;
using System.Collections.Generic;
using UnityEngine;

public class UIAtlas : MonoBehaviour, INGUIAtlas
{
	[Serializable]
	private class Sprite
	{
		public string name = "Unity Bug";

		public Rect outer = new Rect(0f, 0f, 1f, 1f);

		public Rect inner = new Rect(0f, 0f, 1f, 1f);

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding
		{
			get
			{
				return paddingLeft != 0f || paddingRight != 0f || paddingTop != 0f || paddingBottom != 0f;
			}
		}
	}

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
	private List<UISpriteData> mSprites = new List<UISpriteData>();

	[HideInInspector]
	[SerializeField]
	private float mPixelSize = 1f;

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mReplacement;

	[HideInInspector]
	[SerializeField]
	private Coordinates mCoordinates;

	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites = new List<Sprite>();

	[NonSerialized]
	private int mPMA = -1;

	[NonSerialized]
	private Dictionary<string, int> mSpriteIndices = new Dictionary<string, int>();

	public Material spriteMaterial
	{
		get
		{
			INGUIAtlas rep = replacement;
			return (rep != null) ? rep.spriteMaterial : material;
		}
		set
		{
			INGUIAtlas rep = replacement;
			if (rep != null)
			{
				rep.spriteMaterial = value;
			}
			else if (material != value)
			{
				material = value;
				mPMA = -1;
				MarkAsChanged();
			}
		}
	}

	public bool premultipliedAlpha
	{
		get
		{
			INGUIAtlas rep = replacement;
			if (rep != null)
			{
				return rep.premultipliedAlpha;
			}
			if (mPMA == -1)
			{
				Material mat = spriteMaterial;
				mPMA = ((mat != null && mat.shader != null && mat.shader.name.Contains("Premultiplied")) ? 1 : 0);
			}
			return mPMA == 1;
		}
	}

	public List<UISpriteData> spriteList
	{
		get
		{
			INGUIAtlas rep = replacement;
			if (rep != null)
			{
				return rep.spriteList;
			}
			if (mSprites.Count == 0)
			{
				Upgrade();
			}
			return mSprites;
		}
		set
		{
			INGUIAtlas rep = replacement;
			if (rep != null)
			{
				rep.spriteList = value;
			}
			else
			{
				mSprites = value;
				MarkSpriteListAsChanged();
			}
		}
	}

	public Texture texture
	{
		get
		{
			INGUIAtlas rep = replacement;
			if (rep != null)
			{
				return rep.texture;
			}
			return (material != null) ? material.mainTexture : null;
		}
	}

	public float pixelSize
	{
		get
		{
			INGUIAtlas rep = replacement;
			return (rep != null) ? rep.pixelSize : mPixelSize;
		}
		set
		{
			INGUIAtlas rep = replacement;
			if (rep != null)
			{
				rep.pixelSize = value;
			}
			else
			{
				float val = Mathf.Clamp(value, 0.25f, 4f);
				if (mPixelSize != val)
				{
					mPixelSize = val;
					MarkAsChanged();
				}
			}
		}
	}

	public INGUIAtlas replacement
	{
		get
		{
			return mReplacement as INGUIAtlas;
		}
		set
		{
			INGUIAtlas rep = value;
			if (rep == (INGUIAtlas)this)
			{
				rep = null;
			}
			if (mReplacement as INGUIAtlas != rep)
			{
				if (rep != null && rep.replacement == (INGUIAtlas)this)
				{
					rep.replacement = null;
				}
				mReplacement = rep as UnityEngine.Object;
				mPMA = -1;
				MarkAsChanged();
			}
		}
	}

	public UISpriteData GetSprite(string name)
	{
		INGUIAtlas rep = replacement;
		if (rep != null)
		{
			return rep.GetSprite(name);
		}
		if (!string.IsNullOrEmpty(name))
		{
			if (mSprites.Count == 0)
			{
				Upgrade();
			}
			if (mSprites.Count == 0)
			{
				return null;
			}
			if (mSpriteIndices == null || mSpriteIndices.Count != mSprites.Count)
			{
				MarkSpriteListAsChanged();
			}
			int index;
			if (mSpriteIndices.TryGetValue(name, out index))
			{
				if (index > -1 && index < mSprites.Count)
				{
					return mSprites[index];
				}
				MarkSpriteListAsChanged();
				if (mSpriteIndices.TryGetValue(name, out index) && index > -1 && index < mSprites.Count)
				{
					return mSprites[index];
				}
			}
			for (int i = 0; i < mSprites.Count; i++)
			{
				UISpriteData sd = mSprites[i];
				if (!string.IsNullOrEmpty(sd.name) && name == sd.name)
				{
					MarkSpriteListAsChanged();
					return sd;
				}
			}
		}
		return null;
	}

	public void MarkSpriteListAsChanged()
	{
		if (mSpriteIndices == null)
		{
			mSpriteIndices = new Dictionary<string, int>();
		}
		else
		{
			mSpriteIndices.Clear();
		}
		for (int i = 0; i < mSprites.Count; i++)
		{
			if (mSprites[i] != null && !string.IsNullOrEmpty(mSprites[i].name))
			{
				mSpriteIndices[mSprites[i].name] = i;
			}
		}
	}

	public void SortAlphabetically()
	{
		mSprites.Sort((UISpriteData s1, UISpriteData s2) => s1.name.CompareTo(s2.name));
		MarkSpriteListAsChanged();
	}

	public BetterList<string> GetListOfSprites()
	{
		INGUIAtlas rep = replacement;
		if (rep != null)
		{
			return rep.GetListOfSprites();
		}
		if (mSprites.Count == 0)
		{
			Upgrade();
		}
		BetterList<string> list = new BetterList<string>();
		for (int i = 0; i < mSprites.Count; i++)
		{
			UISpriteData s = mSprites[i];
			if (s != null && !string.IsNullOrEmpty(s.name))
			{
				list.Add(s.name);
			}
		}
		return list;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		INGUIAtlas rep = replacement;
		if (rep != null)
		{
			return rep.GetListOfSprites(match);
		}
		if (string.IsNullOrEmpty(match))
		{
			return GetListOfSprites();
		}
		if (mSprites.Count == 0)
		{
			Upgrade();
		}
		BetterList<string> list = new BetterList<string>();
		for (int i = 0; i < mSprites.Count; i++)
		{
			UISpriteData s = mSprites[i];
			if (s != null && !string.IsNullOrEmpty(s.name) && string.Equals(match, s.name, StringComparison.OrdinalIgnoreCase))
			{
				list.Add(s.name);
				return list;
			}
		}
		string[] keywords = match.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < keywords.Length; j++)
		{
			keywords[j] = keywords[j].ToLower();
		}
		for (int k = 0; k < mSprites.Count; k++)
		{
			UISpriteData s2 = mSprites[k];
			if (s2 != null && !string.IsNullOrEmpty(s2.name))
			{
				string tl = s2.name.ToLower();
				int matches = 0;
				for (int l = 0; l < keywords.Length; l++)
				{
					if (tl.Contains(keywords[l]))
					{
						matches++;
					}
				}
				if (matches == keywords.Length)
				{
					list.Add(s2.name);
				}
			}
		}
		return list;
	}

	public bool References(INGUIAtlas atlas)
	{
		if (atlas == null)
		{
			return false;
		}
		if (atlas == (INGUIAtlas)this)
		{
			return true;
		}
		INGUIAtlas rep = replacement;
		return rep != null && rep.References(atlas);
	}

	public void MarkAsChanged()
	{
		UISprite[] list = NGUITools.FindActive<UISprite>();
		for (int i = 0; i < list.Length; i++)
		{
			UISprite sp = list[i];
			if (NGUITools.CheckIfRelated(this, sp.atlas))
			{
				INGUIAtlas atl = sp.atlas;
				sp.atlas = null;
				sp.atlas = atl;
			}
		}
	}

	private bool Upgrade()
	{
		INGUIAtlas rep = replacement;
		if (rep != null)
		{
			UIAtlas ua = rep as UIAtlas;
			if (ua != null)
			{
				return ua.Upgrade();
			}
			return false;
		}
		if (mSprites.Count == 0 && sprites != null && sprites.Count > 0 && material != null)
		{
			Texture mainTex = material.mainTexture;
			int width = ((mainTex != null) ? mainTex.width : 512);
			int height = ((mainTex != null) ? mainTex.height : 512);
			for (int i = 0; i < sprites.Count; i++)
			{
				Sprite entry = sprites[i];
				Rect outer = entry.outer;
				Rect inner = entry.inner;
				if (mCoordinates == Coordinates.TexCoords)
				{
					NGUIMath.ConvertToPixels(outer, width, height, true);
					NGUIMath.ConvertToPixels(inner, width, height, true);
				}
				UISpriteData sd = new UISpriteData();
				sd.name = entry.name;
				sd.x = Mathf.RoundToInt(outer.xMin);
				sd.y = Mathf.RoundToInt(outer.yMin);
				sd.width = Mathf.RoundToInt(outer.width);
				sd.height = Mathf.RoundToInt(outer.height);
				sd.paddingLeft = Mathf.RoundToInt(entry.paddingLeft * outer.width);
				sd.paddingRight = Mathf.RoundToInt(entry.paddingRight * outer.width);
				sd.paddingBottom = Mathf.RoundToInt(entry.paddingBottom * outer.height);
				sd.paddingTop = Mathf.RoundToInt(entry.paddingTop * outer.height);
				sd.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				sd.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				sd.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				sd.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				mSprites.Add(sd);
			}
			sprites.Clear();
			MarkSpriteListAsChanged();
			return true;
		}
		return false;
	}
}
