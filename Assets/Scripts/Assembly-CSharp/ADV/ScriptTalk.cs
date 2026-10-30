using System;
using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
    public class ScriptTalk : ScriptBase
    {
        private enum EParamKind
        {
            eSPEAKER_NAME = 0,
            eCONTENT = 1,
            eFACE_ID = 2,
            eFEEL = 3,
            eEMOTICON_ID = 4,
            eVO_PATH = 5,
            ePOS = 6,
            eWAIT = 7,
            eSE = 8
        }

        public enum EStep
        {
            None,
            WaitInit,
            WaitTap,
            End
        }

        private string m_sSpeakerName;
        private string m_sContent;
        private int m_iFaceID = -1;
        private EFeel m_eFeel = EFeel.eDEFAULT;
        private int m_iEmoticonID = -1;
        private string m_sVoPath;
        private EPosition m_ePos = EPosition.eCENTER;
        private float m_fWait;
        private Sound_Loop m_sSE;
        private EStep m_eStep = EStep.None;

        public override void SetParam(List<string> param)
        {
            base.SetParam(param);
            m_sSpeakerName = GetParam(param, (int)EParamKind.eSPEAKER_NAME);
            m_sContent = GetParam(param, (int)EParamKind.eCONTENT);
            m_iFaceID = GetInt(param, (int)EParamKind.eFACE_ID, -1);
            m_eFeel = (EFeel)GetInt(param, (int)EParamKind.eFEEL, 0);
            m_iEmoticonID = GetInt(param, (int)EParamKind.eEMOTICON_ID, -1);
            m_sVoPath = GetParam(param, (int)EParamKind.eVO_PATH);
            m_ePos = (EPosition)GetInt(param, (int)EParamKind.ePOS, 0);
            m_fWait = GetFloat(param, (int)EParamKind.eWAIT, 0f);
        }

        public override List<string> GetNeedAsset()
        {
            List<string> list = base.GetNeedAsset();
            if (list == null) list = new List<string>();

            if (!string.IsNullOrEmpty(m_sVoPath))
            {
                list.Add(m_sVoPath);
            }
            return list;
        }

        public override bool Init(List<string> param, bool skip)
        {
            SetParam(param);
            m_eStep = EStep.WaitInit;

            if (m_sUI != null && m_sUI.m_sTalk != null)
            {
                m_sUI.m_sTalk.Init(m_sSpeakerName, m_iFaceID, m_eFeel, m_ePos);
                m_sUI.m_sTalk.Bringin();
                m_sUI.m_sTalk.SetContent(m_sContent, skip);
            }

            PlaySound();

            if (skip)
            {
                m_eStep = EStep.End;
                return true;
            }

            m_eStep = EStep.WaitTap;
            return false;
        }

        public override bool Exec(bool tap, bool skip)
        {
            if (skip)
            {
                if (m_sUI != null && m_sUI.m_sTalk != null)
                {
                    m_sUI.m_sTalk.SetContentSkip();
                }
                m_eStep = EStep.End;
                return true;
            }

            if (m_sUI != null && m_sUI.m_sTalk != null)
            {
                if (tap)
                {
                    if (m_sUI.m_sTalk.IsTextMove)
                    {
                        m_sUI.m_sTalk.SetContentSkip();
                        return false;
                    }
                    else
                    {
                        m_eStep = EStep.End;
                        return true;
                    }
                }
            }
            else
            {
                if (tap)
                {
                    m_eStep = EStep.End;
                    return true;
                }
            }

            return m_eStep == EStep.End;
        }

        private void PlaySound()
        {
            if (!string.IsNullOrEmpty(m_sVoPath))
            {
                var soundManager = Sound_Manager.GetInst();
                if (soundManager != null)
                {
                    soundManager.PlayADVVoice(m_sVoPath);
                }
            }
        }
    }
}
