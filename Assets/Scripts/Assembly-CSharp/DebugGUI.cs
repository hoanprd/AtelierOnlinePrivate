using System.Collections.Generic;
using UnityEngine;

public class DebugGUI : MonoBehaviour
{
	private enum Page
	{
		Top = 0,
		Log = 1
	}

	private static readonly int PAGE_MAX;

	private static readonly int GROUP_PAGE_COUNT;

	private static readonly int CONSOLE_HEIGHT;

	private static readonly Rect TAB_HEADER_RECT;

	private static readonly Rect TAB_RECT;

	private static readonly Rect PAGE_RECT;

	private static readonly Rect CATEGORY_CHANGE_RECT;

	private static readonly Rect CONSOLE_RECT;

	private static GUIStyle mLabelStyle;

	private static GUIStyle mConsoleLabelStyle;

	private static GUIStyle mToggleStyle;

	private static GUIStyle mButtonStyle;

	private static GUIStyle mRectStyle;

	private static GUIStyle mVerticalScrollBarStyle;

	private static GUIStyle mHorizontalScrollBarStyle;

	private static Texture2D mRectTexture;

	private bool mIsEnabled;

	private Dictionary<Page, IDebugGUIPage> mPageDic;

	private Page mPage;

	private Vector2 mPageScrollPosition;

	private int mPageGroupIndex;

	public bool IsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private int GroupMax
	{
		get
		{
			return 0;
		}
	}

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void ChangePage(Page page)
	{
	}

	private void PrevGroup()
	{
	}

	private void NextGroup()
	{
	}

	public static void DrawLabel(string text, params GUILayoutOption[] options)
	{
	}

	public static void DrawLabel(string text, Color color, params GUILayoutOption[] options)
	{
	}

	public static void DrawRect(Rect rect, Color color, params GUILayoutOption[] options)
	{
	}

	public static bool Button(string text, params GUILayoutOption[] options)
	{
		return false;
	}

	public static bool Button(string text, Color color, params GUILayoutOption[] options)
	{
		return false;
	}

	public static int SelectionGrid(int selected, string[] texts, params GUILayoutOption[] gridOptions)
	{
		return 0;
	}

	public static bool Toggle(bool flg, string title, params GUILayoutOption[] options)
	{
		return false;
	}

	public static void DrawLine()
	{
	}

	public static void DrawLine(Color color)
	{
	}
}
