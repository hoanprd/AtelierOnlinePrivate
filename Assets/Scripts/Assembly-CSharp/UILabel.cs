using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Label")]
public class UILabel : UIWidget
{
    [DoNotObfuscateNGUI]
    public enum Effect
    {
        None = 0,
        Shadow = 1,
        Outline = 2,
        Outline8 = 3
    }

    [DoNotObfuscateNGUI]
    public enum Overflow
    {
        ShrinkContent = 0,
        ClampContent = 1,
        ResizeFreely = 2,
        ResizeHeight = 3
    }

    [DoNotObfuscateNGUI]
    public enum Crispness
    {
        Never = 0,
        OnDesktop = 1,
        Always = 2
    }

    [DoNotObfuscateNGUI]
    public enum Modifier
    {
        None = 0,
        ToUppercase = 1,
        ToLowercase = 2,
        Custom = 255
    }

    public delegate string ModifierFunc(string s);

    public Crispness keepCrispWhenShrunk = Crispness.OnDesktop;

    [HideInInspector]
    [SerializeField]
    private Font mTrueTypeFont;

    [HideInInspector]
    [SerializeField]
    private UnityEngine.Object mFont;

    [Multiline]
    [HideInInspector]
    [SerializeField]
    private string mText = "";

    [HideInInspector]
    [SerializeField]
    private int mFontSize = 16;

    [HideInInspector]
    [SerializeField]
    private FontStyle mFontStyle = FontStyle.Normal;

    [HideInInspector]
    [SerializeField]
    private NGUIText.Alignment mAlignment = NGUIText.Alignment.Automatic;

    [HideInInspector]
    [SerializeField]
    private bool mEncoding = true;

    [HideInInspector]
    [SerializeField]
    private int mMaxLineCount = 0;

    [HideInInspector]
    [SerializeField]
    private Effect mEffectStyle = Effect.None;

    [HideInInspector]
    [SerializeField]
    private Color mEffectColor = Color.black;

    [HideInInspector]
    [SerializeField]
    private NGUIText.SymbolStyle mSymbols = NGUIText.SymbolStyle.Normal;

    [HideInInspector]
    [SerializeField]
    private Vector2 mEffectDistance = new Vector2(1f, 1f);

    [HideInInspector]
    [SerializeField]
    private Overflow mOverflow = Overflow.ShrinkContent;

    [HideInInspector]
    [SerializeField]
    private bool mApplyGradient = false;

    [HideInInspector]
    [SerializeField]
    private Color mGradientTop = Color.white;

    [HideInInspector]
    [SerializeField]
    private Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

    [HideInInspector]
    [SerializeField]
    private int mSpacingX = 0;

    [HideInInspector]
    [SerializeField]
    private int mSpacingY = 0;

    [HideInInspector]
    [SerializeField]
    private bool mUseFloatSpacing = false;

    [HideInInspector]
    [SerializeField]
    private float mFloatSpacingX = 0f;

    [HideInInspector]
    [SerializeField]
    private float mFloatSpacingY = 0f;

    [HideInInspector]
    [SerializeField]
    private bool mOverflowEllipsis = false;

    [HideInInspector]
    [SerializeField]
    private int mOverflowWidth = 0;

    [HideInInspector]
    [SerializeField]
    private int mOverflowHeight = 0;

    [HideInInspector]
    [SerializeField]
    private Modifier mModifier = Modifier.None;

    [HideInInspector]
    [SerializeField]
    private bool mShrinkToFit = false;

    [HideInInspector]
    [SerializeField]
    private int mMaxLineWidth = 0;

    [HideInInspector]
    [SerializeField]
    private int mMaxLineHeight = 0;

    [HideInInspector]
    [SerializeField]
    private float mLineWidth = 0f;

    [HideInInspector]
    [SerializeField]
    private bool mMultiline = true;

    [NonSerialized]
    private Font mActiveTTF;

    [NonSerialized]
    private float mDensity = 1f;

    [NonSerialized]
    private bool mShouldBeProcessed = true;

    [NonSerialized]
    private string mProcessedText;

    [NonSerialized]
    private bool mPremultiply;

    [NonSerialized]
    private Vector2 mCalculatedSize = Vector2.zero;

    [NonSerialized]
    private float mScale = 1f;

    [NonSerialized]
    private int mFinalFontSize = 16;

    [NonSerialized]
    private int mLastWidth = 0;

    [NonSerialized]
    private int mLastHeight = 0;

    public ModifierFunc customModifier;

    private static BetterList<UILabel> mList = new BetterList<UILabel>();

    private static Dictionary<Font, int> mFontUsage = new Dictionary<Font, int>();

