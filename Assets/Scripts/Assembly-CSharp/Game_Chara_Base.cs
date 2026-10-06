using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CharaMotion;
using UnityEngine;

public class Game_Chara_Base : Game_Mover_Base
{
	public enum eAnimator
	{
		Male = 0,
		Female = 1,
		Oregano = 2,
		Oldman = 3,
		Macho = 4,
		EnumMax = 5
	}

	[Serializable]
	protected class LoadInfo
	{
		public enum EStep
		{
			eWAIT = 0,
			eUNLOAD = 1,
			eEND = 2
		}

		public EStep step;

		public MakeCharaData makeCharaData;

		public bool springFlag;

		public bool ignoreOptionParts;

		public List<string> assetList;
	}

	public enum eModelKind
	{
		eHEAD = 0,
		eHAIR = 1,
		eHELM = 2,
		eBODY = 3,
		eWEAPON = 4,
		eSHIELD = 5,
		eRUCK = 6,
		eACC_FACE = 7,
		eACC_BACK = 8,
		eMAX = 9
	}

	public enum ePartKind
	{
		Body = 0,
		Head = 1,
		Hair = 2,
		EnumMax = 3
	}

	public enum eCharaShaderGroupKind
	{
		Normal = 0,
		Mob = 1
	}

	public enum eCharaShaderPartKind
	{
		Body = 0,
		Face = 1
	}

	public static readonly string[] m_animatorPath;

	protected Transform m_charaModelRoot;

	public static readonly Vector3 m_charaModelOffset;

	public static readonly Vector3 m_shadowModelOffset;

	public static readonly float m_shadowModelScale;

	protected Animator m_targetAnimator;

	protected Game_Chara_FacialAnime m_facialAnime;

	protected Animation m_targetLegacyAnim;

	protected float m_rotationY;

	protected List<Renderer> m_modelRendList;

	protected GameObject m_shadowObject;

	protected SpringManager m_springManager;

	protected MakeCharaData m_makeCharaData;

	protected GameObject[] m_agoPart;

	protected GameObject m_headNode;

	protected Transform m_weaponNode;

	protected Transform m_spineNode;

	protected Transform m_shieldNode;

	protected Transform m_faceNode;

	protected Transform m_backNode;

	protected bool m_existFace;

	protected eAnimator m_animKind;

	protected Coroutine m_rotateCoroutine;

	public bool m_macho;

	protected GameObject m_goRod;

	protected GameObject m_goCaldron;

	protected GameObject m_goMap;

	protected bool m_isLoaded;

	protected LoadInfo m_loadData;

	protected static readonly string[] m_PartTextureTag;

	public Vector3 GetRotation()
	{
		return default(Vector3);
	}

	public MakeCharaData GetMakeCharaData()
	{
		return null;
	}

	public bool IsLoaded()
	{
		return false;
	}

	public bool IsLoadReserve()
	{
		return false;
	}

	protected override void Awake()
	{
	}

	protected virtual void Initialize()
	{
	}

	public void UpdateScale(float value)
	{
	}

	public static GameObject MakeShadow(Transform parent, float scale = 1f)
	{
		return null;
	}

	public static GameObject MakeAura(Transform parent, eEffectKind aura, float scale = 1f)
	{
		return null;
	}

	protected virtual Vector3 GetBillboardRot()
	{
		return default(Vector3);
	}

	protected virtual eCharaShaderGroupKind GetShaderGroupKind()
	{
		return eCharaShaderGroupKind.Normal;
	}

	protected virtual void SetSkinTexture(GameObject target, int chara, int color, eRaceKind kind)
	{
	}

	private void SetFaceTexture(GameObject target, int eye, int color, eRaceKind kind)
	{
	}

	private void SetHairTexture(GameObject target, int kind, int color)
	{
	}

	protected void SetPartsTexture(ePartKind kind, GameObject targetObj, string charaIdTag, int colorID = 0, int skinID = 0)
	{
	}

	protected void SetPartsRenderer(GameObject targetObj)
	{
	}

	protected void BlendMacho()
	{
	}

	protected virtual void SetAnimSystem(MakeCharaData data, GameObject bodyObj)
	{
	}

	protected void SetAnimSystem_Mecanim(MakeCharaData data, GameObject bodyObj)
	{
	}

	protected void SetAnimSystem_Legacy(MakeCharaData data, GameObject bodyObj)
	{
	}

	public virtual void ChangeAnimator(eAnimator eAnim)
	{
	}

	private void ChangeAnimationClip(eAnimator eAnim)
	{
	}

	public void DispWeaponQualityEffect(bool sw)
	{
	}

	protected virtual void ChangeBody(MakeCharaData member, int chara, int skin, eRaceKind kind, bool springFlag)
	{
	}

