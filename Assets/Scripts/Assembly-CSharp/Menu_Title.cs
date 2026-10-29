using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Measurement;
using migrate;
using Tutorial;
using UnityEngine;

public class Menu_Title : Menu_Base
{
	[Serializable]
	public class UserName
	{
		public GameObject goRoot;

		public List<UILabel> vList;

		public void Init(string name)
		{
			if (vList != null)
			{
				for (int i = 0; i < vList.Count; i++)
				{
					if (vList[i] != null)
					{
						vList[i].text = string.Empty;
					}
				}
			}
			bool show = !string.IsNullOrEmpty(name) && PlayerPrefs.HasKey(GameDefine.sKEY_FIRST_GEN_CHOOSED);
			if (goRoot != null)
			{
				goRoot.SetActive(show);
			}
			if (vList == null || vList.Count == 0 || string.IsNullOrEmpty(name))
			{
				return;
			}
			string fullText = name + "のアトリエ";
			int len = Mathf.Min(fullText.Length, vList.Count);
			List<UILabel> sub = vList.GetRange(0, len);
			sub.Sort(delegate(UILabel a, UILabel b)
			{
				int na = ParseTrailingIndex(a);
				int nb = ParseTrailingIndex(b);
				return na - nb;
			});
			for (int j = 0; j < len; j++)
			{
				if (sub[j] != null)
				{
					sub[j].text = "[b]" + fullText[j];
				}
			}
		}

		private static int ParseTrailingIndex(UILabel lbl)
		{
			if (lbl == null || string.IsNullOrEmpty(lbl.name) || lbl.name.Length < 2)
			{
				return 0;
			}
			string tail = lbl.name.Substring(lbl.name.Length - 2, 2);
			if (int.TryParse(tail, out int val))
			{
				return val;
			}
			return 0;
		}
	}

	public enum eMainStep
	{
		First_Init = 0,
		First_Wait = 1,
		FadeI_Init = 2,
		FadeI_Wait = 3,
		ConfirmTerm_Init = 4,
		ConfirmTerm_Wait = 5,
		ServerInfo_Init = 6,
		ServerInfo_Wait = 7,
		HSPLogin_Send = 8,
		HSPLogin_Wait = 9,
		AuthError = 10,
		ServerStatus_Init = 11,
		ServerStatus_Wait = 12,
		ServerExchange_Init = 13,
		ServerExchange_Wait = 14,
		ServerOauth_Init = 15,
		ServerOauth_Wait = 16,
		ControlWait_Init = 17,
		ControlWait_Wait = 18,
		AuthCheck_Wait = 19,
		AuthCheck_End = 20,
		UserCreate_Wait = 21,
		UserCreate_End = 22,
		UserLogin_Wait = 23,
		UserLogin_End = 24,
		CharaEdit_Init = 25,
		CharaEdit_Wait = 26,
		CharaEdit = 27,
		CharaEdit_End = 28,
		AssetCheck_Init = 29,
		AssetCheck_Wait = 30,
		AssetUpdate_Init = 31,
		AssetUpdate_Confirm = 32,
		AssetUpdate_Start = 33,
		AssetUpdate_Wait = 34,
		AssetLoad_Wait = 35,
		TutorialSummary_Init = 36,
		TutorialSummary_Wait = 37,
		Dissemble_Init = 38,
		Dissemble_Wait = 39,
		FadeO_Init = 40,
		FadeO_Wait = 41,
		Tutorial_Field_Init = 42,
		Tutorial_Field_Wait = 43,
		End = 44,
		Error = 45,
		Refund_Waite = 46
	}

	private enum eRefundStatus
	{
		RefundDefault = 0,
		RefundWindow = 1,
		RefundNotExistWindow = 2
	}

	private static Menu_Title g_scrInst;

	public System_MenuManager.eSystemMenuKind m_eNextMenuKind;

	public bool m_bSelection;

	public UILabel m_sInfoLabel;

	[SerializeField]
	private UIGrid m_sButtonGrid;

	[SerializeField]
	private GameObject m_goDebugServerChange;

	[SerializeField]
	private GameObject m_goDebugNewGame;

	[SerializeField]
	private GameObject m_goLinkID;

	[SerializeField]
	private GameObject m_goTakeoverCode;

	[SerializeField]
	private UILabel m_sLoadInfo;

	[SerializeField]
	private GameObject m_goTitle;

	[SerializeField]
	private UserName m_sUserName;

	[SerializeField]
	private GameObject m_goContinueObj;