    [NonSerialized]
    private static BetterList<UIDrawCall> mTempDrawcalls = new BetterList<UIDrawCall>();

    private static bool mTexRebuildAdded = false;

    private static List<Vector3> mTempVerts = new List<Vector3>();

    private static List<int> mTempIndices = new List<int>();

    public int finalFontSize
    {
        get
        {
            if (trueTypeFont != null) return Mathf.RoundToInt(mScale * (float)mFinalFontSize);
            return Mathf.RoundToInt((float)mFinalFontSize * mScale);
        }
    }

    private bool shouldBeProcessed
    {
        get { return mShouldBeProcessed; }
        set
        {
            if (value)
            {
                mChanged = true;
                mShouldBeProcessed = true;
            }
            else
            {
                mShouldBeProcessed = false;
            }
        }
    }

    public override bool isAnchoredHorizontally
    {
        get { return base.isAnchoredHorizontally || mOverflow == Overflow.ResizeFreely; }
    }

    public override bool isAnchoredVertically
    {
        get { return base.isAnchoredVertically || mOverflow == Overflow.ResizeFreely || mOverflow == Overflow.ResizeHeight; }
    }

    public override Material material
    {
        get
        {
            if (mMat != null) return mMat;
            if (mFont != null)
            {
                INGUIFont f = mFont as INGUIFont;
                if (f != null) return f.material;
            }
            if (mTrueTypeFont != null) return mTrueTypeFont.material;
            return null;
        }
        set
        {
            base.material = value;
        }
    }

    public override Shader shader
    {
        get
        {
            if (mMat != null) return mMat.shader;
            if (mFont != null)
            {
                INGUIFont f = mFont as INGUIFont;
                if (f != null && !f.isDynamic)
                {
                    Material fm = f.material;
                    if (fm != null) return fm.shader;
                }
            }
            if (trueTypeFont != null)
            {
                Shader s = Shader.Find("Unlit/Text");
                if (s != null) return s;
            }
            Material mat = material;
            return (mat != null) ? mat.shader : Shader.Find("Unlit/Transparent Colored");
        }
        set
        {
            base.shader = value;
        }
    }

    public override Texture mainTexture
    {
        get
        {
            if (mMat != null) return mMat.mainTexture;
            if (mFont != null)
            {
                INGUIFont f = mFont as INGUIFont;
                if (f != null) return f.texture;
            }
            if (mTrueTypeFont != null)
            {
                Material mat = mTrueTypeFont.material;
                if (mat != null) return mat.mainTexture;
            }
            return null;
        }
        set
        {
            base.mainTexture = value;
        }
    }

    [Obsolete]
    public UnityEngine.Object font
    {
        get { return ambigiousFont; }
        set { ambigiousFont = value; }
    }

    public INGUIFont bitmapFont
    {
        get { return mFont as INGUIFont; }
        set
        {
            if (mFont as INGUIFont != value)
            {
                RemoveFromPanel();
                mFont = value as UnityEngine.Object;
                mTrueTypeFont = null;
                MarkAsChanged();
            }
        }
    }

    public INGUIAtlas atlas
    {
        get
        {
            if (bitmapFont != null) return bitmapFont.atlas;
            return null;
        }
        set
        {
            if (bitmapFont != null) bitmapFont.atlas = value;
        }
    }

    public Font trueTypeFont
    {
        get
        {
            if (mTrueTypeFont != null) return mTrueTypeFont;
            if (mFont != null)
            {
                INGUIFont f = mFont as INGUIFont;
                if (f != null) return f.dynamicFont;
            }
            return null;
        }
        set
        {
            if (mTrueTypeFont != value)
            {
                SetActiveFont(null);
                RemoveFromPanel();
                mTrueTypeFont = value;
                shouldBeProcessed = true;
                mFont = null;
                SetActiveFont(value);
                ProcessAndRequest();
                if (mActiveTTF != null) base.MarkAsChanged();
            }
        }
    }

    public UnityEngine.Object ambigiousFont
    {
        get
        {
            return (mFont != null) ? mFont : (UnityEngine.Object)mTrueTypeFont;
        }
        set
        {
            if (value is Font)
                trueTypeFont = value as Font;
            else
                bitmapFont = value as INGUIFont;
        }
    }

    public string text
    {
        get { return mText; }
        set
        {
            if (mText == value) return;
            if (string.IsNullOrEmpty(value))
            {
                if (!string.IsNullOrEmpty(mText))
                {
                    mText = "";
                    MarkAsChanged();
                    ProcessAndRequest();
                }
            }
            else if (mText != value)
            {
                mText = value;
                MarkAsChanged();
                ProcessAndRequest();
            }
            if (autoResizeBoxCollider) ResizeCollider();
        }
    }

