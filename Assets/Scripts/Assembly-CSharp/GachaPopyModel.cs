using UnityEngine;

public class GachaPopyModel : MonoBehaviour
{
	[SerializeField]
	private Animation m_sAnim;

	[SerializeField]
	private SkinnedMeshRenderer m_sRenderer;

	private Material m_sFaceMaterial;

	private void Awake()
	{
	}

	public void SetEmotion(int id)
	{
	}

	public void SetSE(eSoundID id)
	{
	}
}
