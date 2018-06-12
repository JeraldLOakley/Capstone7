using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Capstone7ProductAPI.Models;
namespace Capstone7ProductAPI.Controllers
{
	public class ValuesController : ApiController
	{
		public Product GetProduct(int id)
		{
			NorthwindEntities db = new NorthwindEntities();
			Product prod = (from p in db.Products where p.ProductID == id select p).Single();
			return prod;
		}

		public List<Products> GetProduct()
		{
			NorthwindEntities db = new NorthwindEntities();

			List<Product> prod = db.Products.ToList();
			List<Products> products = new List<Products>();

			for (int i = 0; i < prod.Count; i++)
			{
				products.Add(new Products(prod[i].ProductID, prod[i].ProductName));
			}


			return products;

		}



	}


}