	[SerializeField]
	private GameObject m_goFirstObj;

	[SerializeField]
	private UILabel m_sUserID;

	[SerializeField]
	private UILabel m_sClientVersion;

	[SerializeField]
	private UILabel m_sGUID;

	[SerializeField]
	private UILabel m_sDecideName;

	[SerializeField]
	private UILabel m_sServerURL;

	[SerializeField]
	private SpawnPrefabData m_sCharaEdit;

	private CharaSelectManager m_sEdit;

	[SerializeField]
	private TitleMenuWindow m_sMenu;

	[SerializeField]
	private GameObject m_goMenuButton;

	[SerializeField]
	private List<AudioClip> m_vTitleCall;

	public eMainStep m_eMainStep;

	private eRaceKind m_eRaceKind;

	private bool m_bIsError;

	private AssetDownloader m_sAssetDownloader;

	private List<VersionData> m_vNowVersion;

	private List<VersionData> m_vDownloadList;

	private DialogCommon m_sDownloadConfirm;

	private bool m_bMakeChara;

	private TakeoverDialog m_sTakeoverDiag;

	private TakeoverCodeExecWindow m_sTakeoverExecWnd;

	private float m_fWaitTime;

	[SerializeField]
	private UIInput m_sInput;

	private const float cfDISP_OPENING_WAIT_TIME = 300f;

	private int m_iServer;

	[SerializeField]
	private RefundWindow m_refundWindow;

	[SerializeField]
	private UIWindowBase m_refundNotExistWindow;

	private eRefundStatus m_eRefund;

	public static Menu_Title GetInst()
	{
		return g_scrInst;
	}

	protected override void Awake()
	{
		g_scrInst = this;
		if (m_goLinkID != null)
		{
			m_goLinkID.SetActive(false);
		}
		if (m_goTakeoverCode != null)
		{
			m_goTakeoverCode.SetActive(false);
		}
		if (m_sUserName != null && m_sUserName.goRoot != null)
		{
			m_sUserName.goRoot.SetActive(false);
		}
		if (m_goDebugNewGame != null)
		{
			m_goDebugNewGame.SetActive(false);
		}
		if (m_goMenuButton != null)
		{
			m_goMenuButton.SetActive(false);
		}
		if (m_goDebugServerChange != null)
		{
			m_goDebugServerChange.SetActive(false);
		}
		if (m_sClientVersion != null)
		{
			m_sClientVersion.text = "Ver : " + GameDefine.csBundleVersion;
		}
	}

	protected override void OnDestroy()
	{
		if (m_sCharaEdit != null)
		{
			m_sCharaEdit.ReleaseInstance();
		}
		if (g_scrInst == this)
		{
			g_scrInst = null;
		}
	}

	public void OnContinue()
	{
		if (AuthenticationManager.GetSavedAuthType() == AuthenticationManager.AuthType.SIWA)
		{
			SIWAAuthentication inst = SIWAAuthentication.GetInstance();
			if (inst != null && !inst.isAuth())
			{
				AuthenticationManager.RestoreAuthType();
				m_eMainStep = eMainStep.HSPLogin_Send;
				return;
			}
		}
		if (!m_bSelection)
		{
			m_bSelection = true;
		}
	}

	public void OnServerChange()
	{
	}

	public void OnNewGame()
	{
		DialogCommon.CreateOKDialog("この機能は使用できません");
	}

	public void OnChaceClear()
	{
		DialogCommon.CreateYesNODialog("キャッシュをクリアします。\r\n実行しますか？\r\n(※セーブデータは削除されません)", delegate(EButtonKind result)
		{
			if (result == EButtonKind.eDECIDE)
			{
				LocalDirectory.DeleteCacheDirectory();
				if (GameStateManager.Instance != null)
				{
					GameStateManager.Instance.Init();
				}
				if (m_goContinueObj != null)
				{
					m_goContinueObj.SetActive(false);
				}
				m_bSelection = false;
				if (System_MenuManager.GetInst() != null)
				{
					System_MenuManager.GetInst().SetMenuRequest(System_MenuManager.eSystemMenuKind.Title, true, true);
				}
				PlayerPrefs.DeleteKey(GameDefine.sKEY_ALL_ASSET_DOWNLOAD);
			}
		});
	}

	public void OnTakeOver()
	{
		DialogCommon.CreateOKDialog("オフラインモードではID連携は不要です。");
	}

	public void OnTakeOverByCode()
	{
		DialogCommon.CreateOKDialog("オフラインモードでは引き継ぎは不要です。");
	}