	protected virtual void ChangeBody(MakeCharaData data, bool springFlag)
	{
	}

	protected virtual void ChangeHead(MakeCharaData data)
	{
	}

	protected virtual void ChangeHair(MakeCharaData data)
	{
	}

	protected virtual void ChangeWeapon(EWeaponKind kind, int id, EQuality quality = EQuality.eC)
	{
	}

	protected virtual void ChangeShield(int id, bool disp)
	{
	}

	protected virtual void ChangeHelm(int id)
	{
	}

	protected virtual void ChangeFaceAccessory(int id)
	{
	}

	protected virtual void ChangeBackAccessory(int id)
	{
	}

	public virtual void UpdateCharaModel(MakeCharaData data, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	public virtual void MakeCharaObject(int charaId)
	{
	}

	public virtual void MakeCharaObject(MakeCharaData data, bool springFlag, bool ignoreOptionParts = false, eAnimator anim = eAnimator.EnumMax)
	{
	}

	public void ChangeAnimKind(eAnimator anim)
	{
	}

	private void LoadModel()
	{
	}

	protected virtual void InstantiateModel(MakeCharaData mk, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	protected virtual void InitAnim()
	{
	}

	protected void LoadRequestModel(MakeCharaData mk, bool springFlag, bool ignoreOptionParts = false)
	{
	}

	protected void CheckQualityEffect(Transform root, EQuality qua)
	{
	}

	public void SetEnableGravity(bool enableFlag)
	{
	}

	public void SetPickUpTool(ePickUpToolKind kind, ePickupToolLook look = ePickupToolLook.Normal)
	{
	}

	public void DestroyMotionParts()
	{
	}

	public bool IsMotionParts()
	{
		return false;
	}

	public void OnAlchemyParts()
	{
	}

	public void OnMapParts()
	{
	}

	protected override void SetDrawRenderer(bool enabled)
	{
	}

	public void SetDrawShadow(bool enabled)
	{
	}

	public float GetRotation(Vector3 from, Vector3 target)
	{
		return 0f;
	}

	public void StartRotate(float rotY, float rotTime = 0.2f)
	{
	}

	public virtual void StartRotate(Vector3 target, float rotTime = 0.2f)
	{
	}

	[DebuggerHidden]
	public IEnumerator Rotate(Vector3 target, float rotTime = 0.2f)
	{
		return null;
	}

	public bool IsEndRotate()
	{
		return false;
	}

	public GameObject GetNode_Name(Transform parentNode, string nodeName)
	{
		return null;
	}

	public GameObject GetNode_Body()
	{
		return null;
	}

	public GameObject GetNode_Head()
	{
		return null;
	}

	public GameObject GetPartsObject(int kind)
	{
		return null;
	}

	public void SetActiveOffWeapon()
	{
	}

	protected override void Update()
	{
	}

	private void SetScale(string[] part, float scale)
	{
	}

	protected virtual Texture LoadTexture(string path)
	{
		return null;
	}

	protected virtual GameObject CreatePart(eModelKind kind, Transform parent, string path)
	{
		return null;
	}

	protected void CreateHair(int id, int color, int helmId, int charaId)
	{
	}

	protected static EHelmKind GetHelmKind(int charaID, int helmID)
	{
		return EHelmKind.eNORMAL;
	}

	public static string GetBodyPath(int id, eRaceKind kind)
	{
		return null;
	}

	public static List<string> GetWeaponPath(int id, EWeaponKind kind)
	{
		return null;
	}

	public static string GetShieldPath(int id)
	{
		return null;
	}

	public static string GetHeadPath(int id)
	{
		return null;
	}

	public static List<string> GetFaceTexPath(int eye, int color, eRaceKind raceKind)
	{
		return null;
	}

	public static string GetSkinTexPath(int charaID, int color, eRaceKind raceKind)
	{
		return null;
	}

	public static string GetHelmPath(int id)
	{
		return null;
	}

	public static string GetHairPath(int id, int color, int helm, int chara)
	{
		return null;
	}

	public static string GetHairTexPath(int id, int color)
	{
		return null;
	}

	public static string GetFaceAccessoryPath(int id)
	{
		return null;
	}

	public static string GetBackAccessoryPath(int id)
	{
		return null;
	}

	public static List<string> GetAssetList(MakeCharaData mk)
	{
		return null;
	}

	public static Game_Chara_MenuUI_Base MakeMenuChara_Player(MakeCharaData mk, bool springFlag)
	{
		return null;
	}

	public void SetFace(eFaceKind kind, int frame)
	{
	}

	public void SetFace(eExpKind_Eye eye, eExpKind_Mouth mouth, int frame, bool loop = false)
	{
	}

	public void SetFace(string name, int frame)
	{
	}

	protected override void OnDestroy()
	{
	}
}
