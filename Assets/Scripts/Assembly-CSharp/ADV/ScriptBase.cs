using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptBase : MonoBehaviour
	{
		[SerializeField]
		protected UIManager m_sUI;

		protected List<string> m_vParam;

		public void InitUI(UIManager ui)
		{
		}

		public bool Init(bool skip)
		{
			return false;
		}

		public virtual void SetParam(List<string> param)
		{
		}

		public virtual List<string> GetNeedAsset()
		{
			return null;
		}

		public virtual bool Init(List<string> param, bool skip)
		{
			return false;
		}

		public virtual bool Exec(bool tap, bool skip)
		{
			return false;
		}

		public virtual int Next(ScriptInfo all, int startIndex, bool skip)
		{
			return 0;
		}

		public virtual void Skip()
		{
		}

		public virtual void BlockDisp()
		{
		}

		protected virtual void End()
		{
		}

		protected virtual int Jump2(ScriptInfo data, int startIndex, EOrderType order)
		{
			return 0;
		}

		protected int Jump(ScriptInfo data, int startIndex, EOrderType order)
		{
			return 0;
		}

		protected bool IsExistParam(List<string> param, int index)
		{
			return false;
		}

		protected string GetParam(List<string> param, int index, string org = "")
		{
			return null;
		}

		protected bool GetBool(List<string> param, int index, bool org = false)
		{
			return false;
		}

		protected int GetInt(List<string> param, int index, int org = -1)
		{
			return 0;
		}

		protected float GetFloat(List<string> param, int index, float org = 0f)
		{
			return 0f;
		}
	}
}
