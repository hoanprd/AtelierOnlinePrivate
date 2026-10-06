using System.Collections;
using System.Diagnostics;
using Tutorial;
using UnityEngine;

public class TutorialFairy : SingletonBase<TutorialFairy>
{
	public enum ePoint
	{
		Object = 0,
		Point2D = 1,
		Point3D = 2
	}

	public enum eStalkMode
	{
		None = 0,
		Wait = 1,
		Rotate = 2
	}

	private static readonly float sr_f2Pi;

	private static readonly float sr_fAroundTime;

	private GameObject m_goDummy;

	private bool m_bExec;

	private GameObject m_goTarget;

	private TutorialFairyObjRoot m_scrFairyRoot;

	private float m_fRotateRadius;

	private float m_fRotateAngle;

	private Vector3 m_v3TargetPoint_2D;

	private Vector3 m_v3TargetPoint_3D;

	private ePoint m_ePont;

	private Vector3 m_v3TargetDiff;

	private eStalkMode m_eStalkMode;

	private TutorialSpotLight m_scrSpotLight;

	[SerializeField]
	private GameObject m_goFiaryPrefab;

	[SerializeField]
	private GameObject m_goMaskRoot;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void MakeFairy()
	{
	}

	private void Update()
	{
	}

	private void Stalk_Wait()
	{
	}

	private void Stalk_Rotate()
	{
	}

	private void UpdateSpotLight()
	{
	}

	private Vector3 GetTargetLocalPos(ePoint ePointKind)
	{
		return default(Vector3);
	}

	private Vector3 GetNGUIPos(Vector3 v3Position)
	{
		return default(Vector3);
	}

	private Vector3 GetWorldPos(Vector3 v3NGUIPos)
	{
		return default(Vector3);
	}

	[DebuggerHidden]
	private IEnumerator SearchTarget(string strName)
	{
		return null;
	}

	private void SearchTarget(int iObjKind, int iObjNo)
	{
	}

	private bool IsNGUIObject(GameObject goObj)
	{
		return false;
	}

	private void Appear(Data scrData)
	{
	}

	[DebuggerHidden]
	public IEnumerator Move(Data scrData)
	{
		return null;
	}

	private void OnFinishedMove()
	{
	}

	private void Wait(Data scrData)
	{
	}

	[DebuggerHidden]
	private IEnumerator Pick(Data scrData)
	{
		return null;
	}

	private void OnFinishedPick1()
	{
	}

	[DebuggerHidden]
	private IEnumerator PickAfter()
	{
		return null;
	}

	private void OnFinishedPick2()
	{
	}

	[DebuggerHidden]
	private IEnumerator Rotate(Data scrData)
	{
		return null;
	}

	public void Banish()
	{
	}

	private void SpotLight(Data scrData)
	{
	}

	private void Emote(Data scrData)
	{
	}

	private void Effect(Data scrData)
	{
	}

	public void SetData(Data scrData)
	{
	}

	public void Skip(Data scrData, bool bSkip)
	{
	}

	public Vector3 GetFairyTargetPos()
	{
		return default(Vector3);
	}

	public bool IsEnd()
	{
		return false;
	}

	public void ChangeLayer(int layer)
	{
	}
}
