using System;

namespace OnlineOrdering
{




public class Address
{
	public Address()
	{

    }

	private string _street;
	private string _city;
	private string _stateOrProvince;
	private string _country;


	public string GetStreet()
	{
		return _street;
	}


	public void SetStreet(string Street)
	{
		_street = Street;
	}



	public string GetCity()
	{
		return _city;
	}


	public void SetCity(string City)
	{
		_city = City;
	}




	public string GetState()
	{
		return _stateOrProvince;
	}


	public void SetState(string State)
	{
		_stateOrProvince = State;
	}



	public string GetCountry()
	{
		return _country;
	}


	public void SetCountry(string Country)
	{
		_country = Country;
	}




	public string FullAddress()
    {

		return _street + "," + _city + "," + _stateOrProvince + "," + _country;
	}



	public string CheckCountryUSA(string county)
	{
		string country_passed = county;
		//string country_spplied;

		/*
			if (country_passed == "USA" || country_passed == "usa")
			{
				string country_spplied = "USA";
				bool checkCountry = true;

			}

			*/

		return country_passed;

	}


}







public class Customer
{
	public Customer()
	{
	}

	private string _name;


	public string GetName()
	{
		return _name;
	}


	public void SetName(string Name)
	{
		_name = Name;
	}




}






public class Order
{
	public Order()
	{

	}

	private string _pakingLabel;
	private string _shippingLabel;
	private float _shippingCost;


	public string GetPakingLabel()
	{
		return _pakingLabel;
	}


	public void SetPakingLabel(string parklabel)
	{
		_pakingLabel = parklabel;
	}




	public string GetShippingLabel()
	{
		return _shippingLabel;
	}


	public void SetShippingLabel(string shoplabel)
	{
		_shippingLabel = shoplabel;
	}



	public float CalculateShippingCost(float shipcost)
	{
		float shippingCost = shipcost;
		
		return shippingCost;
	}



	public float TotalOderPrice(float ordeprice)
	{
		float orderPriceValue = ordeprice;

		return orderPriceValue;
	}


}







public class Product
{
	public Product()
	{
	}


	private string _name;
	private string _productID;
	private float _price;
	private int _quantity;


	public string GetName()
	{
		return _name;
	}


	public void SetName(string Name)
	{
		_name = Name;
	}





	public string GetProductID()
	{
		return _productID;
	}


	public void SetProductID(string pID)
	{
		_productID = pID;
	}





	public float GetPrice()
	{
		return _price;
	}


	public void SetPrice(float pr)
	{
		_price = pr;
	}



	public int GetQuantity()
	{
		return _quantity;
	}


	public void SetQuantity(int qty)
	{
		_quantity = qty;
	}



	public float CalculateProductPrice()
	{
		float productPrice = _price * _quantity;

		return productPrice;
	}




}

    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("==========================");
            Console.WriteLine("Order Details");
            Console.WriteLine("==========================");


            //Create a sample product
            Console.WriteLine("==========================");
            Console.WriteLine("First Product");
            Console.WriteLine("==========================");

            Product p = new Product();
            p.SetName("Wrist Watch");
            p.SetProductID("001");
            p.SetPrice(100);
            p.SetQuantity(2);
            float calculatedPrice = p.CalculateProductPrice();

            Console.WriteLine("Product Name: " + p.GetName() + "\n");
            Console.WriteLine("Product ID: " + p.GetProductID() + "\n");
            Console.WriteLine("Product Price: " + p.GetPrice() + "\n");
            Console.WriteLine("Product Quantity: " + p.GetQuantity() + "\n");
            Console.WriteLine("Calculated Price: " + calculatedPrice + "\n");

            //Console.WriteLine("\n");

            Console.WriteLine("==========================");
            Console.WriteLine("Secod Product");
            Console.WriteLine("==========================");



            //Create another sample product

            Product p2 = new Product();
            p2.SetName("Android Phone");
            p2.SetProductID("002");
            p2.SetPrice(1200);
            p2.SetQuantity(3);
            float calculatedPrice2 = p2.CalculateProductPrice();

            Console.WriteLine("Product Name: " + p2.GetName() + "\n");
            Console.WriteLine("Product ID: " + p2.GetProductID() + "\n");
            Console.WriteLine("Product Price: " + p2.GetPrice() + "\n");
            Console.WriteLine("Product Quantity: " + p2.GetQuantity() + "\n");
            Console.WriteLine("Calculated Price: " + calculatedPrice2 + "\n");



            // Console.WriteLine("==========================");
            Console.WriteLine("Customer Information");
            Console.WriteLine("==========================");

            //Add a Customer
            Customer c1 = new Customer();
            c1.SetName("Olagoke Amiola");

            //Supply customer address via the Address class
            Address a1 = new Address();
            a1.SetStreet("Broad street");
            a1.SetCity("Darlington");
            a1.SetState("New York");
            a1.SetCountry("USA");

           string customerAddress = a1.FullAddress();
            string checkCountryResult = a1.CheckCountryUSA(a1.GetCountry());

            Console.WriteLine("Customer Name: " + p2.GetName() + "\n");
            Console.WriteLine("Customer Address: " + customerAddress + "\n");


            Console.WriteLine("Total Price:");
            Console.WriteLine("==========================");

            float accumulatedPrice = calculatedPrice + calculatedPrice2;

            //Determine the one-time shopping cost and calculate 

           
            if(checkCountryResult == "USA" || checkCountryResult == "usa")
            {
                float oneTimeShop = 5;
                float totalPrice = accumulatedPrice + oneTimeShop;
                Console.WriteLine("Grand Total Price : " + totalPrice + "\n");

            }

            else
            {
                float oneTimeShop = 35;
                float totalPrice = accumulatedPrice + oneTimeShop;
                Console.WriteLine("Grand Total Price : " + totalPrice + "\n");
            }




            Console.WriteLine("Parking Label:");
            Console.WriteLine("==========================");

            Console.WriteLine("Product Name: " + p2.GetName() + "\n");
            Console.WriteLine("Product ID: " + p2.GetProductID() + "\n");

            Console.WriteLine("Product Name: " + p2.GetName() + "\n");
            Console.WriteLine("Product ID: " + p2.GetProductID() + "\n");


            Console.WriteLine("Shipping Label:");
            Console.WriteLine("==========================");

            Console.WriteLine("Customer Name: " + p2.GetName() + "\n");
            Console.WriteLine("Customer Address: " + customerAddress + "\n");




        }
    }
}
