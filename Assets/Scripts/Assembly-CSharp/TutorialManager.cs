using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Tutorial;
using UnityEngine;

// Định nghĩa bổ trợ cho Tutorial_Define
public static class Tutorial_Define
{
    public static List<eTutorial> GetSkipList(eTutorial eKind) => Tutorial.Define.GetSkipList(eKind);
    public static int GetSendFlag(eTutorial eKind) => Tutorial.Define.GetSendFlag(eKind) ? 1 : 0;
}

// Định nghĩa extension methods cho TutorialCommandBase
public static class TutorialCommandExtensions
{
    public static int GetKind(this TutorialCommandBase cmd) => 0;
    public static bool IsRequestButton(this TutorialCommandBase cmd) => false;
    public static bool IsRequestButton(this TutorialCommandBase cmd, string name) => false;
    public static bool IsMakeButtonArrow(this TutorialCommandBase cmd, string name) => false;
    public static bool ClickedButton(this TutorialCommandBase cmd, string name) => false;
}

public class TutorialManager : SingletonBase<TutorialManager>
{
    public enum eMainStep
    {
        Wait = 0,
        LoadAsset_Init = 1,
        LoadAsset_Wait = 2,
        Make = 3,
        Control_Init = 4,
        Control_Wait = 5,
        SendFlag_Init = 6,
        SendFlag_Wait = 7,
        End = 8
    }

    private static readonly string sr_strIgnoreMaskTag = "IgnoreTutorialMask";

    private bool[] m_bFlagAry = new bool[512];
    private eTutorial m_eNowTutorial;
    private DataUnit m_clsDataUnit;
    private int m_iNowDataIndex;
    private Data m_clsNowData;
    private eMainStep m_eStep = eMainStep.Wait;
    private bool m_bCommandEnd;
    private bool m_bAPIEnd;
    private Action<eTutorial, bool, bool> m_clsCallBack;
    private TutorialCommandBase m_scrCommand;
    private bool m_bForceEnd;
    private Dictionary<UICamera, int> m_iEventMaskDic = new Dictionary<UICamera, int>();
    private bool m_bSkip;

    [SerializeField]
    private GameObject m_goCollider;

    protected override void Awake()
    {
        base.Awake();
        if (m_goCollider != null)
        {
            m_goCollider.SetActive(false);
        }
    }

    private void Update()
    {
        if (m_bForceEnd)
        {
            End();
            m_bForceEnd = false;
            return;
        }

        switch (m_eStep)
        {
            case eMainStep.LoadAsset_Init:
                LoadAsset_Init();
                break;
            case eMainStep.LoadAsset_Wait:
                if (LoadAsset_Wait())
                {
                    m_eStep = eMainStep.Make;
                }
                break;
            case eMainStep.Make:
                Make();
                break;
            case eMainStep.Control_Init:
                Control_Init();
                break;
            case eMainStep.Control_Wait:
                if (Control_Wait())
                {
                    m_eStep = eMainStep.SendFlag_Init;
                }
                break;
            case eMainStep.SendFlag_Init:
                SendFlag_Init();
                break;
            case eMainStep.SendFlag_Wait:
                if (SendFlag_Wait())
                {
                    m_eStep = eMainStep.End;
                }
                break;
            case eMainStep.End:
                End();
                break;
            default:
                break;
        }
    }

    private void SwitchObjectState()
    {
        if (m_goCollider != null)
        {
            bool isActive = m_eStep != eMainStep.Wait && m_eStep != eMainStep.End;
            m_goCollider.SetActive(isActive);
        }
    }

    private void LoadAsset_Init()
    {
        string assetPath = Tutorial.Define.GetAssetName(m_eNowTutorial);
        if (string.IsNullOrEmpty(assetPath))
        {
            assetPath = "tutorial/academy_first/Academy_First";
        }
        m_clsDataUnit = Resources.Load<DataUnit>(assetPath);
        m_iNowDataIndex = 0;
        m_clsNowData = null;
        m_eStep = eMainStep.LoadAsset_Wait;
    }

    private bool LoadAsset_Wait()
    {
        return true;
    }

