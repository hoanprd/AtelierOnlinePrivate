using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UISpriteCollection : UIBasicSprite
{
	public struct Sprite
	{
		public UISpriteData sprite;

		public Vector2 pos;

		public float rot;

		public float width;

		public float height;

		public Color32 color;

		public Vector2 pivot;

		public Type type;

		public Flip flip;

		public bool enabled;

		public Vector4 GetDrawingDimensions(float pixelSize)
		{
			return default(Vector4);
		}
	}

	public delegate void OnHoverCB(object obj, bool isOver);

	public delegate void OnPressCB(object obj, bool isPressed);

	public delegate void OnClickCB(object obj);

	public delegate void OnDragCB(object obj, Vector2 delta);

	public delegate void OnTooltipCB(object obj, bool show);

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mAtlas;

	[NonSerialized]
	private Dictionary<object, Sprite> mSprites;

	[NonSerialized]
	private UISpriteData mSprite;

	public OnHoverCB onHover;

	public OnPressCB onPress;

	public OnClickCB onClick;

	public OnDragCB onDrag;

	public OnTooltipCB onTooltip;

	[NonSerialized]
	private object mLastHover;

	[NonSerialized]
	private object mLastPress;

	[NonSerialized]
	private object mLastTooltip;

	public override Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public INGUIAtlas atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override float pixelSize
	{
		get
		{
			return 0f;
		}
	}

	public override bool premultipliedAlpha
	{
		get
		{
			return false;
		}
	}

	public override Vector4 border
	{
		get
		{
			return default(Vector4);
		}
	}

	protected override Vector4 padding
	{
		get
		{
			return default(Vector4);
		}
	}

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
	}

	public void Add(object obj, string spriteName, Vector2 pos, float width, float height)
	{
	}

	public void Add(object obj, string spriteName, Vector2 pos, float width, float height, Color32 color)
	{
	}

	public void AddSprite(object id, string spriteName, Vector2 pos, float width, float height, Color32 color, Vector2 pivot, float rot = 0f, Type type = Type.Simple, Flip flip = Flip.Nothing, bool enabled = true)
	{
	}

	public Sprite? GetSprite(object id)
	{
		return null;
	}

	public bool RemoveSprite(object id)
	{
		return false;
	}

	public bool SetSprite(object id, Sprite sp)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool IsActive(object id)
	{
		return false;
	}

	public bool SetActive(object id, bool visible)
	{
		return false;
	}

	public bool SetPosition(object id, Vector2 pos, bool visible = true)
	{
		return false;
	}

	private static Vector2 Rotate(Vector2 pos, float rot)
	{
		return default(Vector2);
	}

	public object GetCurrentSpriteID()
	{
		return null;
	}

	public Sprite? GetCurrentSprite()
	{
		return null;
	}

	public object GetCurrentSpriteID(Vector3 worldPos)
	{
		return null;
	}

	public Sprite? GetCurrentSprite(Vector3 worldPos)
	{
		return null;
	}

	protected void OnClick()
	{
	}

	protected void OnPress(bool isPressed)
	{
	}

	protected void OnHover(bool isOver)
	{
	}

	protected void OnMove(Vector2 delta)
	{
	}

	protected void OnDrag(Vector2 delta)
	{
	}

	protected void OnTooltip(bool show)
	{
	}
}
