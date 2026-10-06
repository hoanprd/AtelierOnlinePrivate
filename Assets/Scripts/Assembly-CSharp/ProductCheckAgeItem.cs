using UnityEngine;

public class ProductCheckAgeItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sAge;

	[SerializeField]
	private UILabel m_sContent;

	private ProductInfoList.AgeRange4Product m_sInfo;

	public ProductInfoList.AgeRange4Product Info
	{
		get
		{
			return null;
		}
	}

	public string AgeText
	{
		get
		{
			return null;
		}
	}

	public void Init(ProductInfoList.AgeRange4Product info)
	{
	}
}
