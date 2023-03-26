// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation4 World!");
//     }
// }

using System;
using System.Collections.Generic;



public abstract class Activity
{
	public Activity()
	{
	}


	private string _date;
	private int _lengthOfActivity;




	public abstract string GetSummary();




}


public class Running: Activity
{
	public Running()
	{
	}




	private string _distance;



	public string GetDistance()
	{
		return _distance;
	}


	public string SetDistance()
	{
		return _distance;
	}



	public override string GetSummary()
	{

		return _distance;
	}








}

public class StationaryBicycle: Activity
{
	public StationaryBicycle()
	{
	}




	private string _speed;



	public string GetSpeed()
	{
		return _speed;
	}


	public string SetSpeed()
	{
		return _speed;
	}



	public override string GetSummary()
	{

		return _speed;
	}

}

public class Swimming: Activity
{
	public Swimming()
	{
	}


	private string _pace;



	public string GetPace()
	{
		return _pace;
	}


	public string SetPace()
	{
		return _pace;
	}



	public override string GetSummary()
	{

		return _pace;
	}





}
