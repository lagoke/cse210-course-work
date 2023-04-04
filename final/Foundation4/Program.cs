using System;
using System.Collections.Generic;

namespace ExerciseTracking
{


public abstract class Activity
{
	private string _date;
	private int _lengthOfActivity;
	public Activity(string date, int lengthOfActivity)
	{
		_date = date;
		_lengthOfActivity = lengthOfActivity;
	}


	public string GetDate()
	{
		return _date;
	}


	public int GetLengthOfActivity()
	{
		return _lengthOfActivity;
	}


	public abstract float GetDistance();

	public abstract float GetSpeed();

	public abstract float GetPace();

	public abstract string GetSummary();





}


public class Running: Activity
{
	private float _distanceValue;
	public Running(string date, int lengthOfActivity, float distValue)
				: base(date, lengthOfActivity)
	{
		_distanceValue = distValue;
	}



	public override float GetDistance()
    {
	
		return _distanceValue;

	}


	public override float GetSpeed()
	{
		int passedLengthActivity = GetLengthOfActivity();
		float calculatedDistance = GetDistance();
		float speedCalculated = calculatedDistance / passedLengthActivity;
		return speedCalculated;
	}

	public override float GetPace()
	{

		float passedSpeed = GetSpeed();
		float paceCalculated = 60/ passedSpeed;

		return paceCalculated;
	}



	public override string GetSummary()
	{

		return GetDate() + " Running(" + GetLengthOfActivity()  +"min" + ") -" + "Distance " + _distanceValue + "miles" + ", " + "Speed " + GetSpeed() + "mph" + ", " + "Pace: " + GetPace() + "min per mile";
	}



}





public class StationaryBicycle: Activity
{


	private float _distanceValue;
	public StationaryBicycle(string date, int lengthOfActivity, float distValue)
				: base(date, lengthOfActivity)
	{
		_distanceValue = distValue;
	}



	public override float GetDistance()
	{

		return _distanceValue;

	}


	public override float GetSpeed()
	{
		int passedLengthActivity = GetLengthOfActivity();
		float calculatedDistance = GetDistance();
		float speedCalculated = calculatedDistance / passedLengthActivity;
		return speedCalculated;
	}

	public override float GetPace()
	{

		int passedLengthActivity = GetLengthOfActivity();
		float calculatedDistance = GetDistance();

		float paceCalculated = passedLengthActivity / calculatedDistance;

		return paceCalculated;
	}



	public override string GetSummary()
	{

		return GetDate() + " StationaryBicycle(" + GetLengthOfActivity() + "min" + ") -" + "Distance " + _distanceValue + "km" + ", " + "Speed " + GetSpeed() + "kph" + ", " + "Pace: " + GetPace() + "min per km";
	}






}





public class Swimming: Activity
{
	private float _swimmingLaps;
	public Swimming(string date, int lengthOfActivity, float swimmingLaps)
				: base(date, lengthOfActivity)
	{
		_swimmingLaps = swimmingLaps;
	}



	public float GetSwimmingLaps()
	{

		return _swimmingLaps;

	}



	public override float GetDistance()
	{
		float distanceCalculated = (GetSwimmingLaps() * 50) / 1000;
		return distanceCalculated;
	}
	public override float GetSpeed()
	{
		int passedLengthActivity = GetLengthOfActivity();
		float calculatedDistance = GetDistance();
		float speedCalculated = (calculatedDistance / passedLengthActivity) * 60;
		return speedCalculated;
	}

	public override float GetPace()
	{

		float passedSpeed = GetSpeed();
		float paceCalculated = 60 / passedSpeed;

		return paceCalculated;
	}



	public override string GetSummary()
	{

		return GetDate() + " Swimming(" + GetLengthOfActivity() + "min" + ") -" + "Distance " + GetDistance() + "miles" + ", " + "Speed " + GetSpeed() + "mph" + ", " + "Pace: " + GetPace() + "min per mile";
	}


}



    class Program
    {
        static void Main(string[] args)
        {
            // Create Running activity
            // Create the object of the Running class
            Running runObject = new Running("03 Nov 2022", 30, 15);

            // Create StationaryBicycle activity
            // Create the object of the StationaryBicycle class
            StationaryBicycle sbicycleObject = new StationaryBicycle("03 Nov 2022", 50, 18);

            // Create Swimming activity
            // Create the object of the Swimming class
            Swimming swimObject = new Swimming("03 Nov 2022", 60, 10);

            List<string> _listOfActivities = new List<string>();
            _listOfActivities.Add("Running Activity");
            _listOfActivities.Add("StationaryBicycle Activity");
            _listOfActivities.Add("Swimming Activity");


             foreach (string activitysample in _listOfActivities)
            {
                
                
               
                Console.WriteLine();
             
                
            }
            Console.Write(runObject.GetSummary());
            Console.WriteLine();

            Console.Write(sbicycleObject.GetSummary());
            Console.WriteLine();

            Console.Write(swimObject.GetSummary());

        }
    }
}
