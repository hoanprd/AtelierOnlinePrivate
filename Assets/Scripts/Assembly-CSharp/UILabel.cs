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
    private string mText;

    [HideInInspector]
    [SerializeField]
    private int mFontSize = 16;

    [HideInInspector]
    [SerializeField]
    private FontStyle mFontStyle = FontStyle.Normal;

    [HideInInspector]
    [SerializeField]
    private NGUIText.Alignment mAlignment = NGUIText.Alignment.Left;

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
            return mFinalFontSize;
        }
    }

    private bool shouldBeProcessed
    {
        get
        {
            return mShouldBeProcessed;
        }
        set
        {
            mShouldBeProcessed = value;
        }
    }

    public override bool isAnchoredHorizontally
    {
        get
        {
            return base.isAnchoredHorizontally;
        }
    }

    public override bool isAnchoredVertically
    {
        get
        {
            return base.isAnchoredVertically;
        }
    }

    public override Material material
    {
        get
        {
            if (mFont != null)
            {
                INGUIFont f = mFont as INGUIFont;
                if (f != null) return f.material;
            }
            return (mTrueTypeFont != null) ? mTrueTypeFont.material : base.material;
        }
        set
        {
            base.material = value;
        }
    }

    public override Texture mainTexture
    {
        get
        {
            if (bitmapFont != null) return bitmapFont.atlas != null ? bitmapFont.atlas.texture : null;
            if (mTrueTypeFont != null)
            {
                Material mat = material;
                if (mat != null) return mat.mainTexture;
            }
            return base.mainTexture;
        }
        set
        {
            base.mainTexture = value;
        }
    }

    [Obsolete]
    public UnityEngine.Object font
    {
        get
        {
            return ambigiousFont;
        }
        set
        {
            ambigiousFont = value;
        }
    }

    public INGUIFont bitmapFont
    {
        get
        {
            return mFont as INGUIFont;
        }
        set
        {
            if (mFont != value)
            {
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
        }
    }

    public Font trueTypeFont
    {
        get
        {
            return mTrueTypeFont;
        }
        set
        {
            if (mTrueTypeFont != value)
            {
                SetActiveFont(null);
                mTrueTypeFont = value;
                mFont = null;
                SetActiveFont(value);
                MarkAsChanged();
            }
        }
    }

    public UnityEngine.Object ambigiousFont
    {
        get
        {
            if (mFont != null) return (UnityEngine.Object)mFont;
            return mTrueTypeFont;
        }
        set
        {
            if (value is Font)
            {
                trueTypeFont = value as Font;
            }
            else if (value is INGUIFont)
            {
                bitmapFont = value as INGUIFont;
            }
        }
    }

    public string text
    {
        get
        {
            return mText;
        }
        set
        {
            if (mText != value)
            {
                mText = value;
                MarkAsChanged();
                shouldBeProcessed = true;
            }
        }
    }

    public int defaultFontSize
    {
        get
        {
            if (bitmapFont != null) return bitmapFont.defaultSize;
            return mFontSize > 0 ? mFontSize : 16;
        }
    }

    public int fontSize
    {
        get
        {
            return mFontSize;
        }
        set
        {
            if (mFontSize != value)
            {
                mFontSize = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public FontStyle fontStyle
    {
        get
        {
            return mFontStyle;
        }
        set
        {
            if (mFontStyle != value)
            {
                mFontStyle = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public NGUIText.Alignment alignment
    {
        get
        {
            return mAlignment;
        }
        set
        {
            if (mAlignment != value)
            {
                mAlignment = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public bool applyGradient
    {
        get
        {
            return mApplyGradient;
        }
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
        get
        {
            return mGradientTop;
        }
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
        get
        {
            return mGradientBottom;
        }
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
        set { if (mSpacingX != value) { mSpacingX = value; MarkAsChanged(); } }
    }

    public int spacingY
    {
        get { return mSpacingY; }
        set { if (mSpacingY != value) { mSpacingY = value; MarkAsChanged(); } }
    }

    public bool useFloatSpacing
    {
        get { return mUseFloatSpacing; }
        set { if (mUseFloatSpacing != value) { mUseFloatSpacing = value; MarkAsChanged(); } }
    }

    public float floatSpacingX
    {
        get { return mFloatSpacingX; }
        set { if (mFloatSpacingX != value) { mFloatSpacingX = value; MarkAsChanged(); } }
    }

    public float floatSpacingY
    {
        get { return mFloatSpacingY; }
        set { if (mFloatSpacingY != value) { mFloatSpacingY = value; MarkAsChanged(); } }
    }

    public float effectiveSpacingY
    {
        get { return mUseFloatSpacing ? mFloatSpacingY : mSpacingY; }
    }

    public float effectiveSpacingX
    {
        get { return mUseFloatSpacing ? mFloatSpacingX : mSpacingX; }
    }

    public bool overflowEllipsis
    {
        get { return mOverflowEllipsis; }
        set { if (mOverflowEllipsis != value) { mOverflowEllipsis = value; MarkAsChanged(); } }
    }

    public int overflowWidth
    {
        get { return mOverflowWidth; }
        set { if (mOverflowWidth != value) { mOverflowWidth = value; MarkAsChanged(); } }
    }

    public int overflowHeight
    {
        get
        {
            return mOverflowHeight;
        }
        set
        {
            if (mOverflowHeight != value)
            {
                mOverflowHeight = value;
                MarkAsChanged();
            }
        }
    }

    private bool keepCrisp
    {
        get
        {
            return keepCrispWhenShrunk != Crispness.Never;
        }
    }

    public bool supportEncoding
    {
        get
        {
            return mEncoding;
        }
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
        get
        {
            return mSymbols;
        }
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
        get
        {
            return mOverflow;
        }
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
        get
        {
            return Mathf.RoundToInt(mLineWidth);
        }
        set
        {
            mLineWidth = value;
        }
    }

    [Obsolete]
    public int lineHeight
    {
        get
        {
            return mFontSize;
        }
        set
        {
            mFontSize = value;
        }
    }

    public bool multiLine
    {
        get
        {
            return mMultiline;
        }
        set
        {
            if (mMultiline != value)
            {
                mMultiline = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public override Vector3[] localCorners
    {
        get
        {
            return base.localCorners;
        }
    }

    public override Vector3[] worldCorners
    {
        get
        {
            return base.worldCorners;
        }
    }

    public override Vector4 drawingDimensions
    {
        get
        {
            return base.drawingDimensions;
        }
    }

    public int maxLineCount
    {
        get
        {
            return mMaxLineCount;
        }
        set
        {
            if (mMaxLineCount != value)
            {
                mMaxLineCount = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public Effect effectStyle
    {
        get
        {
            return mEffectStyle;
        }
        set
        {
            if (mEffectStyle != value)
            {
                mEffectStyle = value;
                MarkAsChanged();
            }
        }
    }

    public Color effectColor
    {
        get
        {
            return mEffectColor;
        }
        set
        {
            if (mEffectColor != value)
            {
                mEffectColor = value;
                MarkAsChanged();
            }
        }
    }

    public Vector2 effectDistance
    {
        get
        {
            return mEffectDistance;
        }
        set
        {
            if (mEffectDistance != value)
            {
                mEffectDistance = value;
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
        get
        {
            return mShrinkToFit;
        }
        set
        {
            if (mShrinkToFit != value)
            {
                mShrinkToFit = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public string processedText
    {
        get
        {
            if (mShouldBeProcessed) ProcessText();
            return mProcessedText;
        }
    }

    public Vector2 printedSize
    {
        get
        {
            return mCalculatedSize;
        }
    }

    public override Vector2 localSize
    {
        get
        {
            return base.localSize;
        }
    }

    private bool isValid
    {
        get
        {
            return ambigiousFont != null;
        }
    }

    public Modifier modifier
    {
        get
        {
            return mModifier;
        }
        set
        {
            if (mModifier != value)
            {
                mModifier = value;
                shouldBeProcessed = true;
                MarkAsChanged();
            }
        }
    }

    public string printedText
    {
        get
        {
            return processedText;
        }
    }

    private bool premultipliedAlphaShader
    {
        get
        {
            return false;
        }
    }

    private bool packedFontShader
    {
        get
        {
            return false;
        }
    }

    protected override void OnInit()
    {
        base.OnInit();
        mList.Add(this);
        SetActiveFont(mTrueTypeFont);
    }

    protected override void OnDisable()
    {
        mList.Remove(this);
        SetActiveFont(null);
        base.OnDisable();
    }

    protected void SetActiveFont(Font fnt)
    {
        if (mActiveTTF != fnt) mActiveTTF = fnt;
    }

    private static void OnFontChanged(Font font)
    {
    }

    public override Vector3[] GetSides(Transform relativeTo)
    {
        return base.GetSides(relativeTo);
    }

    protected override void UpgradeFrom265()
    {
        base.UpgradeFrom265();
    }

    protected override void OnAnchor()
    {
        base.OnAnchor();
    }

    private void ProcessAndRequest()
    {
        shouldBeProcessed = true;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        if (!mList.Contains(this)) mList.Add(this);
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    public override void MarkAsChanged()
    {
        shouldBeProcessed = true;
        base.MarkAsChanged();
    }

    public void ProcessText(bool legacyMode = false, bool full = true)
    {
        mShouldBeProcessed = false;
        mProcessedText = mText;
        if (string.IsNullOrEmpty(mProcessedText)) mProcessedText = "";
        mCalculatedSize = new Vector2(width, height);
    }

    public override void MakePixelPerfect()
    {
        base.MakePixelPerfect();
    }

    public void AssumeNaturalSize()
    {
    }

    [Obsolete]
    public int GetCharacterIndex(Vector3 worldPos)
    {
        return GetCharacterIndexAtPosition(worldPos, false);
    }

    [Obsolete]
    public int GetCharacterIndex(Vector2 localPos)
    {
        return GetCharacterIndexAtPosition(localPos, false);
    }

    public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
    {
        return 0;
    }

    public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
    {
        return 0;
    }

    public string GetWordAtPosition(Vector3 worldPos)
    {
        return null;
    }

    public string GetWordAtPosition(Vector2 localPos)
    {
        return null;
    }

    public string GetWordAtCharacterIndex(int characterIndex)
    {
        return null;
    }

    public string GetUrlAtPosition(Vector3 worldPos)
    {
        return null;
    }

    public string GetUrlAtPosition(Vector2 localPos)
    {
        return null;
    }

    public string GetUrlAtCharacterIndex(int characterIndex)
    {
        return null;
    }

    public int GetCharacterIndex(int currentIndex, KeyCode key)
    {
        return 0;
    }

    public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
    {
    }

    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
    }

    public Vector2 ApplyOffset(List<Vector3> verts, int start)
    {
        return default(Vector2);
    }

    public void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, int start, int end, float x, float y)
    {
    }

    public int CalculateOffsetToFit(string text)
    {
        return 0;
    }

    public void SetCurrentProgress()
    {
    }

    public void SetCurrentPercent()
    {
    }

    public void SetCurrentSelection()
    {
    }

    public bool Wrap(string text, out string final)
    {
        final = text;
        return true;
    }

    public bool Wrap(string text, out string final, int height)
    {
        final = text;
        return true;
    }

    public void UpdateNGUIText()
    {
    }

    private void OnApplicationPause(bool paused)
    {
    }
}