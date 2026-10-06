using System.Collections.Generic;
using FieldUseItem;
using UnityEngine;

public class Game_UI_Launcher_UseItem : Game_UI_Launcher_SubMenu
{
	public abstract class FieldUseItemSubBase
	{
		protected Game_UI_Launcher_UseItem m_scrParent;

		protected List<ItemInfo>[] m_clsItemListAry;

		protected eItemRange m_eRange;

		protected int m_iNowIndex;

		protected int[] m_iPrevItemDF;

		protected List<ItemInfo> m_clsNowItemList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract List<FieldItem> GetFieldItemList();

		public abstract int CountUseNum(int iCountMax, FieldItem clsUseItem);

		public abstract void UseItemAPI(long[] lUseItemAry, float[] fHealRateAry, int[] iHealStateAry, bool bOthers);

		public abstract void UpdateCircleEffect(bool bOthers);

		public void SetParent(Game_UI_Launcher_UseItem scrParent)
		{
		}

		public void UpdateItemList()
		{
		}

		public bool IsEnableMode()
		{
			return false;
		}

		public void Init(bool bEnable = true)
		{
		}

		public void ChangeNextRange()
		{
		}

		private void ChangeRange(eItemRange eRange, bool bInitUI = true)
		{
		}

		public eItemRange GetNextRange()
		{
			return eItemRange.One;
		}

		protected void InitUI(bool bEnable = true)
		{
		}

		protected void UpdateItemUI(ItemInfo clsItem)
		{
		}

		public void Next()
		{
		}

		public void Prev()
		{
		}

		public void OnUseItem()
		{
		}

		public void OnDismiss()
		{
		}
	}

	public class FieldUseItemSubCure : FieldUseItemSubBase
	{
		public override List<FieldItem> GetFieldItemList()
		{
			return null;
		}

		public override int CountUseNum(int iCountMax, FieldItem clsUseItem)
		{
			return 0;
		}

		public override void UseItemAPI(long[] lUseItemAry, float[] fHealRateAry, int[] iHealStateAry, bool bOthers)
		{
		}

		public override void UpdateCircleEffect(bool bOthers)
		{
		}
	}

	public class FieldUseItemSubHeal : FieldUseItemSubBase
	{
		public override List<FieldItem> GetFieldItemList()
		{
			return null;
		}

		public override int CountUseNum(int iCountMax, FieldItem clsUseItem)
		{
			return 0;
		}

		public override void UseItemAPI(long[] lUseItemAry, float[] fHealRateAry, int[] iHealStateAry, bool bOthers)
		{
		}

		public override void UpdateCircleEffect(bool bOthers)
		{
		}
	}

	public static readonly eEffectKind[] sr_eEffectAry;

	[SerializeField]
	private UIButton[] m_scrButtonAry;

	[SerializeField]
	private UIButton[] m_scrArrowButton;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private GameObject[] m_goSelectObjAry;

	[SerializeField]
	private AbnormalStateIconList m_scrStateIcon;

	private FieldUseItemSubBase[] m_clsSubAry;

	private eItemMode m_eNowMode;

	private bool m_bUpdateButton;

	private void LateUpdate()
	{
	}

	private void MakeSubScript()
	{
	}

	protected void SetLabelText(eLabel eKind, string strText)
	{
	}

	private void SetActiveArrow(bool bActive)
	{
	}

	private void MakeStateObj(List<EAbnormalState> eStateList)
	{
	}

	private void SetEnableButton(eButton eKind, bool bEnable)
	{
	}

	protected void MakeCircleEffect(eUseItemEffect eEffect)
	{
	}

	protected void RemoveCircleEffect(eUseItemEffect eEffect = eUseItemEffect.EnumMax)
	{
	}

	public void UpdateItemList()
	{
	}

	public void UpdateButtonEnable()
	{
	}

	public bool IsEnableMode(eItemMode eMode)
	{
		return false;
	}

	public void Init(eItemMode eMode)
	{
	}

	public override void Bringin()
	{
	}

	public override void Dismiss()
	{
	}

	public void Next()
	{
	}

	public void Prev()
	{
	}

	public void ChangeRange()
	{
	}

	public void OnUseItem()
	{
	}
}
