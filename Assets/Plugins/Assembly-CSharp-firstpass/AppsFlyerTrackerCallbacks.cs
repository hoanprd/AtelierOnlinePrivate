using UnityEngine;

public class AppsFlyerTrackerCallbacks : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	public void didReceiveConversionData(string conversionData)
	{
	}

	public void didReceiveConversionDataWithError(string error)
	{
	}

	public void didFinishValidateReceipt(string validateResult)
	{
	}

	public void didFinishValidateReceiptWithError(string error)
	{
	}

	public void onAppOpenAttribution(string validateResult)
	{
	}

	public void onAppOpenAttributionFailure(string error)
	{
	}

	public void onInAppBillingSuccess()
	{
	}

	public void onInAppBillingFailure(string error)
	{
	}

	public void onInviteLinkGenerated(string link)
	{
	}

	public void onOpenStoreLinkGenerated(string link)
	{
	}

	private void printCallback(string str)
	{
	}
}
