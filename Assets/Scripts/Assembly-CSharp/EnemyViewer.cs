using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyViewer : MonoBehaviour
{
	[SerializeField]
	private Camera m_sCamera;

	[SerializeField]
	private eEnemyKind m_eEnemyKind;

	[SerializeField]
	private int m_iKind;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private Dropdown m_sEnemyList;

	[SerializeField]
	private Dropdown m_sEnemySubIDList;

	[SerializeField]
	private Dropdown m_sMotionList;

	[SerializeField]
	private Dropdown m_sEyePatternList;

	[SerializeField]
	private Dropdown m_sMouthPatternList;

	private GameObject m_goEnemy;

	private Animation m_sAnim;

	private Game_Enemy_FaceData m_sFace;

	private int m_iAnimationIndex;

	private List<string> m_vsAnimationName;

	private List<string> m_vsEnemyName;

	private int m_iEye;

	private int m_iMouth;

	private bool m_bKeyDown;

	private float m_fPos;

	private float m_fAngle;

	private void Awake()
	{
	}

	public void OnChangeMotion(int index)
	{
	}

	public void OnChangeEnemy(int index)
	{
	}

	public void OnChangeEnemySubID(int index)
	{
	}

	public void OnChangeEyePattern(int index)
	{
	}

	public void OnChangeMouthPattern(int index)
	{
	}

	private void CreateModel()
	{
	}

	public void OnNext(Dropdown target)
	{
	}

	public void OnPrev(Dropdown target)
	{
	}

	private void Update()
	{
	}
}
