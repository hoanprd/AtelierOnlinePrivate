using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIProgressBar : UIWidgetContainer
{
	[DoNotObfuscateNGUI]
	public enum FillDirection
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3
	}

	public delegate void OnDragFinished();

	public static UIProgressBar current;

	public OnDragFinished onDragFinished;

	public Transform thumb;

	[HideInInspector]
	[SerializeField]
	protected UIWidget mBG;

	[HideInInspector]
	[SerializeField]
	protected UIWidget mFG;

	[HideInInspector]
	[SerializeField]
	protected float mValue = 1f;

	[HideInInspector]
	[SerializeField]
	protected FillDirection mFill;

	[NonSerialized]
	protected bool mStarted;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected bool mIsDirty;

	[NonSerialized]
	protected Camera mCam;

	[NonSerialized]
	protected float mOffset;

	public int numberOfSteps;

	public List<EventDelegate> onChange = new List<EventDelegate>();

	public Transform cachedTransform
	{
		get
		{
			if (mTrans == null) mTrans = transform;
			return mTrans;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			if (mCam == null) mCam = NGUITools.FindCameraForLayer(gameObject.layer);
			return mCam;
		}
	}

	public UIWidget foregroundWidget
	{
		get { return mFG; }
		set
		{
			if (mFG != value)
			{
				mFG = value;
				mIsDirty = true;
			}
		}
	}

	public UIWidget backgroundWidget
	{
		get { return mBG; }
		set
		{
			if (mBG != value)
			{
				mBG = value;
				mIsDirty = true;
			}
		}
	}

	public FillDirection fillDirection
	{
		get { return mFill; }
		set
		{
			if (mFill != value)
			{
				mFill = value;
				if (mStarted) ForceUpdate();
			}
		}
	}

	public float value
	{
		get
		{
			if (numberOfSteps > 1)
				return Mathf.Round(mValue * (float)(numberOfSteps - 1)) / (float)(numberOfSteps - 1);
			return mValue;
		}
		set { Set(value); }
	}

	public float alpha
	{
		get
		{
			if (mFG != null) return mFG.alpha;
			if (mBG != null) return mBG.alpha;
			return 1f;
		}
		set
		{
			if (mFG != null)
			{
				mFG.alpha = value;
				if (mFG.GetComponent<Collider>() != null) mFG.GetComponent<Collider>().enabled = mFG.alpha > 0.001f;
				else if (mFG.GetComponent<Collider2D>() != null) mFG.GetComponent<Collider2D>().enabled = mFG.alpha > 0.001f;
			}
			if (mBG != null)
			{
				mBG.alpha = value;
				if (mBG.GetComponent<Collider>() != null) mBG.GetComponent<Collider>().enabled = mBG.alpha > 0.001f;
				else if (mBG.GetComponent<Collider2D>() != null) mBG.GetComponent<Collider2D>().enabled = mBG.alpha > 0.001f;
			}
			if (thumb != null)
			{
				UIWidget th = thumb.GetComponent<UIWidget>();
				if (th != null)
				{
					th.alpha = value;
					if (th.GetComponent<Collider>() != null) th.GetComponent<Collider>().enabled = th.alpha > 0.001f;
					else if (th.GetComponent<Collider2D>() != null) th.GetComponent<Collider2D>().enabled = th.alpha > 0.001f;
				}
			}
		}
	}

	protected bool isHorizontal
	{
		get { return mFill == FillDirection.LeftToRight || mFill == FillDirection.RightToLeft; }
	}

	protected bool isInverted
	{
		get { return mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom; }
	}

	public void Set(float val, bool notify = true)
	{
		val = Mathf.Clamp01(val);
		if (mValue != val)
		{
			float before = value;
			mValue = val;
			if (mStarted && before != value)
			{
				if (notify && NGUITools.GetActive(this) && EventDelegate.IsValid(onChange))
				{
					current = this;
					EventDelegate.Execute(onChange);
					current = null;
				}
				ForceUpdate();
			}
		}
	}

	public void Start()
	{
		if (mStarted) return;
		mStarted = true;
		Upgrade();
		if (Application.isPlaying)
		{
			if (mBG != null) mBG.autoResizeBoxCollider = true;
			OnStart();
			if (current == null && onChange != null)
			{
				current = this;
				EventDelegate.Execute(onChange);
				current = null;
			}
		}
		ForceUpdate();
	}

	protected virtual void Upgrade()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected void Update()
	{
		if (mIsDirty) ForceUpdate();
	}

	protected void OnValidate()
	{
		if (NGUITools.GetActive(this))
		{
			Upgrade();
			mIsDirty = true;
			float val = Mathf.Clamp01(mValue);
			if (mValue != val) mValue = val;
			if (numberOfSteps < 0) numberOfSteps = 0;
			else if (numberOfSteps > 21) numberOfSteps = 21;
			ForceUpdate();
		}
		else
		{
			float val2 = Mathf.Clamp01(mValue);
			if (mValue != val2) mValue = val2;
			if (numberOfSteps < 0) numberOfSteps = 0;
			else if (numberOfSteps > 21) numberOfSteps = 21;
		}
	}

	protected float ScreenToValue(Vector2 screenPos)
	{
		Transform trans = cachedTransform;
		Plane plane = new Plane(trans.rotation * Vector3.back, trans.position);
		Ray ray = cachedCamera.ScreenPointToRay(screenPos);
		float dist;
		if (!plane.Raycast(ray, out dist)) return value;
		return LocalToValue(trans.InverseTransformPoint(ray.GetPoint(dist)));
	}

	protected virtual float LocalToValue(Vector2 localPos)
	{
		if (mFG != null)
		{
			Vector3[] corners = mFG.localCorners;
			Vector3 size = corners[2] - corners[0];
			if (isHorizontal)
			{
				float diff = (localPos.x - corners[0].x) / size.x;
				return isInverted ? (1f - diff) : diff;
			}
			float diff2 = (localPos.y - corners[0].y) / size.y;
			return isInverted ? (1f - diff2) : diff2;
		}
		return value;
	}

	public virtual void ForceUpdate()
	{
		mIsDirty = false;
		bool turnOff = false;
		if (mFG != null)
		{
			UIBasicSprite sprite = mFG as UIBasicSprite;
			if (isHorizontal)
			{
				if (sprite != null && sprite.type == UIBasicSprite.Type.Filled)
				{
					if (sprite.fillDirection == UIBasicSprite.FillDirection.Horizontal || sprite.fillDirection == UIBasicSprite.FillDirection.Vertical)
					{
						sprite.fillDirection = UIBasicSprite.FillDirection.Horizontal;
						sprite.invert = isInverted;
					}
					sprite.fillAmount = value;
				}
				else
				{
					mFG.drawRegion = (isInverted ? new Vector4(1f - value, 0f, 1f, 1f) : new Vector4(0f, 0f, value, 1f));
					mFG.enabled = true;
					turnOff = value < 0.001f;
				}
			}
			else if (sprite != null && sprite.type == UIBasicSprite.Type.Filled)
			{
				if (sprite.fillDirection == UIBasicSprite.FillDirection.Horizontal || sprite.fillDirection == UIBasicSprite.FillDirection.Vertical)
				{
					sprite.fillDirection = UIBasicSprite.FillDirection.Vertical;
					sprite.invert = isInverted;
				}
				sprite.fillAmount = value;
			}
			else
			{
				mFG.drawRegion = (isInverted ? new Vector4(0f, 1f - value, 1f, 1f) : new Vector4(0f, 0f, 1f, value));
				mFG.enabled = true;
				turnOff = value < 0.001f;
			}
		}

		if (thumb != null && (mFG != null || mBG != null))
		{
			Vector3[] corners = ((mFG != null) ? mFG.localCorners : mBG.localCorners);
			Vector4 br = ((mFG != null) ? mFG.border : mBG.border);
			corners[0].x += br.x;
			corners[1].x += br.x;
			corners[2].x -= br.z;
			corners[3].x -= br.z;
			corners[0].y += br.y;
			corners[1].y -= br.w;
			corners[2].y -= br.w;
			corners[3].y += br.y;
			Transform t = ((mFG != null) ? mFG.cachedTransform : mBG.cachedTransform);
			for (int i = 0; i < 4; i++) corners[i] = t.TransformPoint(corners[i]);
			if (isHorizontal)
			{
				Vector3 v0 = Vector3.Lerp(corners[0], corners[1], 0.5f);
				Vector3 v1 = Vector3.Lerp(corners[2], corners[3], 0.5f);
				SetThumbPosition(Vector3.Lerp(v0, v1, isInverted ? (1f - value) : value));
			}
			else
			{
				Vector3 v2 = Vector3.Lerp(corners[0], corners[3], 0.5f);
				Vector3 v3 = Vector3.Lerp(corners[1], corners[2], 0.5f);
				SetThumbPosition(Vector3.Lerp(v2, v3, isInverted ? (1f - value) : value));
			}
		}

		if (turnOff) mFG.enabled = false;
	}

	protected void SetThumbPosition(Vector3 worldPos)
	{
		Transform t = thumb.parent;
		if (t != null)
		{
			worldPos = t.InverseTransformPoint(worldPos);
			worldPos.x = Mathf.Round(worldPos.x);
			worldPos.y = Mathf.Round(worldPos.y);
			worldPos.z = 0f;
			if (Vector3.Distance(thumb.localPosition, worldPos) > 0.001f)
				thumb.localPosition = worldPos;
		}
		else if (Vector3.Distance(thumb.position, worldPos) > 0.00001f)
		{
			thumb.position = worldPos;
		}
	}

	public virtual void OnPan(Vector2 delta)
	{
		if (enabled)
		{
			switch (mFill)
			{
			case FillDirection.LeftToRight:
			{
				float after = Mathf.Clamp01(mValue + delta.x);
				value = after;
				mValue = after;
				break;
			}
			case FillDirection.RightToLeft:
			{
				float after2 = Mathf.Clamp01(mValue - delta.x);
				value = after2;
				mValue = after2;
				break;
			}
			case FillDirection.BottomToTop:
			{
				float after3 = Mathf.Clamp01(mValue + delta.y);
				value = after3;
				mValue = after3;
				break;
			}
			case FillDirection.TopToBottom:
			{
				float after4 = Mathf.Clamp01(mValue - delta.y);
				value = after4;
				mValue = after4;
				break;
			}
			}
		}
	}
}
