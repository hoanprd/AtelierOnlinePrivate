using UnityEngine;

namespace ADV
{
    public class ADVLoading : SingletonBase<ADVLoading>
    {
        private enum EStep
        {
            eNONE = 0,
            eIN = 1,
            eANIM_IN = 2,
            eWAIT = 3,
            eOUT = 4
        }

        [SerializeField]
        private UITweenReset m_sBlackAnim;

        private EStep m_eStep;

        private bool m_bExitReq;

        private float m_fDuration;

        public static bool IsEnd
        {
            get
            {
                if (Instance == null) return true;
                return Instance.m_eStep == EStep.eNONE;
            }
        }

        public static bool IsBlackOut
        {
            get
            {
                if (Instance == null) return false;
                return Instance.m_eStep != EStep.eNONE;
            }
        }

        public static void Enable(float duration = 0.5f)
        {
            if (Instance != null)
            {
                Instance.m_fDuration = duration;
                Instance.m_bExitReq = false;
                Instance.m_eStep = EStep.eIN;
                if (Instance.gameObject != null)
                {
                    Instance.gameObject.SetActive(true);
                }
                if (Instance.m_sBlackAnim != null)
                {
                    Instance.m_sBlackAnim.ResetTweenForward();
                }
            }
        }

        public static void Disable(float duration = 0.5f)
        {
            if (Instance != null)
            {
                Instance.m_fDuration = duration;
                Instance.m_bExitReq = true;
                Instance.m_eStep = EStep.eOUT;
                if (Instance.m_sBlackAnim != null)
                {
                    Instance.m_sBlackAnim.ResetTweenReverse();
                }
            }
        }

        private void Update()
        {
            switch (m_eStep)
            {
                case EStep.eIN:
                    m_eStep = EStep.eANIM_IN;
                    break;

                case EStep.eANIM_IN:
                    if (m_sBlackAnim == null || m_sBlackAnim.IsAnimEnd)
                    {
                        if (m_bExitReq)
                        {
                            m_eStep = EStep.eOUT;
                        }
                        else
                        {
                            m_eStep = EStep.eWAIT;
                        }
                    }
                    break;

                case EStep.eWAIT:
                    if (m_bExitReq)
                    {
                        m_eStep = EStep.eOUT;
                        if (m_sBlackAnim != null)
                        {
                            m_sBlackAnim.ResetTweenReverse();
                        }
                    }
                    break;

                case EStep.eOUT:
                    if (m_sBlackAnim == null || m_sBlackAnim.IsAnimEnd)
                    {
                        m_eStep = EStep.eNONE;
                        if (gameObject != null)
                        {
                            gameObject.SetActive(false);
                        }
                    }
                    break;
            }
        }

        protected override void Awake()
        {
            base.Awake();
            m_eStep = EStep.eNONE;
            if (gameObject != null)
            {
                gameObject.SetActive(false);
            }
        }
    }
}