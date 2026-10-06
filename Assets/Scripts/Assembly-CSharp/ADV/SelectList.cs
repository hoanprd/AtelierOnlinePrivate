using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class SelectList : MonoBehaviour
	{
		public GameObject m_goItemPrefab;

		public UIGrid m_sGrid;

		private int m_iSelectId;

		private string m_sSelectContent;

		private int m_iSelectNum;

		private List<SelectItem> m_vsItemList;

		public int SelectId
		{
			get
			{
				return 0;
			}
		}

		public string SelectContent
		{
			get
			{
				return null;
			}
		}

		public void Init()
		{
		}

		public bool RegistItem(int id, string content)
		{
			return false;
		}

		public void Bringin()
		{
		}

		public void Dismiss()
		{
		}

		public void OnSelect(SelectItem item)
		{
		}

		public void Select(int id)
		{
		}
	}
}
