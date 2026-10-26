using System;
using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
    public class ScriptBase : MonoBehaviour
    {
        [SerializeField]
        protected UIManager m_sUI;

        protected List<string> m_vParam;

        public virtual void InitUI(UIManager ui)
        {
            m_sUI = ui;
        }

        public virtual bool Init(bool skip)
        {
            return true;
        }

        public virtual void SetParam(List<string> param)
        {
            m_vParam = param;
        }

        public virtual List<string> GetNeedAsset()
        {
            return null;
        }

        public virtual bool Init(List<string> param, bool skip)
        {
            SetParam(param);
            return Init(skip);
        }

        public virtual bool Exec(bool tap, bool skip)
        {
            return true;
        }

        public virtual int Next(ScriptInfo all, int startIndex, bool skip)
        {
            return startIndex + 1;
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
            return startIndex;
        }

        protected int Jump(ScriptInfo data, int startIndex, EOrderType order)
        {
            return Jump2(data, startIndex, order);
        }

        protected bool IsExistParam(List<string> param, int index)
        {
            return param != null && index >= 0 && index < param.Count;
        }

        protected string GetParam(List<string> param, int index, string org = "")
        {
            if (IsExistParam(param, index))
            {
                string val = param[index];
                return string.IsNullOrEmpty(val) ? org : val;
            }
            return org;
        }

        protected bool GetBool(List<string> param, int index, bool org = false)
        {
            if (IsExistParam(param, index))
            {
                int res;
                if (int.TryParse(param[index], out res))
                {
                    return res != 0;
                }
                bool bRes;
                if (bool.TryParse(param[index], out bRes))
                {
                    return bRes;
                }
            }
            return org;
        }

        protected int GetInt(List<string> param, int index, int org = -1)
        {
            if (IsExistParam(param, index))
            {
                int res;
                if (int.TryParse(param[index], out res))
                {
                    return res;
                }
            }
            return org;
        }

        protected float GetFloat(List<string> param, int index, float org = 0f)
        {
            if (IsExistParam(param, index))
            {
                float res;
                if (float.TryParse(param[index], out res))
                {
                    return res;
                }
            }
            return org;
        }
    }
}