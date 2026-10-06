using System;
using System.Collections.Generic;
using UnityEngine;

public class AppsFlyer : MonoBehaviour
{
	public enum EmailCryptType
	{
		EmailCryptTypeNone = 0,
		EmailCryptTypeSHA1 = 1,
		EmailCryptTypeMD5 = 2,
		EmailCryptTypeSHA256 = 3
	}

	private static AndroidJavaClass obj;

	private static AndroidJavaObject cls_AppsFlyer;

	private static AndroidJavaClass propertiesClass;

	private static AndroidJavaClass cls_AppsFlyerHelper;

	private static string devKey;

	private static AndroidJavaClass cls_UnityShareHelper;

	private static AndroidJavaObject ShareHelperInstance;

	private static AndroidJavaClass cls_AndroidShare;

	public static void setCurrencyCode(string currencyCode)
	{
	}

	public static void setCustomerUserID(string customerUserID)
	{
	}

	public static void loadConversionData(string callbackObject)
	{
	}

	[Obsolete]
	public static void loadConversionData(string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	public static void setCollectIMEI(bool shouldCollect)
	{
	}

	public static void setCollectAndroidID(bool shouldCollect)
	{
	}

	public static void init(string key, string callbackObject)
	{
	}

	public static void init(string key)
	{
	}

	private static void init_cb()
	{
	}

	public static void setAppsFlyerKey(string key)
	{
	}

	public static void trackAppLaunch()
	{
	}

	public static void setAppID(string packageName)
	{
	}

	public static void createValidateInAppListener(string aObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	public static void validateReceipt(string publicKey, string purchaseData, string signature, string price, string currency, Dictionary<string, string> extraParams)
	{
	}

	public static void trackRichEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	private static AndroidJavaObject ConvertHashMap(Dictionary<string, string> dict)
	{
		return null;
	}

	public static void setImeiData(string imeiData)
	{
	}

	public static void setAndroidIdData(string androidIdData)
	{
	}

	public static void setIsDebug(bool isDebug)
	{
	}

	public static void setIsSandbox(bool isSandbox)
	{
	}

	public static void getConversionData()
	{
	}

	public static void handleOpenUrl(string url, string sourceApplication, string annotation)
	{
	}

	public static string getAppsFlyerId()
	{
		return null;
	}

	public static void setGCMProjectNumber(string googleGCMNumber)
	{
	}

	public static void updateServerUninstallToken(string token)
	{
	}

	public static void enableUninstallTracking(string senderId)
	{
	}

	public static void setDeviceTrackingDisabled(bool state)
	{
	}

	public static void setAdditionalData(Dictionary<string, string> extraData)
	{
	}

	public static void stopTracking(bool isStopTracking)
	{
	}

	public static void setAppInviteOneLinkID(string oneLinkID)
	{
	}

	public static void generateUserInviteLink(Dictionary<string, string> parameters, string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	public static void trackCrossPromoteImpression(string appId, string campaign)
	{
	}

	public static void trackAndOpenStore(string promotedAppId, string campaign, Dictionary<string, string> customParams)
	{
	}

	public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
	{
	}

	public static void setMinTimeBetweenSessions(int seconds)
	{
	}

	public static void setHost(string hostPrefixName, string hostName)
	{
	}

	public static string getHost()
	{
		return null;
	}

	public static void setUserEmails(EmailCryptType cryptType, params string[] userEmails)
	{
	}

	public static void setResolveDeepLinkURLs(params string[] userEmails)
	{
	}

	public static void setOneLinkCustomDomain(params string[] domains)
	{
	}
}
