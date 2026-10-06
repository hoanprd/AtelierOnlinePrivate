using System.Collections.Generic;
using UnityEngine;

public class Game_Chara_Base_Chara_Viewer : Game_Mover_Base
{
	public enum ePartKind_chara_viewer
	{
		Area = 0,
		Body = 1,
		Head = 2,
		Hair = 3,
		Helm = 4,
		Ruck = 5,
		EnumMax = 6
	}

	public enum eMaterialKind_chara_viewer
	{
		Normal = 0,
		HiddenShadow = 1
	}

	protected Transform m_charaModelRoot;

	protected Vector3 m_charaModelOffset;

	protected Animator m_targetAnimator;

	protected Game_Chara_FacialAnime m_facialAnime;

	protected float m_rotationY;

	protected List<Renderer> m_modelRendList;

	protected GameObject m_shadowObject;

	protected Transform m_weaponNode;

	protected MakeCharaDataCharaViewer m_makeCharaData;

	protected static readonly string[] m_PartTextureTag;

	protected static int m_otherUserCharaId_Now;

	protected static int m_otherUserCharaId_Max;

	protected static int m_otherUserCharaNum_Async;

	public static int[] m_otherUserCharaList_Area;

	public static int[] m_otherUserCharaList_Body;

	public static int[] m_otherUserCharaList_Head;

	public static int[] m_otherUserCharaList_Hair;

	public static int[] m_otherUserCharaList_Helm;

	public static int[] m_otherUserCharaList_Ruck;

	public static int[] m_otherUserCharaList_Weapon;

	public static int[] m_otherUserCharaList_Motion;

	protected int m_photonActorId;

	public Vector3 GetRotation()
	{
		return default(Vector3);
	}

	public MakeCharaDataCharaViewer GetMakeCharaDataCharaViewer()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected virtual void Initialize()
	{
	}

	protected virtual Vector3 GetBillboardRot()
	{
		return default(Vector3);
	}

	private void SetPartsTexture(ePartKind_chara_viewer kind, GameObject targetObj, string charaIdTag)
	{
	}

	private void SetPartsRenderer(GameObject targetObj)
	{
	}

	protected virtual eAreaKind GetAreaKind()
	{
		return eAreaKind.MapArea;
	}

	public void PlayAnimation(Animation anim, string name)
	{
	}

	public virtual void MakeCharaObject(MakeCharaDataCharaViewer data, bool springFlag)
	{
	}

	protected void SetPickUpTool(ePickUpToolKind kind)
	{
	}

	protected override void SetDrawRenderer(bool enabled)
	{
	}

	public void SetDrawShadow(bool enabled)
	{
	}

	public static int GetAsyncTextureIndex()
	{
		return 0;
	}

	public static List<string> GetAsyncTextureList()
	{
		return null;
	}

	public static void SetOtherUserCharaList()
	{
	}

	public void SetOtherUserChara()
	{
	}

	protected Transform GetTransform(Transform parentNode, string nodeName)
	{
		return null;
	}

	public void SetPhotonActorId(int photonActorId)
	{
	}
}