	public void OnLogout()
	{
		DialogCommon.CreateYesNODialog("お客様の現在の端末から\r\nログアウトを実施しますか？\r\n\r\nアプリを利用中の端末を\r\n別の端末に切り替える際に\r\nご利用ください。\r\n\r\n※ログアウトしてもプレイ中のデータに影響はありません。", LogoutCallback);
	}

	private void LogoutCallback(EButtonKind button)
	{
		if (button == EButtonKind.eDECIDE)
		{
			NetworkManager.Logout(LogoutResponseCallback);
		}
	}

	private void LogoutResponseCallback(ResponseDataCommon res)
	{
		if (res != null && res.ERR == 0)
		{
			DialogCommon.CreateYesNODialog("ログアウトに成功しました。\r\nこのままアプリを終了しますか？", QuitDialogCallback);
		}
	}

	private void QuitDialogCallback(EButtonKind button)
	{
		if (button == EButtonKind.eDECIDE)
		{
			Application.Quit();
		}
	}

	public void OnMenu()
	{
		if (m_sMenu != null)
		{
			m_sMenu.Bringin();
		}
		if (m_refundWindow != null)
		{
			m_refundWindow.gameObject.SetActive(false);
		}
		if (m_refundNotExistWindow != null)
		{
			m_refundNotExistWindow.gameObject.SetActive(false);
		}
	}