    private void Make()
    {
        if (m_clsDataUnit == null || m_clsDataUnit.clsDataList == null || m_iNowDataIndex >= m_clsDataUnit.clsDataList.Count)
        {
            m_eStep = eMainStep.SendFlag_Init;
            return;
        }

        m_clsNowData = m_clsDataUnit.clsDataList[m_iNowDataIndex];
        m_bCommandEnd = false;

        if (m_scrCommand != null)
        {
            Destroy(m_scrCommand);
            m_scrCommand = null;
        }

        m_scrCommand = CreateCommand(m_clsNowData.eKind);
        if (m_scrCommand != null)
        {
            m_scrCommand.Exec(m_clsNowData);
        }
        else
        {
            m_bCommandEnd = true;
        }
        m_eStep = eMainStep.Control_Init;
    }

    private TutorialCommandBase CreateCommand(eExecKind kind)
    {
        switch (kind)
        {
            case eExecKind.ADV:
                return gameObject.AddComponent<TutorialCommandADV>();
            case eExecKind.Wait:
                return gameObject.AddComponent<TutorialCommandWait>();
            case eExecKind.WaitTouch:
                return gameObject.AddComponent<TutorialCommandWaitTouch>();
            case eExecKind.Popup:
                return gameObject.AddComponent<TutorialCommandPopup>();
            case eExecKind.Arrow:
                return gameObject.AddComponent<TutorialCommandArrow>();
            case eExecKind.CloseLauncher:
                return gameObject.AddComponent<TutorialCommandCloseLauncher>();
            case eExecKind.OpenLauncher:
                return gameObject.AddComponent<TutorialCommandOpenLauncher>();
            case eExecKind.ClickButton:
                return gameObject.AddComponent<TutorialCommandClickButton>();
            case eExecKind.JumpRequest:
                return gameObject.AddComponent<TutorialCommandRequestJump>();
            case eExecKind.QuestClear:
                return gameObject.AddComponent<TutorialCommandQuestClear>();
            case eExecKind.DispGuide:
                return gameObject.AddComponent<TutorialCommandDispGuide>();
            case eExecKind.TargetArrow:
                return gameObject.AddComponent<TutorialCommandTargetArrow>();
            case eExecKind.TargetArrowOFF:
                return gameObject.AddComponent<TutorialCommandTargetArrowOFF>();
            case eExecKind.ButtonStatus:
                return gameObject.AddComponent<TutorialCommandSwitchButton>();
            case eExecKind.SkipSelect:
                return gameObject.AddComponent<TutorialCommandSkipSelect>();
            case eExecKind.OnSkip:
                return gameObject.AddComponent<TutorialCommandOnSkip>();
            case eExecKind.QstTgtActive:
                return gameObject.AddComponent<TutorialCommandQuestTargetActive>();
            case eExecKind.QstTgtInfo:
                return gameObject.AddComponent<TutorialCommandQuestTargetInfo>();
            case eExecKind.WaitNoticce:
                return gameObject.AddComponent<TutorialCommandWaitNotice>();
            case eExecKind.LoginBonus:
                return gameObject.AddComponent<TutorialCommandLoginBonus>();
            default:
                return null;
        }
    }

    private void MakeDialog(string strTitle, string strMessage, string strButtonName = "")
    {
        var uiBg = UIBackgroundManager.Instance;
        if (uiBg != null)
        {
        }
    }

    private void Control_Init()
    {
        if (m_scrCommand != null && m_scrCommand.GetKind() == 5)
        {
            return;
        }
        if (m_goCollider != null)
        {
            m_goCollider.SetActive(false);
        }
        m_eStep = eMainStep.Control_Wait;
    }

    private bool Control_Wait()
    {
        if (m_scrCommand != null)
        {
            if (m_scrCommand.IsEnd())
            {
                Destroy(m_scrCommand);
                m_scrCommand = null;
                m_iNowDataIndex++;
                if (m_clsDataUnit != null && m_clsDataUnit.clsDataList != null && m_iNowDataIndex < m_clsDataUnit.clsDataList.Count)
                {
                    m_eStep = eMainStep.Make;
                    return false;
                }
                return true;
            }
            return false;
        }
        return m_bCommandEnd;
    }

    private void SendFlag_Init()
    {
        m_bCommandEnd = false;
        m_bAPIEnd = false;

        List<eTutorial> sendList = new List<eTutorial> { m_eNowTutorial };
        if (m_bSkip)
        {
            var skipList = Tutorial_Define.GetSkipList(m_eNowTutorial);
            if (skipList != null)
            {
                sendList.AddRange(skipList);
            }
        }

        foreach (var tut in sendList)
        {
            SetFlag(tut, true);
        }

        StartCoroutine(SendTutorialFlag_Private(sendList));
        m_eStep = eMainStep.SendFlag_Wait;
    }