    public int defaultFontSize
    {
        get
        {
            if (trueTypeFont != null) return mFontSize;
            INGUIFont bf = bitmapFont;
            return (bf != null) ? bf.defaultSize : 16;
        }
    }

    public int fontSize
    {
        get { return mFontSize; }
        set
        {
            value = Mathf.Clamp(value, 0, 256);
            if (mFontSize != value)
            {
                mFontSize = value;
                shouldBeProcessed = true;
                ProcessAndRequest();
            }
        }
    }

    public FontStyle fontStyle
    {
        get { return mFontStyle; }
        set
        {
            if (mFontStyle != value)
            {
                mFontStyle = value;
                shouldBeProcessed = true;
                ProcessAndRequest();
            }
        }
    }

    public NGUIText.Alignment alignment
    {
        get { return mAlignment; }
        set
        {
            if (mAlignment != value)
            {
                mAlignment = value;
                shouldBeProcessed = true;
                ProcessAndRequest();
            }
        }
    }

    public bool applyGradient
    {
        get { return mApplyGradient; }
        set
        {
            if (mApplyGradient != value)
            {
                mApplyGradient = value;
                MarkAsChanged();
            }
        }
    }

    public Color gradientTop
    {
        get { return mGradientTop; }
        set
        {
            if (mGradientTop != value)
            {
                mGradientTop = value;
                if (mApplyGradient) MarkAsChanged();
            }
        }
    }

    public Color gradientBottom
    {
        get { return mGradientBottom; }
        set
        {
            if (mGradientBottom != value)
            {
                mGradientBottom = value;
                if (mApplyGradient) MarkAsChanged();
            }
        }
    }

