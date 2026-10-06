using System;

[Serializable]
public class PopupInfo
{
	[Serializable]
	public class ButtonInfo
	{
		public string ACT;

		public string NA;
	}

	public int TYPE;

	public string CAP;

	public string MSG;

	public ButtonInfo[] BTN;

	public int[] RSN;

	public bool LegendRecipeExists()
	{
		return false;
	}
}