    private bool SendFlag_Wait()
    {
        return m_bAPIEnd;
    }

    [DebuggerHidden]
    private IEnumerator SendTutorialFlag_Private(List<eTutorial> eSendList)
    {
        yield return StartCoroutine(SendTutorialFlag(eSendList));
        m_bAPIEnd = true;
    }

    [DebuggerHidden]
    public IEnumerator SendTutorialFlag(List<eTutorial> eSendList)
    {
        yield return null;
    }

    private void End()
    {
        UndoCameraMask();
        if (m_goCollider != null)
        {
            m_goCollider.SetActive(false);
        }

        if (m_scrCommand != null)
        {
            Destroy(m_scrCommand);
            m_scrCommand = null;
        }

        bool force = m_bForceEnd;
        bool skip = m_bSkip;
        eTutorial finishedTutorial = m_eNowTutorial;

        m_clsDataUnit = null;
        m_clsNowData = null;
        m_eStep = eMainStep.Wait;
        m_eNowTutorial = (eTutorial)0;

        if (m_clsCallBack != null)
        {
            var callback = m_clsCallBack;
            m_clsCallBack = null;
            callback(finishedTutorial, !force, skip);
        }
    }

    private void OnDialogCommon(EButtonKind eResult)
    {
        m_bCommandEnd = true;
    }

    private bool IsOutOfTutorialRange(int iKind)
    {
        return false;
    }

    public void SetCameraMask()
    {
    }

    public void UndoCameraMask()
    {
    }

    public bool IsCameraMask()
    {
        return m_iEventMaskDic != null && m_iEventMaskDic.Count > 0;
    }

    public bool ExecTutorial(eTutorial eKind, Action<eTutorial, bool, bool> clsCallBack = null, bool bForce = false)
    {
        if (m_eStep != eMainStep.Wait && !bForce)
        {
            return false;
        }

        if (GetFlag(eKind) && !bForce)
        {
            return false;
        }

        m_eNowTutorial = eKind;
        m_clsCallBack = clsCallBack;
        m_bForceEnd = false;
        m_bSkip = false;
        m_eStep = eMainStep.LoadAsset_Init;
        SwitchObjectState();
        return true;
    }

    public bool GetFlag(eTutorial eKind)
    {
        int index = (int)eKind;
        if (index >= 0 && index < m_bFlagAry.Length)
        {
            return m_bFlagAry[index];
        }
        return false;
    }

    public void SetFlag(eTutorial eKind, bool bFlag = true)
    {
        int index = (int)eKind;
        if (index >= 0 && index < m_bFlagAry.Length)
        {
            m_bFlagAry[index] = bFlag;
        }
    }

    public void SetFlag_DF(int iDF, bool bFlag = true)
    {
        SetFlag((eTutorial)iDF, bFlag);
    }

    public void SetAllFlag(bool bFlag)
    {
        for (int i = 0; i < m_bFlagAry.Length; i++)
        {
            m_bFlagAry[i] = bFlag;
        }
    }

    public eTutorial GetNowTutorial()
    {
        return m_eNowTutorial;
    }

    public eExecKind GetNowCommand()
    {
        if (m_scrCommand != null)
        {
            return (eExecKind)m_scrCommand.GetKind();
        }
        return eExecKind.ADV;
    }

    public bool IsMoveOK()
    {
        return m_eStep == eMainStep.Wait;
    }

    public bool IsTouchOK()
    {
        return m_eStep == eMainStep.Wait;
    }

    public bool IsPrevTouch()
    {
        return false;
    }

    public bool IsExec()
    {
        return m_eStep != eMainStep.Wait;
    }

    public bool IsEnd()
    {
        return m_eStep == eMainStep.Wait;
    }

    public bool IsRequestButtonNow()
    {
        return m_scrCommand != null && m_scrCommand.IsRequestButton();
    }

    public bool IsRequestButtonNow(string strName)
    {
        return m_scrCommand != null && m_scrCommand.IsRequestButton(strName);
    }

    public bool IsMakeButtonArrow(string strName)
    {
        return m_scrCommand != null && m_scrCommand.IsMakeButtonArrow(strName);
    }

    public bool ClickedButton(string strName)
    {
        if (m_scrCommand != null)
        {
            return m_scrCommand.ClickedButton(strName);
        }
        return false;
    }

    public void SetSkip(bool bSkip)
    {
        m_bSkip = bSkip;
    }

    public void ForceEnd()
    {
        m_bForceEnd = true;
    }
}
