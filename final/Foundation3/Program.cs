// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation3 World!");
//     }
// }

using System;
using System.Collections.Generic;


public class Address: Event
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





}



public class Event
{
	public Event()
	{

	}




	private string _title;
	private string _description;
	private string _date;
	private string _time;

	Address addressObject;



	public void GenerateStandardDetails()
    {


    }



	public void GenerateFullDetails()
	{


	}




	public void GenerateShortDescription()
	{


	}



}



public class Lectures : Event
{
	public Lectures()
	{
	}



	private string _speakerName;
	private string _capacity;


	public string GenerateLectureSummary()
	{
		return _speakerName + _capacity;

	}





}


public class Outdoors : Event
{
	public Outdoors()
	{
	}



	private string _statementOfWeather;


	public string GetWeatherStatement()
	{
		return _statementOfWeather;

	}



	public string SetWeatherStatement()
	{
		return _statementOfWeather;

	}


}

public class Reception : Event
{
	public Reception()
	{
	}

	private string _email;


	public string GetEmail()
	{
		return _email;

	}



	public string SetEmail()
	{
		return _email;

	}



}

// namespace EventPlanning
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//            // Console.WriteLine("Hello World!");
//         }
//     }
// }
