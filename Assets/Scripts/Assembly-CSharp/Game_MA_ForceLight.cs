using UnityEngine;

public class Game_MA_ForceLight : MonoBehaviour
{
	public enum eLightKind
	{
		Default = 0,
		Day = 1,
		Sunset = 2,
		Night = 3,
		Cave = 4,
		Yousei = 5,
		EnumMax = 6
	}

	public eLightKind m_forceLightKind;

	public eWeather m_forceWeatherKind;

	private static readonly Game_Sunlight_FilterManager.eLightKind[] m_lightKinidArray;

	protected void OnTriggerEnter(Collider col)
	{
	}
}
