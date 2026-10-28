using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class System_EffectManager : MonoBehaviour
{
	private static readonly float sc_fEffectScale = 1f;

	private Transform m_trMakeObjectRoot;

	private static System_EffectManager g_scrInst;

	private static readonly string sc_filePath_Particle = "Effect/Particle/";

	private static readonly string sc_filePath_Skill = "Effect/Skill/";

	public const float sc_fParticle_Scale = 1f;

	public const int sc_iParticle_Layer_Normal = 0;

	public const int sc_iParticle_Layer_3DLight = 13;

	public const int sc_iParticle_Layer_3DObject = 0;

	public const int sc_iParticle_Layer_2DObject = 5;

	public const int sc_iParticle_Layer_System = 30;

	public static System_EffectManager GetInst()
	{
		return g_scrInst;
	}

	private void Awake()
	{
		g_scrInst = this;
		m_trMakeObjectRoot = base.transform;
		if (base.transform.parent == null)
		{
			Object.DontDestroyOnLoad(base.gameObject);
		}
	}

	public static string GetParticleAssetPath(eEffectKind eKind)
	{
		return sc_filePath_Particle + eKind;
	}

	public GameObject MakeEffect(eEffectKind eKind, Vector3 vecPos, int iLayerID = 0)
	{
		return MakeEffect(m_trMakeObjectRoot, eKind, vecPos, iLayerID);
	}

	public GameObject MakeEffect(Transform trParent, eEffectKind eKind, Vector3 vecPos, int iLayerID = 0)
	{
		return MakeEffect_Sub(trParent, GetParticleAssetPath(eKind), vecPos, iLayerID);
	}

	public GameObject MakeEffect(Transform trParent, string path, Vector3 vecPos, int iLayerID = 0)
	{
		return MakeEffect_Sub(trParent, path, vecPos, iLayerID);
	}

	public GameObject MakeSkillEffect(Transform trParent, string prefabName, Vector3 vecPos, int iLayerID = 0)
	{
		return MakeEffect_Sub(trParent, sc_filePath_Skill + prefabName, vecPos, iLayerID);
	}

	public GameObject MakeSkillEffect(Transform trParent, Object prefab, Vector3 vecPos, int iLayerID = 0)
	{
		GameObject goPrefab = prefab as GameObject;
		if (goPrefab == null)
		{
			return null;
		}
		GameObject inst = Object.Instantiate(goPrefab, vecPos, Quaternion.identity, trParent != null ? trParent : m_trMakeObjectRoot);
		Util.SetLayerRecursively(inst, iLayerID);
		return inst;
	}

	private GameObject MakeEffect_Sub(Transform trParent, string prefabPath, Vector3 vecPos, int iLayerID)
	{
		GameObject inst = MakeEffect_Origin(prefabPath, iLayerID);
		if (inst != null)
		{
			inst.transform.SetParent(trParent != null ? trParent : m_trMakeObjectRoot, false);
			inst.transform.localPosition = vecPos;
			inst.transform.localScale = Vector3.one * sc_fEffectScale;
		}
		return inst;
	}

	private GameObject MakeEffect_Origin(string prefabPath, int iLayerID)
	{
		if (string.IsNullOrEmpty(prefabPath))
		{
			return null;
		}
		GameObject prefab = Resources.Load<GameObject>(prefabPath);
		if (prefab == null)
		{
			return null;
		}
		GameObject inst = Object.Instantiate(prefab);
		Util.SetLayerRecursively(inst, iLayerID);
		return inst;
	}

	private void InstantiatePrefab(Transform root, string prefabPath, int iLayerID)
	{
		GameObject inst = MakeEffect_Origin(prefabPath, iLayerID);
		if (inst != null && root != null)
		{
			inst.transform.SetParent(root, false);
		}
	}

	[DebuggerHidden]
	private IEnumerator LoadAsset(Transform root, string prefabPath, int iLayerID)
	{
		InstantiatePrefab(root, prefabPath, iLayerID);
		yield break;
	}
}
