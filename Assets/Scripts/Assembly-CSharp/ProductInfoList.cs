using System;
using System.Collections.Generic;

[Serializable]
public class ProductInfoList
{
	[Serializable]
	public class AgeRange4Product
	{
		public int ageClass;

		public int ageLowerLimit;

		public int ageUpperLimit;

		public int purchaseLimit;
	}

	public List<ProductInfo> productList;

	public List<AgeRange4Product> ageRangeList;

	public int monthlyPay;

	public List<ShopBanner> bannerList;

	public int ageClass;

	public int isRegisterAge;
}
