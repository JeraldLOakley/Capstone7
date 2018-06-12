using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone7ProductAPI.Models
{
	public class Products
	{
		int productID;

		string productName;

		public Products(int productID, string productName)
		{
			ProductID = productID;
			ProductName = productName;
		}

		public int ProductID { get => productID; set => productID = value; }
		public string ProductName { get => productName; set => productName = value; }
	}
}