	protected override void MenuUpdate()
	{
		if (System_MenuManager.GetInst() == null || !System_MenuManager.GetInst().IsDone)
		{
			return;
		}
		eMainStep nextStep = m_eMainStep;
		switch (m_eMainStep)
		{
		case eMainStep.First_Init:
			First_Init();
			nextStep = eMainStep.First_Wait;
			break;
		case eMainStep.First_Wait:
			if (First_Wait())
			{
				nextStep = eMainStep.FadeI_Init;
			}
			break;
		case eMainStep.FadeI_Init:
			SetSystemFadeIn();
			nextStep = eMainStep.FadeI_Wait;
			break;
		case eMainStep.FadeI_Wait:
			if (IsSystemFadeInEnd())
			{
				nextStep = eMainStep.ConfirmTerm_Init;
			}
			break;
		case eMainStep.ConfirmTerm_Init:
			if (!PlayerPrefs.HasKey(GameDefine.sKEY_AGREE_KTG_TERMS))
			{
				DialogTermOfService termsDialog = DialogTermOfService.Create();
				if (termsDialog != null)
				{
					termsDialog.Init(delegate(EButtonKind result)
					{
						if (result == EButtonKind.eDECIDE)
						{
							m_eMainStep = eMainStep.ServerInfo_Init;
							PlayerPrefs.SetInt(GameDefine.sKEY_AGREE_KTG_TERMS, 1);
							PlayerPrefs.Save();
						}
						else
						{
							m_eMainStep = eMainStep.FadeI_Wait;
						}
					}, PlayerPrefs.HasKey(GameDefine.sKEY_AGREE_TERMS));
					nextStep = eMainStep.ConfirmTerm_Wait;
				}
				else
				{
					PlayerPrefs.SetInt(GameDefine.sKEY_AGREE_KTG_TERMS, 1);
					PlayerPrefs.Save();
					nextStep = eMainStep.ServerInfo_Init;
				}
			}
			else
			{
				nextStep = eMainStep.ServerInfo_Init;
			}
			break;
		case eMainStep.ServerInfo_Init:
			NetworkManager.ServerInfo(delegate(ServerInfoResponse res)
			{
				if (UpdateApplication.IsNeed(res))
				{
					UpdateApplication.OpenStore();
				}
				else
				{
					ReceiveAPI(res);
				}
			});
			nextStep = eMainStep.ServerInfo_Wait;
			break;
		case eMainStep.HSPLogin_Send:
			if (string.IsNullOrEmpty(PlayerPrefs.GetString(GameDefine.sKEY_USERID, string.Empty)))
			{
				m_eMainStep = eMainStep.HSPLogin_Wait;
				AuthenticationManager.Authenticate(delegate(bool is_success)
				{
					if (is_success)
					{
						NetworkManager.UserCreate(string.Empty, m_eRaceKind, delegate(TitleUserCreateResponse response)
						{
							if (response != null && response.ERR == 0)
							{
								AuthenticationManager.SaveAuthType();
								if (m_sUserID != null && PlayerPrefs.HasKey(GameDefine.sKEY_USERID))
								{
									m_sUserID.text = "USER ID : " + PlayerPrefs.GetString(GameDefine.sKEY_USERID);
								}
								m_eMainStep = eMainStep.ServerStatus_Init;
							}
							else
							{
								m_eMainStep = eMainStep.AuthError;
							}
						});
					}
					else
					{
						m_eMainStep = eMainStep.AuthError;
					}
				});
			}
			else
			{
				m_eMainStep = eMainStep.HSPLogin_Wait;
				if (AuthenticationManager.IsLatestAuthVersion())
				{
					AuthenticationManager.Authenticate(delegate(bool is_success)
					{
						if (!is_success)
						{
							AuthenticationManager.TemporaryAuthenticate();
						}
						m_eMainStep = eMainStep.ServerStatus_Init;
					});
				}
				else
				{
					AuthenticationManager.OldVersionSupport(delegate(bool is_success)
					{
						if (!is_success)
						{
							AuthenticationManager.TemporaryAuthenticate();
						}
						m_eMainStep = eMainStep.ServerStatus_Init;
					});
				}
			}
			nextStep = m_eMainStep;
			break;
		case eMainStep.AuthError:
			DialogCommon.CreateOKDialog("ログインに失敗しました。\r\n再接続します。", delegate
			{
				m_eMainStep = eMainStep.HSPLogin_Send;
			});
			nextStep = eMainStep.HSPLogin_Wait;
			break;
		case eMainStep.ServerStatus_Init:
			MeasurementTool.Init();
			if (m_sInfoLabel != null)
			{
				m_sInfoLabel.text = "ログインしています";
			}
			NetworkManager.ServerStatus(ReceiveAPI);
			nextStep = eMainStep.ServerStatus_Wait;
			break;
		case eMainStep.ServerExchange_Init:
			if (m_sInfoLabel != null)
			{
				m_sInfoLabel.text = "変更しています";
			}
			NetworkManager.ExchangeUser(ReceiveAPI);
			nextStep = eMainStep.ServerExchange_Wait;
			break;
		case eMainStep.ServerOauth_Init:
			if (m_sInfoLabel != null)
			{
				m_sInfoLabel.text = "認証しています";
			}
			NetworkManager.OauthUser(delegate(ResponseDataCommon res)
			{
				if (res != null && res.ERR != 0)
				{
					AuthenticationManager.Failed(AuthenticationManager.GetAuthType(), delegate
					{
						m_eMainStep = eMainStep.HSPLogin_Send;
					});
				}
				else
				{
					ReceiveAPI(res);
				}
				if (res != null && res.USER != null && !string.IsNullOrEmpty(res.USER.URL))
				{
					if (m_sInfoLabel != null)
					{
						m_sInfoLabel.text = string.Empty;
					}
					m_eMainStep = eMainStep.Refund_Waite;
					if (string.IsNullOrEmpty(res.USER.PASS))
					{
						m_eRefund = eRefundStatus.RefundNotExistWindow;
						if (m_refundNotExistWindow != null)
						{
							m_refundNotExistWindow.Bringin();
						}
					}
					else
					{
						m_eRefund = eRefundStatus.RefundWindow;
						if (m_refundWindow != null)
						{
							int wealth = (GameStateManager.Instance != null) ? GameStateManager.Instance.GetWealthCompensation(1) : 0;
							m_refundWindow.SetWindow(wealth, res.USER.CD, res.USER.PASS, res.USER.URL);
							m_refundWindow.Bringin();
						}
					}
				}
			});
			nextStep = eMainStep.ServerOauth_Wait;
			break;
		case eMainStep.ControlWait_Init:
			if (m_goMenuButton != null)
			{
				m_goMenuButton.SetActive(true);
			}
			if (m_sButtonGrid != null)
			{
				m_sButtonGrid.Reposition();
			}
			if (m_goLinkID != null)
			{
				m_goLinkID.SetActive(!PlayerPrefs.HasKey(GameDefine.sKEY_USERID));
			}
			if (m_goTitle != null)
			{
				m_goTitle.SetActive(true);
			}
			if (m_sButtonGrid != null)
			{
				m_sButtonGrid.Reposition();
			}
			m_bMakeChara = false;
			m_bIsError = false;
			m_fWaitTime = 0f;
			SetCover(false);
			if (m_sInfoLabel != null)
			{
				m_sInfoLabel.text = string.Empty;
			}
			if (Sound_Manager.GetInst() != null && m_vTitleCall != null && m_vTitleCall.Count > 0)
			{
				AudioClip callClip = m_vTitleCall[UnityEngine.Random.Range(0, m_vTitleCall.Count)];
				if (callClip != null)
				{
					Sound_Manager.GetInst().PlaySound_AudioClip(callClip);
				}
			}
			nextStep = eMainStep.ControlWait_Wait;
			break;
		case eMainStep.ControlWait_Wait:
			if (!m_bSelection)
			{
				bool menuOpen = m_sMenu != null && m_sMenu.gameObject.activeSelf;
				if (!menuOpen && m_sTakeoverDiag == null && m_sTakeoverExecWnd == null)
				{
					m_fWaitTime += Time.deltaTime;
					if (m_fWaitTime > cfDISP_OPENING_WAIT_TIME)
					{
						if (Sound_Manager.GetInst() != null)
						{
							Sound_Manager.GetInst().StopMusic(true);
						}
						if (System_MenuManager.GetInst() != null)
						{
							System_MenuManager.GetInst().SetMenuRequest(System_MenuManager.eSystemMenuKind.Opening, true, true, true);
						}
						nextStep = eMainStep.End;
					}
				}
				else
				{
					m_fWaitTime = 0f;
				}
			}
			else
			{
				if (m_goTitle != null)
				{
					m_goTitle.SetActive(false);
				}
				nextStep = eMainStep.AuthCheck_End;
			}
			break;
		case eMainStep.AuthCheck_End:
			if (!string.IsNullOrEmpty(PlayerPrefs.GetString(GameDefine.sKEY_USERNAME, string.Empty)) && Sound_Manager.GetInst() != null)
			{
				Sound_Manager.GetInst().PlaySound((eSoundID)94);
			}
			nextStep = eMainStep.UserCreate_End;
			break;
		case eMainStep.UserCreate_End:
			NetworkManager.Login(ReceiveAPI);
			nextStep = eMainStep.UserLogin_Wait;
			break;
		case eMainStep.UserLogin_End:
			LoadingManager.Enable(0.5f);
			nextStep = PlayerPrefs.HasKey(GameDefine.sKEY_FIRST_GEN_CHOOSED) ? eMainStep.AssetCheck_Init : eMainStep.CharaEdit_Init;
			break;
		case eMainStep.CharaEdit_Init:
			if (LoadingManager.IsBlackOut)
			{
				nextStep = eMainStep.CharaEdit_Wait;
			}
			break;
		case eMainStep.CharaEdit_Wait:
			NetworkManager.SalonInfo(delegate(SalonInfoResponse res)
			{
				if (res == null || res.ERR != 0)
				{
					m_bIsError = true;
					m_eMainStep = eMainStep.Error;
					return;
				}
				if (res.API != null && res.API.MAKE != null && res.API.MAKE.GEN > 0)
				{
					m_eMainStep = eMainStep.CharaEdit_End;
					if (Sound_Manager.GetInst() != null)
					{
						Sound_Manager.GetInst().PlaySound((eSoundID)94);
					}
					return;
				}
				m_bMakeChara = true;
				LoadingManager.Disable(0.5f);
				MasterData.LoadLocalAssetBundle();
				if (m_sCharaEdit != null)
				{
					m_sCharaEdit.m_trRoot = SingletonBase<Game_UI_Common>.Instance.transform;
					m_sEdit = m_sCharaEdit.GetObject<CharaSelectManager>();
				}
				if (res.API != null && res.API.MAKE != null && string.IsNullOrEmpty(res.API.MAKE.NAME))
				{
					res.API.MAKE.NAME = GameUtil.MakeUserName();
				}
				if (m_sEdit != null)
				{
					m_sEdit.Init(res.API);
				}
				else
				{
					PlayerPrefs.SetInt(GameDefine.sKEY_FIRST_GEN_CHOOSED, 1);
					PlayerPrefs.Save();
					m_eMainStep = eMainStep.CharaEdit_End;
				}
			});
			nextStep = eMainStep.CharaEdit;
			break;
		case eMainStep.CharaEdit:
			if (!NetworkManager.IsExec() && m_sEdit != null && m_sEdit.IsFinish && !m_bIsError)
			{
				LoadingManager.Enable(0.5f);
				nextStep = eMainStep.CharaEdit_End;
			}
			break;
		case eMainStep.CharaEdit_End:
			PlayerPrefs.SetInt(GameDefine.sKEY_FIRST_GEN_CHOOSED, 1);
			nextStep = eMainStep.AssetCheck_Init;
			break;
		case eMainStep.AssetCheck_Init:
			AssetBundleManager.UnloadAll();
			m_vNowVersion = AssetBundleManager.LoadVersionInfoLocal();
			AssetVersionChecker.Request();
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
			nextStep = eMainStep.AssetCheck_Wait;
			break;
		case eMainStep.AssetCheck_Wait:
			if (AssetVersionChecker.IsEnd)
			{
				if (AssetVersionChecker.Result == EDownloadResult.eNONE || AssetVersionChecker.Result == EDownloadResult.eSUCCESS)
				{
					if (m_sInfoLabel != null)
					{
						m_sInfoLabel.text = string.Empty;
					}
					nextStep = eMainStep.AssetUpdate_Init;
				}
				else
				{
					nextStep = eMainStep.Error;
					DialogCommon.CreateOKDialog("ファイルがダウンロードできませんでした。\r\n再接続します。", delegate
					{
						m_eMainStep = eMainStep.AssetCheck_Init;
					});
				}
			}
			break;
		case eMainStep.AssetUpdate_Init:
			m_vDownloadList = AssetBundleManager.GetLaunchUpdateFiles(m_vNowVersion);
			if (m_vDownloadList == null)
			{
				m_vDownloadList = new List<VersionData>();
			}
			if (m_bMakeChara)
			{
				List<VersionData> firstList = AssetBundleManager.GetList(EAssetDownloadTiming.eFIRST);
				if (firstList != null)
				{
					m_vDownloadList.AddRange(firstList);
				}
				LoadingManager.Enable(0.5f);
				LoadingManager.SetDownload(true);
				nextStep = eMainStep.AssetUpdate_Start;
				break;
			}
			if (m_vDownloadList.Count < 1)
			{
				LoadingManager.SetDownload(true);
				LoadingManager.Enable(0.5f);
				nextStep = eMainStep.AssetUpdate_Start;
			}
			else
			{
				long totalSize = 0L;
				for (int i = 0; i < m_vDownloadList.Count; i++)
				{
					if (m_vDownloadList[i] != null)
					{
						totalSize += m_vDownloadList[i].size;
					}
				}
				string sizeText = Util.GetFileSizeText(totalSize);
				m_sDownloadConfirm = DialogCommon.CreateForceYesNODialog("更新データがあります", "約" + sizeText + "の更新データがあります。\r\nダウンロードを開始しますか？\r\n\r\n※Wi-Fi環境推奨", delegate(EButtonKind result)
				{
					if (result == EButtonKind.eDECIDE)
					{
						LoadingManager.SetDownload(true);
						LoadingManager.Enable(0.5f);
						m_eMainStep = eMainStep.AssetUpdate_Start;
					}
					else
					{
						m_bSelection = false;
						m_bIsError = false;
						LoadingManager.Disable(0.5f);
						m_eMainStep = eMainStep.ControlWait_Init;
					}
				});
				nextStep = eMainStep.AssetUpdate_Confirm;
			}
			break;
		case eMainStep.AssetUpdate_Start:
			if (LoadingManager.IsBlackOut)
			{
				m_sAssetDownloader = base.gameObject.AddComponent<AssetDownloader>();
				m_sAssetDownloader.Execute(m_vDownloadList, 3);
				nextStep = eMainStep.AssetUpdate_Wait;
			}
			break;
		case eMainStep.AssetUpdate_Wait:
			if (m_sAssetDownloader != null)
			{
				float prog = m_sAssetDownloader.Progress;
				LoadingManager.SetProgress(prog, "FILE CHECK..." + prog.ToString("P"));
				if (!m_sAssetDownloader.IsEnd)
				{
					return;
				}
				if (m_sAssetDownloader.IsError)
				{
					m_eMainStep = eMainStep.Error;
					DialogCommon.CreateOKDialog("ファイルがダウンロードできませんでした。\r\n再接続します。", delegate
					{
						m_eMainStep = eMainStep.AssetCheck_Init;
					});
					UnityEngine.Object.Destroy(m_sAssetDownloader);
					return;
				}
				UnityEngine.Object.Destroy(m_sAssetDownloader);
			}
			m_vDownloadList = new List<VersionData>();
			if (AssetBundleManager.sInstance != null && AssetBundleManager.sInstance.m_sVersionHeader != null)
			{
				for (int j = 0; j < AssetBundleManager.sInstance.m_sVersionHeader.Count; j++)
				{
					VersionList vl = AssetBundleManager.sInstance.m_sVersionHeader[j];
					if (vl != null && vl.list != null)
					{
						m_vDownloadList.AddRange(vl.list.FindAll((VersionData x) => x != null && x.path != null && x.path.IndexOf("Master") == 0));
					}
				}
			}
			for (int k = 0; k < m_vDownloadList.Count; k++)
			{
				AssetBundleManager.Load(m_vDownloadList[k]);
			}
			nextStep = eMainStep.AssetLoad_Wait;
			break;
		case eMainStep.AssetLoad_Wait:
		{
			if (m_sInfoLabel != null)
			{
				m_sInfoLabel.text = string.Empty;
			}
			float loadProg = (m_vDownloadList != null && m_vDownloadList.Count > 0) ? (1f - (float)AssetBundleManager.ReqCount / (float)m_vDownloadList.Count) : 1f;
			LoadingManager.SetProgress(loadProg, "FILE LOADING..." + loadProg.ToString("P"));
			if (!AssetBundleManager.IsLoadAll())
			{
				return;
			}
			if (m_sInfoLabel != null)
			{
				m_sInfoLabel.text = string.Empty;
			}
			if (MasterData.LoadAssetBundle())
			{
				nextStep = eMainStep.TutorialSummary_Init;
			}
			else
			{
				DialogCommon.CreateOKDialog("起動に必要なファイルがありません\r\n再ダウンロードします", delegate
				{
					m_eMainStep = eMainStep.AssetCheck_Init;
				});
				nextStep = eMainStep.Error;
			}
			Screen.sleepTimeout = SleepTimeout.SystemSetting;
			AssetBundleManager.SaveVersionInfo();
			break;
		}
		case eMainStep.TutorialSummary_Init:
			NetworkManager.TutorialSummary(delegate(ResponseDataCommon res)
			{
				SingletonBase<TutorialManager>.Instance.SetAllFlag(false);
				if (res != null && res.TUTO != null && res.TUTO.LIST != null)
				{
					for (int l = 0; l < res.TUTO.LIST.Length; l++)
					{
						TutorialStatus ts = res.TUTO.LIST[l];
						if (ts != null)
						{
							SingletonBase<TutorialManager>.Instance.SetFlag_DF(ts.DF, ts.FIN == 1);
						}
					}
					if (PlayerPrefs.HasKey(GameDefine.sKEY_IGNORE_TUTORIAL))
					{
						for (int m = 0; m < 30; m++)
						{
							SingletonBase<TutorialManager>.Instance.SetFlag((eTutorial)m, true);
						}
						SingletonBase<TutorialManager>.Instance.SetFlag((eTutorial)45, true);
					}
				}
			});
			nextStep = eMainStep.TutorialSummary_Wait;
			break;
		case eMainStep.TutorialSummary_Wait:
			if (!NetworkManager.IsExec())
			{
				Game_MA_GateManager.Init();
				nextStep = PlayerPrefs.HasKey(GameDefine.sKEY_DISASSEMBLE_VALUE) ? eMainStep.Dissemble_Init : eMainStep.FadeO_Init;
			}
			break;
		case eMainStep.Dissemble_Init:
		{
			string json = PlayerPrefs.GetString(GameDefine.sKEY_DISASSEMBLE_VALUE, string.Empty);
			APIHomeShopGachaDisassemble.Request req = (!string.IsNullOrEmpty(json)) ? JsonUtility.FromJson<APIHomeShopGachaDisassemble.Request>(json) : null;
			if (req != null)
			{
				NetworkManager.GachaDisassemble(req.DF, req.LOT, ReceiveAPI);
				nextStep = eMainStep.Dissemble_Wait;
			}
			else
			{
				nextStep = eMainStep.FadeO_Init;
			}
			break;
		}
		case eMainStep.FadeO_Init:
			SetSystemBlackOut();
			nextStep = eMainStep.FadeO_Wait;
			break;
		case eMainStep.FadeO_Wait:
			if (IsSystemBlackOutEnd())
			{
				nextStep = InitNextScene();
			}
			break;
		case eMainStep.Tutorial_Field_Init:
			NetworkManager.HomeEnter(OnHomeEnter);
			nextStep = eMainStep.Tutorial_Field_Wait;
			break;
		case eMainStep.Tutorial_Field_Wait:
			if (!NetworkManager.IsExec())
			{
				if (!m_bIsError)
				{
					SetChangeMenuRequest();
					nextStep = eMainStep.End;
				}
				else
				{
					m_bSelection = false;
					m_bIsError = false;
					LoadingManager.Disable(0.5f);
					nextStep = eMainStep.ControlWait_Init;
				}
			}
			break;
		case eMainStep.Refund_Waite:
			if (m_eRefund == eRefundStatus.RefundWindow)
			{
				if ((m_sMenu == null || !m_sMenu.gameObject.activeSelf) && m_refundWindow != null && !m_refundWindow.gameObject.activeSelf)
				{
					m_refundWindow.Bringin();
				}
			}
			else if (m_eRefund == eRefundStatus.RefundNotExistWindow && (m_sMenu == null || !m_sMenu.gameObject.activeSelf) && m_refundNotExistWindow != null && !m_refundNotExistWindow.gameObject.activeSelf)
			{
				m_refundNotExistWindow.Bringin();
			}
			break;
		}
		if (m_eMainStep != nextStep)
		{
			m_eMainStep = nextStep;
		}
	}

