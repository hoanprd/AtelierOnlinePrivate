using System.Collections.Generic;
using UnityEngine;

public class EquipMulColorConvertion : MonoBehaviour
{
	[SerializeField]
	private Color m_sMulColor;

	[SerializeField]
	private List<Material> m_vsMaterials;

	private const string csSHADER_NAME = "Custom/MaskMulColorConvertion";

	private const string csDEFAULT_SHADER_NAME = "NowPro/Fresnel/Default/Texture";

	private void OnValidate()
	{
	}

	public void ClearMaterial()
	{
	}

	public void AddMaterial(Material mat)
	{
	}

	public void Init(Color col)
	{
	}

	public void Init()
	{
	}

	public void Default()
	{
	}

	public void Change(Color color)
	{
	}
}
