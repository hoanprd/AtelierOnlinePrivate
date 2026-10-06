using UnityEngine;

public class WorldMapColorChanger : MonoBehaviour
{
	[SerializeField]
	private GameObject m_RootObject;

	[SerializeField]
	private Renderer m_WorldMapRenderer;

	[SerializeField]
	private Renderer m_WorldBackRenderer;

	[SerializeField]
	private float m_RED;

	[SerializeField]
	private float m_GREEN;

	[SerializeField]
	private float m_BLUE;

	private UISprite[] m_UISprites;

	private Material m_WorldMapMaterial;

	private Material m_WorldBackMaterial;

	private Color m_DefalutWorldMapColor;

	private Color m_DefalutWorldBackColor;

	public void Init()
	{
	}

	public void ChangeWorldMapCclor(bool isHardMode)
	{
	}
}
