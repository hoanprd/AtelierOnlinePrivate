using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class System_EffectManager : MonoBehaviour
{
	private static readonly float sc_fEffectScale;

	private Transform m_trMakeObjectRoot;

	private static System_EffectManager g_scrInst;

	private static readonly string sc_filePath_Particle;

	private static readonly string sc_filePath_Skill;

	public const float sc_fParticle_Scale = 1f;

	public const int sc_iParticle_Layer_Normal = 0;

	public const int sc_iParticle_Layer_3DLight = 13;

	public const int sc_iParticle_Layer_3DObject = 0;

	public const int sc_iParticle_Layer_2DObject = 5;

	public const int sc_iParticle_Layer_System = 30;

	public static System_EffectManager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	public static string GetParticleAssetPath(eEffectKind eKind)
	{
		return null;
	}

	public GameObject MakeEffect(eEffectKind eKind, Vector3 vecPos, int iLayerID = 0)
	{
		return null;
	}

	public GameObject MakeEffect(Transform trParent, eEffectKind eKind, Vector3 vecPos, int iLayerID = 0)
	{
		return null;
	}

	public GameObject MakeEffect(Transform trParent, string path, Vector3 vecPos, int iLayerID = 0)
	{
		return null;
	}

	public GameObject MakeSkillEffect(Transform trParent, string prefabName, Vector3 vecPos, int iLayerID = 0)
	{
		return null;
	}

	public GameObject MakeSkillEffect(Transform trParent, Object prefab, Vector3 vecPos, int iLayerID = 0)
	{
		return null;
	}

	private GameObject MakeEffect_Sub(Transform trParent, string prefabPath, Vector3 vecPos, int iLayerID)
	{
		return null;
	}

	private GameObject MakeEffect_Origin(string prefabPath, int iLayerID)
	{
		return null;
	}

	private void InstantiatePrefab(Transform root, string prefabPath, int iLayerID)
	{
	}

	[DebuggerHidden]
	private IEnumerator LoadAsset(Transform root, string prefabPath, int iLayerID)
	{
		return null;
	}
}
