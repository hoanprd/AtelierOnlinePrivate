using UnityEngine;

public class Game_PreloadData : MonoBehaviour
{
	private static Game_PreloadData m_inst;

	public Material[] m_charaMatArray_Body;

	public Material[] m_charaMatArray_Face;

	public bool m_useAnotherWorldMaterial;

	public Material[] m_matArray_AnotherWorld;

	public static Game_PreloadData GetInst()
	{
		return null;
	}

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public Material GetMaterial(Game_Chara_Base.eCharaShaderGroupKind groupKind, Game_Chara_Base.eCharaShaderPartKind partKind)
	{
		return null;
	}
}
