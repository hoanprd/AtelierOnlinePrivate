using UnityEngine;

public abstract class EquipmentListBase<T> : UIListViewBase<T> where T : MonoBehaviour
{
	public GameObject m_goNone;

	public GameObject m_goCursor;

	public Transform[] m_atrCursorRoot;

	public UIScrollListArrow m_sArrow;

	protected int m_iCursorIndex;

	protected T m_sCenterObj;

	protected T m_sSelectObject;

	protected UICenterOnChild m_sCenter;

	protected UIScrollView m_sScrollView;

	protected UIGrid m_sGrid;

	protected int m_iSelectObjIndex;

	protected bool m_bInit;

	public int SelectObjIndex
	{
		get
		{
			return 0;
		}
	}

	public T SelectObj
	{
		get
		{
			return null;
		}
	}

	protected abstract void ChangeItem();

	private void InitData()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public virtual void OnSelect(T target)
	{
	}

	protected virtual void OnCenter(GameObject obj)
	{
	}

	protected virtual void OnUp()
	{
	}

	protected virtual void OnDown()
	{
	}

	protected virtual void SetCursor(T target = null, bool se = true)
	{
	}

	protected virtual T GetNextTarget(bool up)
	{
		return null;
	}

	protected void PreInit()
	{
	}

	protected void InitEnd(bool reset = false)
	{
	}
}