	private void ReceiveAPI<T>(T res) where T : ResponseDataCommon
	{
		if (res != null && res.ERR == 0)
		{
			m_eMainStep++;
		}
		else
		{
			m_bIsError = true;
			m_eMainStep = eMainStep.Error;
		}
	}

	private eMainStep InitNextScene()
	{
		TutorialManager tuto = SingletonBase<TutorialManager>.Instance;
		if (tuto.GetFlag((eTutorial)0))
		{
			if (!tuto.GetFlag((eTutorial)19))
			{
				int spawn = tuto.GetFlag((eTutorial)5) ? 1 : 0;
				Game_MA_GateManager.RequestJump(99, 1, spawn);
				m_eNextMenuKind = System_MenuManager.eSystemMenuKind.Field;
				return eMainStep.Tutorial_Field_Init;
			}
			if (tuto.GetFlag((eTutorial)27) && !tuto.GetFlag((eTutorial)28))
			{
				Game_MA_GateManager.RequestJump(1, 1, 0);
				m_eNextMenuKind = System_MenuManager.eSystemMenuKind.Field;
				return eMainStep.Tutorial_Field_Init;
			}
		}
		m_eNextMenuKind = System_MenuManager.eSystemMenuKind.Academy;
		SetChangeMenuRequest();
		return eMainStep.End;
	}

