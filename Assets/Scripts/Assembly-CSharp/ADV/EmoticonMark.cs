using UnityEngine;

namespace ADV
{
    public class EmoticonMark : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_goPrefab;

        [SerializeField]
        private Transform[] m_atrRoot;

        private Emoticon m_sEmoticon;

        private EEmoticon m_eKind;

        private int m_iPosIndex;

        public bool IsAnimEnd
        {
            get
            {
                if (m_sEmoticon != null)
                {
                    return m_sEmoticon.IsAnimEnd;
                }
                return true;
            }
        }

        public bool IsDisp
        {
            get
            {
                return m_sEmoticon != null && m_sEmoticon.gameObject.activeSelf;
            }
        }

        public void Init()
        {
            if (m_sEmoticon == null && m_goPrefab != null && transform != null)
            {
                GameObject go = Instantiate(m_goPrefab, transform);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = Vector3.one;
                go.transform.localRotation = Quaternion.identity;
                m_sEmoticon = go.GetComponent<Emoticon>();
            }

            if (m_sEmoticon != null)
            {
                m_sEmoticon.gameObject.SetActive(false);
            }

            m_eKind = EEmoticon.eNONE;
            m_iPosIndex = -1;
        }

        public void Play(EEmoticon kind, int posIndex = -1)
        {
            if (m_sEmoticon == null)
            {
                Init();
            }

            if (m_sEmoticon == null)
            {
                return;
            }

            if (posIndex >= 0 && m_atrRoot != null && posIndex < m_atrRoot.Length && m_atrRoot[posIndex] != null)
            {
                m_sEmoticon.transform.SetParent(m_atrRoot[posIndex], false);
                m_sEmoticon.transform.localPosition = Vector3.zero;
                m_sEmoticon.transform.localScale = Vector3.one;
                m_sEmoticon.transform.localRotation = Quaternion.identity;
            }

            m_eKind = kind;
            m_iPosIndex = posIndex;
            m_sEmoticon.Play(kind);
        }
    }
}