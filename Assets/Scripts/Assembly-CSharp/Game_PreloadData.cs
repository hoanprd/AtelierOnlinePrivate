using UnityEngine;

public class Game_PreloadData : MonoBehaviour
{
	private static Game_PreloadData m_inst;

	public Material[] m_charaMatArray_Body = new Material[0];

	public Material[] m_charaMatArray_Face = new Material[0];

	public bool m_useAnotherWorldMaterial;

	public Material[] m_matArray_AnotherWorld = new Material[0];

	public static Game_PreloadData GetInst()
	{
		return m_inst;
	}

	protected void Awake()
	{
		m_inst = this;
	}

	protected void OnDestroy()
	{
		if (m_inst == this)
		{
			m_inst = null;
		}
	}

	public Material GetMaterial(Game_Chara_Base.eCharaShaderGroupKind groupKind, Game_Chara_Base.eCharaShaderPartKind partKind)
	{
		Material[] arr = ((int)partKind == 0) ? m_charaMatArray_Body : m_charaMatArray_Face;
		int idx = (int)groupKind;
		if (arr != null && idx >= 0 && idx < arr.Length)
		{
			return arr[idx];
		}
		if (arr != null && arr.Length > 0)
		{
			return arr[0];
		}
		return null;
	}
}
