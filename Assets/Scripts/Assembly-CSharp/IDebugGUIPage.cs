using UnityEngine;

internal interface IDebugGUIPage
{
	void OnGUIPage(Rect rect);

	string GetFooterText();
}
