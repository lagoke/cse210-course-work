// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }


using System;


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


	public string SetStreet()
	{
		return _street;
	}



	public string GetCity()
	{
		return _city;
	}


	public string SetCity()
	{
		return _city;
	}



	public string GetState()
	{
		return _stateOrProvince;
	}


	public string SetState()
	{
		return _stateOrProvince;
	}



	public string GetCountry()
	{
		return _country;
	}


	public string SetCountry()
	{
		return _country;
	}




	public string FullAddress()
    {

		return _street + _city + _stateOrProvince + _country;
	}



	public bool CheckCountryUSA(bool USA)
	{
		bool country = USA;

		return country;
	}


}



public class Customer
{
	public Customer()
	{
	}

	private string _name;
	Address addressObject;

	public string GetName()
	{
		return _name;
	}


	public string SetName()
	{
		return _name;
	}



	public bool CheckCountryUSA(bool USA)
	{
		bool country = USA;

		return country;
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


	public string SetPakingLabel()
	{
		return _pakingLabel;
	}


	public string GetShippingLabel()
	{
		return _shippingLabel;
	}


	public string SetShippingLabel()
	{
		return _shippingLabel;
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


	public string SetName()
	{
		return _name;
	}





	public string GetProductID()
	{
		return _productID;
	}


	public string SetProductID()
	{
		return _productID;
	}





	public float GetPrice()
	{
		return _price;
	}


	public float SetPrice()
	{
		return _price;
	}



	public int GetQuantity()
	{
		return _quantity;
	}


	public int SetQuantity()
	{
		return _quantity;
	}



	public float CalculateProductPrice(float pprice)
	{
		float productPrice = pprice;

		return productPrice;
	}








}

    













    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
    }
