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

        private List<SelectItem> m_vsItemList = new List<SelectItem>();

        public int SelectId
        {
            get
            {
                return m_iSelectId;
            }
        }

        public string SelectContent
        {
            get
            {
                return m_sSelectContent;
            }
        }

        private void Awake()
        {
            if (m_vsItemList == null)
            {
                m_vsItemList = new List<SelectItem>();
            }
            if (m_sGrid != null && m_vsItemList.Count == 0)
            {
                SelectItem[] items = m_sGrid.GetComponentsInChildren<SelectItem>(true);
                foreach (var item in items)
                {
                    if (!m_vsItemList.Contains(item))
                    {
                        m_vsItemList.Add(item);
                    }
                }
            }
        }

        public void Init()
        {
            m_iSelectId = -1;
            m_sSelectContent = string.Empty;
            m_iSelectNum = 0;

            if (m_vsItemList == null)
            {
                m_vsItemList = new List<SelectItem>();
            }

            for (int i = 0; i < m_vsItemList.Count; i++)
            {
                if (m_vsItemList[i] != null)
                {
                    m_vsItemList[i].gameObject.SetActive(false);
                }
            }

            gameObject.SetActive(false);
        }

        public bool RegistItem(int id, string content)
        {
            if (m_vsItemList == null)
            {
                m_vsItemList = new List<SelectItem>();
            }

            while (m_iSelectNum >= m_vsItemList.Count && m_goItemPrefab != null && m_sGrid != null)
            {
                GameObject go = Instantiate(m_goItemPrefab);
                go.transform.SetParent(m_sGrid.transform, false);
                SelectItem si = go.GetComponent<SelectItem>();
                if (si != null)
                {
                    m_vsItemList.Add(si);
                }
                else
                {
                    Destroy(go);
                    break;
                }
            }

            if (m_iSelectNum < m_vsItemList.Count)
            {
                SelectItem item = m_vsItemList[m_iSelectNum];
                if (item != null)
                {
                    item.Init(id, content);
                    m_iSelectNum++;
                    return true;
                }
            }

            return false;
        }

        public void Bringin()
        {
            gameObject.SetActive(true);

            if (m_sGrid != null)
            {
                m_sGrid.repositionNow = true;
            }

            for (int i = 0; i < m_iSelectNum && i < m_vsItemList.Count; i++)
            {
                if (m_vsItemList[i] != null)
                {
                    m_vsItemList[i].Bringin(i * 0.1f);
                }
            }

            var soundManager = Sound_Manager.GetInst();
            if (soundManager != null)
            {
                soundManager.PlaySound("0x62");
            }
        }

        public void Dismiss()
        {
            for (int i = 0; i < m_vsItemList.Count; i++)
            {
                if (m_vsItemList[i] != null)
                {
                    m_vsItemList[i].Dismiss();
                }
            }

            gameObject.SetActive(false);

            var soundManager = Sound_Manager.GetInst();
            if (soundManager != null)
            {
                soundManager.PlaySound("0x5f");
            }
        }

        public void OnSelect(SelectItem item)
        {
            if (item != null)
            {
                m_iSelectId = item.ID;
                m_sSelectContent = item.m_sContent != null ? item.m_sContent.text : string.Empty;

                var soundManager = Sound_Manager.GetInst();
                if (soundManager != null)
                {
                    soundManager.PlaySound("0x5e");
                }

                Dismiss();
            }
        }

        public void Select(int id)
        {
            for (int i = 0; i < m_iSelectNum && i < m_vsItemList.Count; i++)
            {
                if (m_vsItemList[i] != null && m_vsItemList[i].ID == id)
                {
                    OnSelect(m_vsItemList[i]);
                    break;
                }
            }
        }
    }
}