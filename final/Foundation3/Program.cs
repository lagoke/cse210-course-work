using System;

namespace EventPlanning
{


// using System;

public class Event
{

	private string _title;
	private string _description;
	private string _date;
	private string _time;

	//Address addressObject;


	public Event(string title, string description, string date, string time)
	{
		_title = title;
		_description = description;
		_date = date;
		_time = time;
	}



	public string GetTitle()
	{
		return _title;
	}

	public string GetDescription()
	{
		return _description;
	}


	public string GetDate()
	{
		return _date;
	}


	public string GetTime()
	{
		return _time;
	}

	public string GenerateStandardDetails()
    {

		return _title + ","  + _description + "," + _date + "," + _time ;

	}



	public void GenerateFullDetails()
	{


	}




	public string GenerateShortDescription(string eventType)
	{

		return "Event type: " + eventType + ", " + "Title: " + _title + ", " + "Date: " + _date;
	}





}





public class Address
{

	private string _street;
	private string _city;
	private string _stateOrProvince;
	private string _country;

	public Address(string street, string city, string stateOrProvince, string country)
	{

		_street = street;
		_city = city;
		_stateOrProvince = stateOrProvince;
		_country = country;

	}



	public string GetStreet()
	{
		return _street;
	}




	public string GetCity()
	{
		return _city;
	}



	public string GetState()
	{
		return _stateOrProvince;
	}



	public string GetCountry()
	{
		return _country;
	}



	public string FullAddress()
	{

		return _street + "," + _city + "," + _stateOrProvince + ","  + _country;
	}





}







public class Lectures : Event
{

	private string _speakerName;
	private string _capacity;
	public Lectures(string title, string description, string date, string time, string speakerName, string capacity)
				: base(title, description, date, time)

	{

		_speakerName = speakerName;
		_capacity = capacity;


	}


	public string GenerateLectureSummary()
	{
		return _speakerName + "," + _capacity;

	}





}






public class Reception : Event
{

	private string _email;
	public Reception(string title, string description, string date, string time, string email)
				: base(title, description, date, time)
	{
		_email = email;
	}

	


	public string GetEmail()
	{
		return _email;

	}

	public string GenerateRSVPSummary()
	{
		return _email;

	}

}









public class Outdoors : Event
{
	private string _statementOfWeather;
	public Outdoors(string title, string description, string date, string time, string weatherState)
				: base(title, description, date, time)
	{

		_statementOfWeather = weatherState;
	}



	


	public string GetWeatherStatement()
	{
		return _statementOfWeather;

	}



	public string SetWeatherStatement()
	{
		return _statementOfWeather;

	}


}






    class Program
    {
        static void Main(string[] args)
        {
            // Create a base Event object
            // Event eventObject = new Event(string title, string description, string date, string time);
            // Console.WriteLine(mindObject.GetSummary());

            //Create Lectures event
            string typeOfEvent = "Lectures Event";
            Lectures lectObject = new Lectures("Understanding C#", "To lecture C#", "10th April, 2023", "10:00am EST", "Olagoke Amiola", "1000 seat capacity");
            Address addObject = new Address("Anderson Street", "Clinton", "New Jersey", "USA");
            string addressInFull = addObject.FullAddress();
            string lecturesDetails = lectObject.GenerateLectureSummary();
            Console.WriteLine(typeOfEvent);
            Console.WriteLine("----------------");
            Console.WriteLine("Marketing Messages:");
            Console.WriteLine("(1.) Standard Details");
            string standard_msg = lectObject.GenerateStandardDetails();
            Console.WriteLine(standard_msg + " " + addressInFull);
            Console.WriteLine("(2.) Full Details");
            //lectObject.GenerateStandardDetails();
            Console.WriteLine(standard_msg + " " + addressInFull + ", " + lecturesDetails);
            Console.WriteLine("(3.) Short Description");
            string short_desc = lectObject.GenerateShortDescription(typeOfEvent);
            Console.WriteLine(short_desc);

            Console.WriteLine("========================================================================================");
            Console.WriteLine("\n");



            //Create Receptions event
            string typeOfEvent2 = "Reception Event";
            Reception receptionObject = new Reception("The place of C# in digital transformation", "Didactic approach", "11th April, 2023", "11:00am EST", "eventsubscriber@gmail.com");
            Address addObject2 = new Address("Dome Street", "Bush", "Virginia", "USA");
            string addressInFull2 = addObject2.FullAddress();
            string retrievedEmail = receptionObject.GenerateRSVPSummary();
            Console.WriteLine(typeOfEvent2);
            Console.WriteLine("----------------");
            Console.WriteLine("Marketing Messages:");
            Console.WriteLine("(1.) Standard Details");
            string standard_msg2 = lectObject.GenerateStandardDetails();
            Console.WriteLine(standard_msg2 + " " + addressInFull2);
            Console.WriteLine("(2.) Full Details");
            //lectObject.GenerateStandardDetails();
            Console.WriteLine(standard_msg2 + " " + addressInFull2 + ", " + retrievedEmail);
            Console.WriteLine("(3.) Short Description");
            string short_desc2 = receptionObject.GenerateShortDescription(typeOfEvent2);
            Console.WriteLine(short_desc2);

            Console.WriteLine("========================================================================================");
            Console.WriteLine("\n");


            //Create Outdoors event
            string typeOfEvent3 = "Outdoors Event";
            Outdoors outdoorObject = new Outdoors("Funeral ceremony of Mr. Davids Smith", "Celebration of Life", "12th May, 2023", "4:00pm EST", "cool weather envisaged");
            Address addObject3 = new Address("Ariel Street", "Van dahaul", "New York", "USA");
            string addressInFull3 = addObject2.FullAddress();
            string retrievedWeatherInfo = outdoorObject.GetWeatherStatement();
            Console.WriteLine(typeOfEvent3);
            Console.WriteLine("----------------");
            Console.WriteLine("Marketing Messages:");
            Console.WriteLine("(1.) Standard Details");
            string standard_msg3 = outdoorObject.GenerateStandardDetails();
            Console.WriteLine(standard_msg3 + " " + addressInFull3);
            Console.WriteLine("(2.) Full Details");
            //lectObject.GenerateStandardDetails();
            Console.WriteLine(standard_msg3 + " " + addressInFull3 + ", " + retrievedWeatherInfo);
            Console.WriteLine("(3.) Short Description");
            string short_desc3 = outdoorObject.GenerateShortDescription(typeOfEvent3);
            Console.WriteLine(short_desc3);


        }
    }
}