    public int spacingX
    {
        get { return mSpacingX; }
        set { if (mSpacingX != value) { mSpacingX = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public int spacingY
    {
        get { return mSpacingY; }
        set { if (mSpacingY != value) { mSpacingY = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public bool useFloatSpacing
    {
        get { return mUseFloatSpacing; }
        set { if (mUseFloatSpacing != value) { mUseFloatSpacing = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public float floatSpacingX
    {
        get { return mFloatSpacingX; }
        set { if (!Mathf.Approximately(mFloatSpacingX, value)) { mFloatSpacingX = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public float floatSpacingY
    {
        get { return mFloatSpacingY; }
        set { if (!Mathf.Approximately(mFloatSpacingY, value)) { mFloatSpacingY = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public float effectiveSpacingY
    {
        get { return mUseFloatSpacing ? mFloatSpacingY : (float)mSpacingY; }
    }

    public float effectiveSpacingX
    {
        get { return mUseFloatSpacing ? mFloatSpacingX : (float)mSpacingX; }
    }

    public bool overflowEllipsis
    {
        get { return mOverflowEllipsis; }
        set { if (mOverflowEllipsis != value) { mOverflowEllipsis = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public int overflowWidth
    {
        get { return mOverflowWidth; }
        set { if (mOverflowWidth != value) { mOverflowWidth = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    public int overflowHeight
    {
        get { return mOverflowHeight; }
        set { if (mOverflowHeight != value) { mOverflowHeight = value; shouldBeProcessed = true; MarkAsChanged(); } }
    }

    private bool keepCrisp
    {
        get
        {
            if (trueTypeFont != null && keepCrispWhenShrunk != Crispness.Never)
                return true;
            return false;
        }
    }

    public bool supportEncoding
    {
        get { return mEncoding; }
        set
        {
            if (mEncoding != value)
            {
                mEncoding = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public NGUIText.SymbolStyle symbolStyle
    {
        get { return mSymbols; }
        set
        {
            if (mSymbols != value)
            {
                mSymbols = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public Overflow overflowMethod
    {
        get { return mOverflow; }
        set
        {
            if (mOverflow != value)
            {
                mOverflow = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    [Obsolete]
    public int lineWidth
    {
        get { return width; }
        set { width = value; }
    }

    [Obsolete]
    public int lineHeight
    {
        get { return height; }
        set { height = value; }
    }

    public bool multiLine
    {
        get { return mMaxLineCount != 1; }
        set
        {
            if ((mMaxLineCount != 1) != value)
            {
                mMaxLineCount = (value ? 0 : 1);
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public override Vector3[] localCorners
    {
        get
        {
            if (shouldBeProcessed) ProcessText();
            return base.localCorners;
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
            if (shouldBeProcessed) ProcessText();
            return base.worldCorners;
        }
    }

    public override Vector4 drawingDimensions
    {
        get
        {
            if (shouldBeProcessed) ProcessText();
            return base.drawingDimensions;
        }
    }

    public int maxLineCount
    {
        get { return mMaxLineCount; }
        set
        {
            if (mMaxLineCount != value)
            {
                mMaxLineCount = Mathf.Max(value, 0);
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public Effect effectStyle
    {
        get { return mEffectStyle; }
        set
        {
            if (mEffectStyle != value)
            {
                mEffectStyle = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public Color effectColor
    {
        get { return mEffectColor; }
        set
        {
            if (mEffectColor != value)
            {
                mEffectColor = value;
                if (mEffectStyle != Effect.None) MarkAsChanged();
            }
        }
    }

    public Vector2 effectDistance
    {
        get { return mEffectDistance; }
        set
        {
            if (mEffectDistance != value)
            {
                mEffectDistance = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public int quadsPerCharacter
    {
        get
        {
            return (mEffectStyle == Effect.Shadow) ? 2 : ((mEffectStyle == Effect.Outline) ? 5 : ((mEffectStyle == Effect.Outline8) ? 9 : 1));
        }
    }

    [Obsolete]
    public bool shrinkToFit
    {
        get { return mOverflow == Overflow.ShrinkContent; }
        set { if (value) overflowMethod = Overflow.ShrinkContent; }
    }

    public string processedText
    {
        get
        {
            if (mLastWidth != mWidth || mLastHeight != mHeight)
            {
                mLastWidth = mWidth;
                mLastHeight = mHeight;
                mShouldBeProcessed = true;
            }
            if (shouldBeProcessed) ProcessText();
            return mProcessedText;
        }
    }

    public Vector2 printedSize
    {
        get
        {
            if (shouldBeProcessed) ProcessText();
            return mCalculatedSize;
        }
    }

    public override Vector2 localSize
    {
        get
        {
            if (shouldBeProcessed) ProcessText();
            return base.localSize;
        }
    }

    private bool isValid
    {
        get { return mFont != null || mTrueTypeFont != null; }
    }

    public Modifier modifier
    {
        get { return mModifier; }
        set
        {
            if (mModifier != value)
            {
                mModifier = value;
                MarkAsChanged();
                ProcessAndRequest();
            }
        }
    }

    public string printedText
    {
        get
        {
            if (!string.IsNullOrEmpty(mText))
            {
                if (mModifier == Modifier.None) return mText;
                if (mModifier == Modifier.ToLowercase) return mText.ToLower();
                if (mModifier == Modifier.ToUppercase) return mText.ToUpper();
                if (mModifier == Modifier.Custom && customModifier != null) return customModifier(mText);
            }
            return mText;
        }
    }

    private bool premultipliedAlphaShader
    {
        get
        {
            INGUIFont bf = bitmapFont;
            return bf != null && bf.premultipliedAlphaShader;
        }
    }

    private bool packedFontShader
    {
        get
        {
            INGUIFont bf = bitmapFont;
            return bf != null && bf.packedFontShader;
        }
    }

    protected override void OnInit()
    {
        base.OnInit();
        mList.Add(this);
        SetActiveFont(trueTypeFont);
    }

    protected override void OnDisable()
    {
        SetActiveFont(null);
        mList.Remove(this);
        base.OnDisable();
    }

    protected void SetActiveFont(Font fnt)
    {
        if (mActiveTTF != fnt)
        {
            Font font = mActiveTTF;
            if (font != null && mFontUsage.ContainsKey(font))
            {
                int count = --mFontUsage[font];
                if (count <= 0) mFontUsage.Remove(font);
            }
            mActiveTTF = fnt;
            if (fnt != null)
            {
                if (!mTexRebuildAdded)
                {
                    mTexRebuildAdded = true;
                    Font.textureRebuilt += OnFontChanged;
                }
                int usage = 0;
                mFontUsage.TryGetValue(fnt, out usage);
                mFontUsage[fnt] = usage + 1;
            }
        }
    }

    private static void OnFontChanged(Font font)
    {
        for (int i = 0; i < mList.size; i++)
        {
            UILabel lbl = mList.buffer[i];
            if (lbl != null)
            {
                Font fnt = lbl.trueTypeFont;
                if (fnt == font)
                {
                    fnt.RequestCharactersInTexture(lbl.mProcessedText, lbl.mFinalFontSize, lbl.mFontStyle);
                    lbl.MarkAsChanged();
                    if (lbl.panel == null) lbl.CreatePanel();
                    if (mTempDrawcalls == null) mTempDrawcalls = new BetterList<UIDrawCall>();
                    if (lbl.drawCall != null && !mTempDrawcalls.Contains(lbl.drawCall))
                        mTempDrawcalls.Add(lbl.drawCall);
                }
            }
        }
        if (mTempDrawcalls != null)
        {
            for (int j = 0; j < mTempDrawcalls.size; j++)
            {
                UIDrawCall dc = mTempDrawcalls.buffer[j];
                if (dc != null && dc.panel != null)
                    dc.panel.FillDrawCall(dc);
            }
            mTempDrawcalls.Clear();
        }
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        if (shouldBeProcessed) ProcessText();
        return base.GetSides(relativeTo);
    }

    protected override void UpgradeFrom265()
    {
        ProcessText(true, true);
        if (mShrinkToFit)
        {
            overflowMethod = Overflow.ShrinkContent;
            mMaxLineCount = 0;
        }
        if (mMaxLineWidth != 0)
        {
            width = mMaxLineWidth;
            overflowMethod = ((mMaxLineCount > 0) ? Overflow.ResizeHeight : Overflow.ShrinkContent);
        }
        else
        {
            overflowMethod = Overflow.ResizeFreely;
        }
        if (mMaxLineHeight != 0)
            height = mMaxLineHeight;
        if (mFont != null)
        {
            int min = defaultFontSize;
            if (height < min) height = min;
            fontSize = min;
        }
        mMaxLineWidth = 0;
        mMaxLineHeight = 0;
        mShrinkToFit = false;
        NGUITools.UpdateWidgetCollider(gameObject, true);
    }

    protected override void OnAnchor()
    {
        if (mOverflow == Overflow.ResizeFreely)
        {
            if (isFullyAnchored)
                mOverflow = Overflow.ShrinkContent;
        }
        else if (mOverflow == Overflow.ResizeHeight && topAnchor.target != null && bottomAnchor.target != null)
        {
            mOverflow = Overflow.ShrinkContent;
        }
        base.OnAnchor();
    }

    private void ProcessAndRequest()
    {
        if (ambigiousFont != null) ProcessText();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        if (!mTexRebuildAdded)
        {
            mTexRebuildAdded = true;
            Font.textureRebuilt += OnFontChanged;
        }
    }

    protected override void OnStart()
    {
        base.OnStart();
        if (mLineWidth > 0f)
        {
            mMaxLineWidth = Mathf.RoundToInt(mLineWidth);
            mLineWidth = 0f;
        }
        if (!mMultiline)
        {
            mMaxLineCount = 1;
            mMultiline = true;
        }
        mPremultiply = (material != null && material.shader != null && material.shader.name.Contains("Premultiplied"));
        ProcessAndRequest();
    }

    public override void MarkAsChanged()
    {
        shouldBeProcessed = true;
        base.MarkAsChanged();
    }

    public void ProcessText(bool legacyMode = false, bool full = true)
    {
        if (!isValid) return;

        mChanged = true;
        shouldBeProcessed = false;

        float regionX = mDrawRegion.z - mDrawRegion.x;
        float regionY = mDrawRegion.w - mDrawRegion.y;

        NGUIText.rectWidth = legacyMode ? ((mMaxLineWidth != 0) ? mMaxLineWidth : 1000000) : width;
        NGUIText.rectHeight = legacyMode ? ((mMaxLineHeight != 0) ? mMaxLineHeight : 1000000) : height;
        NGUIText.regionWidth = Mathf.RoundToInt((float)NGUIText.rectWidth * ((regionX != 0f) ? regionX : 1f));
        NGUIText.regionHeight = Mathf.RoundToInt((float)NGUIText.rectHeight * ((regionY != 0f) ? regionY : 1f));

        mFinalFontSize = Mathf.Abs(legacyMode ? Mathf.RoundToInt(cachedTransform.localScale.x) : defaultFontSize);
        mScale = 1f;

        if (NGUIText.regionWidth < 1 || NGUIText.regionHeight < 0)
        {
            mProcessedText = "";
            return;
        }

        bool isDynamic = (trueTypeFont != null);
        if (isDynamic && keepCrisp)
        {
            UIRoot rt = root;
            if (rt != null) mDensity = ((rt != null) ? rt.pixelSizeAdjustment : 1f);
        }
        else mDensity = 1f;

        if (full) UpdateNGUIText();

        if (mOverflow == Overflow.ResizeFreely)
        {
            NGUIText.rectWidth = 1000000;
            NGUIText.regionWidth = 1000000;
            if (mOverflowWidth > 0)
            {
                NGUIText.rectWidth = Mathf.Min(NGUIText.rectWidth, mOverflowWidth);
                NGUIText.regionWidth = Mathf.Min(NGUIText.regionWidth, mOverflowWidth);
            }
        }

        if (mOverflow == Overflow.ResizeFreely || mOverflow == Overflow.ResizeHeight)
        {
            NGUIText.rectHeight = 1000000;
            NGUIText.regionHeight = 1000000;
        }

        if (mFinalFontSize > 0)
        {
            bool adjustSize = keepCrisp;
            for (int ps = mFinalFontSize; ps > 0; --ps)
            {
                if (adjustSize)
                {
                    mFinalFontSize = ps;
                    NGUIText.fontSize = mFinalFontSize;
                }
                else
                {
                    mScale = (float)ps / (float)mFinalFontSize;
                    NGUIText.fontScale = isDynamic ? mScale : (((float)mFontSize / (float)defaultFontSize) * mScale);
                }

                NGUIText.Update(false);

                bool fits = NGUIText.WrapText(printedText, out mProcessedText, false, false, mOverflow == Overflow.ClampContent && mOverflowEllipsis);

                if (mOverflow == Overflow.ShrinkContent && !fits)
                {
                    if (--ps > 1) continue;
                    else break;
                }
                else if (mOverflow == Overflow.ResizeFreely)
                {
                    mCalculatedSize = NGUIText.CalculatePrintedSize(mProcessedText);
                    int w = Mathf.Max(minWidth, Mathf.RoundToInt(mCalculatedSize.x));
                    if (regionX != 1f) w = Mathf.RoundToInt((float)w / regionX);
                    int h = Mathf.Max(minHeight, Mathf.RoundToInt(mCalculatedSize.y));
                    if (regionY != 1f) h = Mathf.RoundToInt((float)h / regionY);
                    if ((w & 1) == 1) ++w;
                    if ((h & 1) == 1) ++h;
                    if (mWidth != w || mHeight != h)
                    {
                        mWidth = w;
                        mHeight = h;
                        if (onChange != null) onChange();
                    }
                }
                else if (mOverflow == Overflow.ResizeHeight)
                {
                    mCalculatedSize = NGUIText.CalculatePrintedSize(mProcessedText);
                    int h = Mathf.Max(minHeight, Mathf.RoundToInt(mCalculatedSize.y));
                    if (regionY != 1f) h = Mathf.RoundToInt((float)h / regionY);
                    if (mOverflowHeight > 0 && h < mOverflowHeight) h = mOverflowHeight;
                    if ((h & 1) == 1) ++h;
                    if (mHeight != h)
                    {
                        mHeight = h;
                        if (onChange != null) onChange();
                    }
                }
                else
                {
                    mCalculatedSize = NGUIText.CalculatePrintedSize(mProcessedText);
                }

                if (legacyMode)
                {
                    width = Mathf.RoundToInt(mCalculatedSize.x);
                    height = Mathf.RoundToInt(mCalculatedSize.y);
                    cachedTransform.localScale = Vector3.one;
                }
                break;
            }
        }
        else
        {
            cachedTransform.localScale = Vector3.one;
            mProcessedText = "";
            mScale = 1f;
        }

        if (full)
        {
            NGUIText.bitmapFont = null;
            NGUIText.dynamicFont = null;
        }
    }

    public override void MakePixelPerfect()
    {
        if (ambigiousFont != null)
        {
            Vector3 pos = cachedTransform.localPosition;
            pos.x = Mathf.RoundToInt(pos.x);
            pos.y = Mathf.RoundToInt(pos.y);
            pos.z = Mathf.RoundToInt(pos.z);
            cachedTransform.localPosition = pos;
            cachedTransform.localScale = Vector3.one;
            if (mOverflow == Overflow.ResizeFreely)
            {
                AssumeNaturalSize();
            }
            else
            {
                int w = width;
                int h = height;
                Overflow over = mOverflow;
                if (over != Overflow.ResizeHeight) mWidth = 100000;
                mHeight = 100000;
                mOverflow = Overflow.ShrinkContent;
                ProcessText(false, true);
                mOverflow = over;
                int minX = Mathf.RoundToInt(mCalculatedSize.x);
                int minY = Mathf.RoundToInt(mCalculatedSize.y);
                minX = Mathf.Max(minX, base.minWidth);
                minY = Mathf.Max(minY, base.minHeight);
                if ((minX & 1) == 1) ++minX;
                if ((minY & 1) == 1) ++minY;
                mWidth = Mathf.Max(w, minX);
                mHeight = Mathf.Max(h, minY);
                MarkAsChanged();
            }
        }
        else base.MakePixelPerfect();
    }

    public void AssumeNaturalSize()
    {
        if (ambigiousFont != null)
        {
            mWidth = 100000;
            mHeight = 100000;
            ProcessText(false, true);
            mWidth = Mathf.RoundToInt(mCalculatedSize.x);
            mHeight = Mathf.RoundToInt(mCalculatedSize.y);
            if ((mWidth & 1) == 1) ++mWidth;
            if ((mHeight & 1) == 1) ++mHeight;
            MarkAsChanged();
        }
    }

    [Obsolete]
    public int GetCharacterIndex(Vector3 worldPos) { return GetCharacterIndexAtPosition(worldPos, false); }
    [Obsolete]
    public int GetCharacterIndex(Vector2 localPos) { return GetCharacterIndexAtPosition(localPos, false); }
    public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise) { return 0; }
    public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise) { return 0; }
    public string GetWordAtPosition(Vector3 worldPos) { return null; }
    public string GetWordAtPosition(Vector2 localPos) { return null; }
    public string GetWordAtCharacterIndex(int characterIndex) { return null; }
    public string GetUrlAtPosition(Vector3 worldPos) { return null; }
    public string GetUrlAtPosition(Vector2 localPos) { return null; }
    public string GetUrlAtCharacterIndex(int characterIndex) { return null; }
    public int GetCharacterIndex(int currentIndex, KeyCode key) { return currentIndex; }
    public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor) { }

    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        if (!isValid) return;

        int offset = verts.Count;
        Color col = color;
        col.a = finalAlpha;
        if (mFont != null && (mFont as INGUIFont) != null && (mFont as INGUIFont).premultipliedAlphaShader)
            col = NGUITools.ApplyPMA(col);

        string text = processedText;
        int start = verts.Count;

        UpdateNGUIText();
        NGUIText.tint = col;
        NGUIText.Print(text, verts, uvs, cols);
        NGUIText.bitmapFont = null;
        NGUIText.dynamicFont = null;

        Vector2 pos = ApplyOffset(verts, start);

        if (mFont != null && (mFont as INGUIFont) != null && (mFont as INGUIFont).packedFontShader)
            return;

        if (effectStyle != Effect.None)
        {
            int end = verts.Count;
            pos.x = mEffectDistance.x;
            pos.y = mEffectDistance.y;

            ApplyShadow(verts, uvs, cols, offset, end, pos.x, -pos.y);

            if ((effectStyle == Effect.Outline) || (effectStyle == Effect.Outline8))
            {
                offset = end;
                end = verts.Count;
                ApplyShadow(verts, uvs, cols, offset, end, -pos.x, pos.y);

                offset = end;
                end = verts.Count;
                ApplyShadow(verts, uvs, cols, offset, end, pos.x, pos.y);

                offset = end;
                end = verts.Count;
                ApplyShadow(verts, uvs, cols, offset, end, -pos.x, -pos.y);

                if (effectStyle == Effect.Outline8)
                {
                    offset = end;
                    end = verts.Count;
                    ApplyShadow(verts, uvs, cols, offset, end, -pos.x, 0f);

                    offset = end;
                    end = verts.Count;
                    ApplyShadow(verts, uvs, cols, offset, end, pos.x, 0f);

                    offset = end;
                    end = verts.Count;
                    ApplyShadow(verts, uvs, cols, offset, end, 0f, pos.y);

                    offset = end;
                    end = verts.Count;
                    ApplyShadow(verts, uvs, cols, offset, end, 0f, -pos.y);
                }
            }
        }

        if (onPostFill != null)
            onPostFill(this, offset, verts, uvs, cols);
    }

    public Vector2 ApplyOffset(List<Vector3> verts, int start)
    {
        Vector2 po = pivotOffset;
        float fx = Mathf.Lerp(0f, -mWidth, po.x);
        float fy = Mathf.Lerp(mHeight, 0f, po.y) + Mathf.Lerp((mCalculatedSize.y - (float)mHeight), 0f, po.y);
        fx = Mathf.Round(fx);
        fy = Mathf.Round(fy);
        Vector3 v;
        for (int i = start, imax = verts.Count; i < imax; ++i)
        {
            v = verts[i];
            v.x += fx;
            v.y += fy;
            verts[i] = v;
        }
        return new Vector2(fx, fy);
    }

    public void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, int start, int end, float x, float y)
    {
        Color c = mEffectColor;
        c.a *= finalAlpha;
        if (bitmapFont != null && bitmapFont.premultipliedAlphaShader)
            c = NGUITools.ApplyPMA(c);

        Color col = c;
        for (int i = start; i < end; ++i)
        {
            verts.Add(verts[i]);
            uvs.Add(uvs[i]);
            cols.Add(cols[i]);

            Vector3 v = verts[i];
            v.x += x;
            v.y += y;
            verts[i] = v;

            Color uc = cols[i];
            if (uc.a == 1f)
            {
                cols[i] = col;
            }
            else
            {
                Color fc = c;
                fc.a = uc.a * c.a;
                cols[i] = fc;
            }
        }
    }

    public int CalculateOffsetToFit(string text)
    {
        UpdateNGUIText();
        NGUIText.encoding = false;
        NGUIText.symbolStyle = NGUIText.SymbolStyle.None;
        int offset = NGUIText.CalculateOffsetToFit(text);
        NGUIText.bitmapFont = null;
        NGUIText.dynamicFont = null;
        return offset;
    }

    public void SetCurrentProgress()
    {
        if (UIProgressBar.current != null)
            text = UIProgressBar.current.value.ToString("F");
    }

    public void SetCurrentPercent()
    {
        if (UIProgressBar.current != null)
            text = Mathf.RoundToInt(UIProgressBar.current.value * 100f) + "%";
    }

    public void SetCurrentSelection()
    {
    }

    public bool Wrap(string text, out string final)
    {
        return Wrap(text, out final, 1000000);
    }

    public bool Wrap(string text, out string final, int height)
    {
        UpdateNGUIText();
        NGUIText.rectHeight = height;
        NGUIText.regionHeight = height;
        bool ret = NGUIText.WrapText(text, out final, false);
        NGUIText.bitmapFont = null;
        NGUIText.dynamicFont = null;
        return ret;
    }

    public void UpdateNGUIText()
    {
        Font ttf = trueTypeFont;
        bool isDynamic = (ttf != null);

        NGUIText.fontSize = mFinalFontSize;
        NGUIText.fontStyle = mFontStyle;
        NGUIText.rectWidth = mWidth;
        NGUIText.rectHeight = mHeight;
        NGUIText.regionWidth = Mathf.RoundToInt((float)mWidth * (mDrawRegion.z - mDrawRegion.x));
        NGUIText.regionHeight = Mathf.RoundToInt((float)mHeight * (mDrawRegion.w - mDrawRegion.y));
        NGUIText.gradient = mApplyGradient && (mFont == null || !(mFont as INGUIFont).packedFontShader);
        NGUIText.gradientTop = mGradientTop;
        NGUIText.gradientBottom = mGradientBottom;
        NGUIText.encoding = mEncoding;
        NGUIText.premultiply = mPremultiply;
        NGUIText.symbolStyle = mSymbols;
        NGUIText.maxLines = mMaxLineCount;
        NGUIText.spacingX = effectiveSpacingX;
        NGUIText.spacingY = effectiveSpacingY;

        INGUIFont bf = bitmapFont;
        NGUIText.fontScale = isDynamic ? mScale : ((bf != null && bf.defaultSize > 0) ? (((float)mFontSize / (float)bf.defaultSize) * mScale) : mScale);

        if (bf != null)
        {
            NGUIText.bitmapFont = bf.finalFont;
            if (NGUIText.bitmapFont.isDynamic)
            {
                NGUIText.dynamicFont = NGUIText.bitmapFont.dynamicFont;
                NGUIText.bitmapFont = null;
            }
            else NGUIText.dynamicFont = null;
        }
        else
        {
            NGUIText.dynamicFont = ttf;
            NGUIText.bitmapFont = null;
        }

        if (isDynamic && keepCrisp)
        {
            UIRoot rt = root;
            if (rt != null) NGUIText.pixelDensity = ((rt != null) ? rt.pixelSizeAdjustment : 1f);
        }
        else NGUIText.pixelDensity = 1f;

        if (mDensity != NGUIText.pixelDensity)
        {
            ProcessText(false, false);
            NGUIText.rectWidth = mWidth;
            NGUIText.rectHeight = mHeight;
            NGUIText.regionWidth = Mathf.RoundToInt((float)mWidth * (mDrawRegion.z - mDrawRegion.x));
            NGUIText.regionHeight = Mathf.RoundToInt((float)mHeight * (mDrawRegion.w - mDrawRegion.y));
        }

        if (alignment == NGUIText.Alignment.Automatic)
        {
            Pivot p = pivot;
            if (p == Pivot.Left || p == Pivot.TopLeft || p == Pivot.BottomLeft)
                NGUIText.alignment = NGUIText.Alignment.Left;
            else if (p == Pivot.Right || p == Pivot.TopRight || p == Pivot.BottomRight)
                NGUIText.alignment = NGUIText.Alignment.Right;
            else
                NGUIText.alignment = NGUIText.Alignment.Center;
        }
        else NGUIText.alignment = alignment;

        NGUIText.Update();
    }

    private void OnApplicationPause(bool paused)
    {
        if (!paused && mTrueTypeFont != null) Invalidate(false);
    }
}
