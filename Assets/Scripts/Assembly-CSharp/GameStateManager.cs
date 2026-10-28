using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private class MiniRankingI
    {
        public int m_df;
        public string m_name;
        public int m_type;
        public DateTime m_clsStartTime;
        public DateTime m_clsEndTime;
        public int m_wealth_df;
        public List<int> charaDfs;
        public List<List<DateTime>> m_boostTims;
        public int m_iTotalScore;
        public double m_iReversal;

        public MiniRankingI(MiniRankingInfo mri)
        {
            if (mri != null)
            {
            }
        }
    }

    private static GameStateManager sInstance;

    public int iOverrideSkillID;
    private string sUserName;
    public string sUserCode;
    public long iUserID;
    public int iScreenWidth;
    public int iScreenHeight;
    public EResolutionLevel eResolution;
    public RenderTexture txRenderTexture;

    public Dictionary<int, int> adWealth = new Dictionary<int, int>();
    public Dictionary<int, int> adWealthCompensation = new Dictionary<int, int>();

    public FriendList sFriend;
    public AlchemyUserInfo sAlchemyInfo;
    public PartyInfo sParty;
    public DailyMissionInfo sDailyMission;
    public List<QuestDetail> sQuestStatusList = new List<QuestDetail>();
    public InventoryList sInventory;
    public int iPresentNum;
    public List<UnlockAreaInfo> sUnlockAreaList = new List<UnlockAreaInfo>();
    public HomeEnter.LevelLimit sLimitbreakLimit;
    public Formula sLimitbreakEXPCoef;
    public int iLEVEL_CAP;
    public Dictionary<int, List<EXPTable>> sCharaEXPTable = new Dictionary<int, List<EXPTable>>();
    public List<PopupInfo> vPopupList = new List<PopupInfo>();
    public List<PopupInfo> vGuideList = new List<PopupInfo>();
    public List<PopupInfo> vInformationList = new List<PopupInfo>();
    public List<QuestDetail> sUpdateQuestList = new List<QuestDetail>();
    public List<int> sMemberDFList = new List<int>();

    private EControler eControl;
    private int iRareAnim;
    private int iAutoPickBomb;
    private int iUseContainerItem;
    private Coroutine sNoticeCoroutine;

    public ShopGachaLot sGachaLotResult;
    public List<NoticeInfo> NoticeInfoList = new List<NoticeInfo>();
    private Dictionary<int, int> cntNoticeInfo = new Dictionary<int, int>();

    private int iServerDay;
    private float fLocalTimeSec;
    private DateTime sReceiveServerTime;
    private DialogCommon dialog;

    private bool isOpendHardMode;
    private bool isHardMode;
    private List<PartyCharaData> partyCharaDataList_Player = new List<PartyCharaData>();
    public int iLeaderID;

    private static readonly string[] sFlagKey = new string[0];
    private Dictionary<EFlag, List<byte>> sFlagDic = new Dictionary<EFlag, List<byte>>();

    private MiniRankingI m_minirankingi;
    private DegreeInfo m_degreeInfo;

    private float m_fServerTimeRealtime;

    public static GameStateManager Instance
    {
        get
        {
            if (sInstance == null)
            {
                GameObject obj = new GameObject("GameStateManager");
                sInstance = obj.AddComponent<GameStateManager>();
                DontDestroyOnLoad(obj);
            }
            return sInstance;
        }
    }

    public DateTime sServerTime
    {
        get
        {
            float elapsed = Time.realtimeSinceStartup - m_fServerTimeRealtime;
            return sReceiveServerTime.AddSeconds(elapsed);
        }
    }

    public bool IsOpendHardMode
    {
        get => isOpendHardMode;
        set => isOpendHardMode = value;
    }

    public bool IsHardMode
    {
        get => isHardMode;
        set => isHardMode = value;
    }

    public int Mana => GetWealth(1);
    public int Call => GetWealth(2);
    public int Spoon => GetWealth(3);
    public int ReviveTicket => GetWealth(4);

    public InventoryList Inventory
    {
        get => sInventory;
        set => sInventory = value;
    }

    public string UserName
    {
        get => sUserName;
        set => sUserName = value;
    }

    public bool IsMemberIn { get; set; }

    public eStrategyKind Strategy { get; set; } = eStrategyKind.eFullPower;

    public bool TimeScale
    {
        get => Time.timeScale > 1f;
        set => Time.timeScale = value ? 2f : 1f;
    }

    public EControler ControlType
    {
        get => eControl;
        set => eControl = value;
    }

    public bool RareItemAnim
    {
        get => iRareAnim != 0;
        set => iRareAnim = value ? 1 : 0;
    }

    public bool AutoPickBomb
    {
        get => iAutoPickBomb != 0;
        set => iAutoPickBomb = value ? 1 : 0;
    }

    public bool UseContainerItem
    {
        get => iUseContainerItem != 0;
        set => iUseContainerItem = value ? 1 : 0;
    }

    private void Awake()
    {
        if (sInstance != null && sInstance != this)
        {
            Destroy(gameObject);
            return;
        }

        sInstance = this;
        if (transform.parent == null) DontDestroyOnLoad(gameObject);

        iScreenWidth = Screen.width;
        iScreenHeight = Screen.height;
        eResolution = (EResolutionLevel)PlayerPrefs.GetInt("RESOLUTION_LEVEL", 2);
        SetResolution(eResolution);

        txRenderTexture = new RenderTexture(1280, 720, 24);
        Init();
    }

    public void SetResolution(EResolutionLevel level)
    {
        eResolution = level;
    }

    public int GetWealth(EWealthKind kind)
    {
        return GetWealth((int)kind);
    }

    public int GetWealth(int kind)
    {
        if (adWealth != null && adWealth.ContainsKey(kind))
        {
            return adWealth[kind];
        }
        return 0;
    }

    public int GetWealthCompensation(int kind)
    {
        if (adWealthCompensation != null && adWealthCompensation.ContainsKey(kind))
        {
            return adWealthCompensation[kind];
        }
        return 0;
    }

    public bool IsExistEventQuest()
    {
        if (sQuestStatusList == null) return false;
        return false;
    }

    public void SetServerTime(string time)
    {
        if (DateTime.TryParse(time, out DateTime parsedTime))
        {
            sReceiveServerTime = parsedTime;
            m_fServerTimeRealtime = Time.realtimeSinceStartup;
        }
    }

    public bool IsOverServerTime(DateTime time)
    {
        return sServerTime >= time;
    }

    public void UpdateFieldDate()
    {
        iServerDay++;
    }

    public int GetNowFieldDate()
    {
        return iServerDay;
    }

    public bool IsChangedFieldDate()
    {
        return false;
    }

    public void ModifyResponseData(ResponseDataCommon res)
    {
        if (res == null) return;
    }

    public string GetLockQuestIdStringList(EQuestGroup group)
    {
        return string.Empty;
    }

    public void UpdateQuestGuide() { }
    public void SetActiveQuestGuide(bool active) { }
    public void SetQuestGuideText(EQuestGroup group, string text) { }

    private void RegistPopup(ResponseDataCommon res) { }

    public bool DispAnyQuestAcheive() => vPopupList != null && vPopupList.Count > 0;
    public bool DispAnyMemberIn() => IsMemberIn;
    public bool IsExistDispAnyPopup() => vPopupList != null && vPopupList.Count > 0;

    public bool DispAnyPopup(Action<EButtonKind> onExit = null)
    {
        if (vPopupList != null && vPopupList.Count > 0)
        {
            vPopupList.RemoveAt(0);
            return true;
        }
        return false;
    }

    public bool IsExistDispAnyGuide() => vGuideList != null && vGuideList.Count > 0;

    public bool DispAnyGuide()
    {
        if (vGuideList != null && vGuideList.Count > 0)
        {
            vGuideList.RemoveAt(0);
            return true;
        }
        return false;
    }

    public bool IsExistDispAnyInformation() => vInformationList != null && vInformationList.Count > 0;

    public bool DispAnyInformation()
    {
        if (vInformationList != null && vInformationList.Count > 0)
        {
            vInformationList.RemoveAt(0);
            return true;
        }
        return false;
    }

    public void DispAllNotice(bool achieve = false) => StartCoroutine(_DispAllNotice(achieve));
    public bool IsDispAllNotice() => sNoticeCoroutine != null;

    [DebuggerHidden]
    private IEnumerator _DispAllNotice(bool achieve)
    {
        yield return null;
        sNoticeCoroutine = null;
    }

    public static List<PartyCharaData> GetPartyCharaDataList()
    {
        return Instance != null ? Instance.partyCharaDataList_Player : null;
    }

    public static MakeCharaData GetPartyCharaMakeData(int df)
    {
        if (Instance != null && Instance.partyCharaDataList_Player != null)
        {
            foreach (var data in Instance.partyCharaDataList_Player)
            {
                // Sửa: Dùng data.DF và data.makeCharaData
                if (data != null && data.DF == df)
                {
                    return data.makeCharaData;
                }
            }
        }
        return null;
    }

    public static MakeCharaData GetMemberCharaMakeData(int df) => GetPartyCharaMakeData(df);

    public static MakeCharaData GetPlayerCharaMakeData()
    {
        return Instance != null ? GetPartyCharaMakeData(Instance.iLeaderID) : null;
    }

    public void ModifyPartyMember(CharaDetail detail, InventoryList inv) { }
    public void ModifyPartyInfo(ResponseDataCommon common) { }

    public PartyCharaData GetLeader()
    {
        if (partyCharaDataList_Player != null)
        {
            foreach (var chara in partyCharaDataList_Player)
            {
                // Sửa: Dùng chara.DF
                if (chara != null && chara.DF == iLeaderID)
                {
                    return chara;
                }
            }
            if (partyCharaDataList_Player.Count > 0)
            {
                return partyCharaDataList_Player[0];
            }
        }
        return null;
    }

    public void Init()
    {
        adWealth = new Dictionary<int, int>();
        adWealthCompensation = new Dictionary<int, int>();
        sFlagDic = new Dictionary<EFlag, List<byte>>();
        sReceiveServerTime = DateTime.UtcNow;
        m_fServerTimeRealtime = Time.realtimeSinceStartup;
    }

    public void ApplyEquipID(MakeCharaData chara, InventoryList inventoryList) { }

    public bool IsUnlockArea(int areaId)
    {
        if (sUnlockAreaList == null) return false;
        foreach (var area in sUnlockAreaList)
        {
            // Sửa: Dùng area.DF
            if (area != null && area.DF == areaId) return true;
        }
        return false;
    }

    public bool IsUnlockArea(List<int> areaIdList)
    {
        if (areaIdList == null) return false;
        foreach (var id in areaIdList)
        {
            if (!IsUnlockArea(id)) return false;
        }
        return true;
    }

    private bool IsAllAreaUnlockDebug() => false;

    public bool IsQuestStatus(int questDf, EQuestSTT stt)
    {
        if (sQuestStatusList == null) return false;
        foreach (var quest in sQuestStatusList)
        {
            // Sửa: Dùng quest.DF và quest.STT
            if (quest != null && quest.DF == questDf && quest.STT == (int)stt) return true;
        }
        return false;
    }

    public bool IsQuestStatus(List<int> questDfList, EQuestSTT stt)
    {
        if (questDfList == null) return false;
        foreach (var df in questDfList)
        {
            if (IsQuestStatus(df, stt)) return true;
        }
        return false;
    }

    public bool IsQuestChapterStatus(int chapter, EQuestSTT stt) => false;
    public bool IsOrderAdventQuest() => false;
    public bool IsOrderQuest(int df) => false;

    private void AddElement(EFlag kind)
    {
        if (!sFlagDic.ContainsKey(kind))
        {
            sFlagDic[kind] = new List<byte>();
        }
    }

    public void SetFlag(EFlag kind, byte value)
    {
        AddElement(kind);
        if (!sFlagDic[kind].Contains(value))
        {
            sFlagDic[kind].Add(value);
            SaveFlag(kind);
        }
    }

    public void RemoveFlag(EFlag kind, byte value)
    {
        if (sFlagDic.ContainsKey(kind))
        {
            sFlagDic[kind].Remove(value);
            SaveFlag(kind);
        }
    }

    public bool GetFlag(EFlag kind, byte value)
    {
        if (sFlagDic.TryGetValue(kind, out var list))
        {
            return list.Contains(value);
        }
        return false;
    }

    private void SaveFlag(EFlag kind) { }

    public void PlusCntNoticeInfo(int id)
    {
        if (cntNoticeInfo.ContainsKey(id)) cntNoticeInfo[id]++;
        else cntNoticeInfo[id] = 1;
    }

    public int GetCntNoticeInfo(int id)
    {
        return cntNoticeInfo.TryGetValue(id, out int count) ? count : 0;
    }

    public void setMiniRankingI(MiniRankingInfo mri) => m_minirankingi = new MiniRankingI(mri);

    public bool isMiniRankingTerm()
    {
        if (m_minirankingi == null) return false;
        DateTime now = sServerTime;
        return now >= m_minirankingi.m_clsStartTime && now <= m_minirankingi.m_clsEndTime;
    }

    public int getMinirankingWealth() => m_minirankingi != null ? m_minirankingi.m_wealth_df : 0;
    public int getMinirankingScore() => m_minirankingi != null ? m_minirankingi.m_iTotalScore : 0;

    public void setMinirankingScore(int score)
    {
        if (m_minirankingi != null) m_minirankingi.m_iTotalScore = score;
    }

    public string getMinirankingName() => m_minirankingi?.m_name;

    public bool isBoostChara(int charaDF)
    {
        return m_minirankingi?.charaDfs != null && m_minirankingi.charaDfs.Contains(charaDF);
    }

    public bool isBoostTime() => false;
    public double getReversal() => m_minirankingi != null ? m_minirankingi.m_iReversal : 0.0;

    public void setDegreeInfo(DegreeInfo di) => m_degreeInfo = di;

    // Sửa: Dùng di.DF và di.STP
    public int gsetDegreeDF() => m_degreeInfo != null ? m_degreeInfo.DF : 0;
    public int gsetDegreeStep() => m_degreeInfo != null ? m_degreeInfo.STP : 0;
}