	private void OnHomeEnter(HomeEnterResponse res)
	{
		if (res == null || res.ERR > 0)
		{
			m_bIsError = true;
		}
	}

	private void First_Init()
	{
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlayMusic(eMusicID.Title, true, 0f, false);
		}
		if (m_goTitle != null)
		{
			m_goTitle.SetActive(false);
		}
		if (m_sInput != null)
		{
			m_sInput.defaultText = GameUtil.MakeUserName();
		}
		if (m_sUserName != null)
		{
			m_sUserName.Init(PlayerPrefs.GetString(GameDefine.sKEY_USERNAME, string.Empty));
		}
		if (m_sUserID != null)
		{
			m_sUserID.text = (PlayerPrefs.HasKey(GameDefine.sKEY_USERID) ? ("USER ID : " + PlayerPrefs.GetString(GameDefine.sKEY_USERID)) : string.Empty);
		}
		if (ExtraQuestManager.Instance != null)
		{
			ExtraQuestManager.Instance.ActivateCollider(false);
		}
		if (m_goDebugNewGame != null)
		{
			m_goDebugNewGame.SetActive(false);
		}
		if (m_goDebugServerChange != null)
		{
			m_goDebugServerChange.SetActive(false);
		}
		if (m_goMenuButton != null)
		{
			m_goMenuButton.SetActive(false);
		}
		if (m_sDecideName != null)
		{
			m_sDecideName.text = string.Empty;
		}
		if (m_sGUID != null)
		{
			m_sGUID.text = string.Empty;
		}
		if (m_sServerURL != null)
		{
			m_sServerURL.text = string.Empty;
		}
	}

	private bool First_Wait()
	{
		return true;
	}

	private void SetChangeMenuRequest()
	{
		if (System_MenuManager.GetInst() != null)
		{
			System_MenuManager.GetInst().SetMenuRequest(m_eNextMenuKind, false, false, true);
		}
	}

	[DebuggerHidden]
	private IEnumerator LoadMovie()
	{
		VersionData inv = AssetBundleManager.GetVersionInfo("Movie/opening");
		AssetBundleManager.Load(inv);
		while (!AssetBundleManager.IsLoad(inv))
		{
			yield return true;
		}
		AssetBundleManager.Get(inv);
	}
}
