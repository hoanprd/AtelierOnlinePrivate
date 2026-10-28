using UnityEngine;

[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	[DoNotObfuscateNGUI]
	public enum Side
	{
		BottomLeft = 0,
		Left = 1,
		TopLeft = 2,
		Top = 3,
		TopRight = 4,
		Right = 5,
		BottomRight = 6,
		Bottom = 7,
		Center = 8
	}

	public Camera uiCamera;
	public GameObject container;
	public Side side = Side.Center;
	public bool runOnlyOnce = true;
	public Vector2 relativeOffset = Vector2.zero;
	public Vector2 pixelOffset = Vector2.zero;

	[HideInInspector]
	[SerializeField]
	private UIWidget widgetContainer;

	private Transform mTrans;
	private Animation mAnim;
	private Rect mRect = default(Rect);
	private UIRoot mRoot;
	private bool mStarted;

	private void OnEnable()
	{
		mTrans = transform;
		mAnim = GetComponent<Animation>();
		UICamera.onScreenResize += ScreenSizeChanged;
	}

	private void OnDisable()
	{
		UICamera.onScreenResize -= ScreenSizeChanged;
	}

	private void ScreenSizeChanged()
	{
		if (mStarted && runOnlyOnce) Update();
	}

	private void Start()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		mRoot = NGUITools.FindInParents<UIRoot>(gameObject);
		if (uiCamera == null) uiCamera = NGUITools.FindCameraForLayer(gameObject.layer);
		Update();
		mStarted = true;
	}

	private void Update()
	{
		if (mAnim != null && mAnim.enabled && mAnim.isPlaying) return;
		if (mTrans == null) mTrans = transform;

		bool useCamera = false;
		UIWidget wc = ((container == null) ? null : container.GetComponent<UIWidget>());
		UIPanel pc = ((container == null && wc == null) ? null : container.GetComponent<UIPanel>());

		if (wc != null)
		{
			Bounds b = wc.CalculateBounds(mTrans.parent);
			mRect.x = b.min.x;
			mRect.y = b.min.y;
			mRect.width = b.size.x;
			mRect.height = b.size.y;
		}
		else if (pc != null)
		{
			if (pc.clipping == UIPanel.Clipping.None)
			{
				float ratio = ((mRoot != null) ? ((float)mRoot.activeHeight / (float)Screen.height * 0.5f) : 0.5f);
				mRect.xMin = (float)(-Screen.width) * ratio;
				mRect.yMin = (float)(-Screen.height) * ratio;
				mRect.xMax = 0f - mRect.xMin;
				mRect.yMax = 0f - mRect.yMin;
			}
			else
			{
				Vector4 cr = pc.finalClipRegion;
				mRect.x = cr.x - cr.z * 0.5f;
				mRect.y = cr.y - cr.w * 0.5f;
				mRect.width = cr.z;
				mRect.height = cr.w;
			}
		}
		else if (container != null)
		{
			Transform root = mTrans.parent;
			Bounds b2 = ((root != null) ? NGUIMath.CalculateRelativeWidgetBounds(root, container.transform) : NGUIMath.CalculateRelativeWidgetBounds(container.transform));
			mRect.x = b2.min.x;
			mRect.y = b2.min.y;
			mRect.width = b2.size.x;
			mRect.height = b2.size.y;
		}
		else
		{
			if (uiCamera == null) return;
			useCamera = true;
			mRect = uiCamera.pixelRect;
		}

		float cx = (mRect.xMin + mRect.xMax) * 0.5f;
		float cy = (mRect.yMin + mRect.yMax) * 0.5f;
		Vector3 v = new Vector3(cx, cy, 0f);

		if (side != Side.Center)
		{
			if (side == Side.Right || side == Side.TopRight || side == Side.BottomRight) v.x = mRect.xMax;
			else if (side == Side.Top || side == Side.Center || side == Side.Bottom) v.x = cx;
			else v.x = mRect.xMin;

			if (side == Side.Top || side == Side.TopRight || side == Side.TopLeft) v.y = mRect.yMax;
			else if (side == Side.Left || side == Side.Center || side == Side.Right) v.y = cy;
			else v.y = mRect.yMin;
		}

		float width = mRect.width;
		float height = mRect.height;
		v.x += pixelOffset.x + relativeOffset.x * width;
		v.y += pixelOffset.y + relativeOffset.y * height;

		if (useCamera)
		{
			if (uiCamera.orthographic)
			{
				v.x = Mathf.Round(v.x);
				v.y = Mathf.Round(v.y);
			}
			v.z = uiCamera.WorldToScreenPoint(mTrans.position).z;
			v = uiCamera.ScreenToWorldPoint(v);
		}
		else
		{
			v.x = Mathf.Round(v.x);
			v.y = Mathf.Round(v.y);
			if (pc != null) v = pc.cachedTransform.TransformPoint(v);
			else if (container != null)
			{
				Transform t = container.transform.parent;
				if (t != null) v = t.TransformPoint(v);
			}
			v.z = mTrans.position.z;
		}

		if (useCamera && uiCamera.orthographic && mTrans.parent != null)
		{
			v = mTrans.parent.InverseTransformPoint(v);
			v.x = Mathf.RoundToInt(v.x);
			v.y = Mathf.RoundToInt(v.y);
			if (mTrans.localPosition != v) mTrans.localPosition = v;
		}
		else if (mTrans.position != v)
		{
			mTrans.position = v;
		}

		if (runOnlyOnce && Application.isPlaying) enabled = false;
	}
}
