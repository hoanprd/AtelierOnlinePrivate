using System;

[Serializable]
public class ShopBanner
{
	public class Attribute
	{
		public BannerAttributeType TYPE;

		public int ID;
	}

	public string IMG;

	public string URL;

	public Attribute[] ATTRS;
}
