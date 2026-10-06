using UnityEngine;

public class Game_RaderMap_Marker : MonoBehaviour
{
	public enum eMarkerKind
	{
		None = 0,
		Player = 1,
		Chara = 2,
		Enemy = 3,
		Animal = 4,
		Item = 5,
		Line = 6
	}

	public Renderer m_mainRenderer;

	public static string GetTexPath(eMarkerKind kind, int roomIndex = 0)
	{
		return null;
	}

	public void SetData(eMarkerKind kind, int roomIndex = 0)
	{
	}

	public void SetTexture(Texture tex)
	{
	}
}
