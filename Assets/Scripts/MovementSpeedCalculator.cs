using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using GoShared;

public class MovementSpeedCalculator : MonoBehaviour
{
    public TextMeshProUGUI debugText;
    public LevelMechanism levelMechanism;
    public DataOutput dataOutput;

    private double movingSpeedUsingGPS = 0;
    public static bool GPSReady = false;
    private double movingSpeedUsingSteps = 0;
    public static float latitude = 0;
    public static float longitude = 0;
    public static int currentStepsValue = 0;
    private int lastRecordedStepsValue = 0;
    private LinkedList<Coordinates> coordinateList = new LinkedList<Coordinates>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(calculateMovingSpeed());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator calculateMovingSpeed()
    {
        bool firstTimeMarked = false;
        double lastRecordedTime = 0;
        while(true)
        {
            yield return new WaitForSeconds(1);

            if (!GPSReady) continue;
            if (!firstTimeMarked)
            {
                firstTimeMarked = true;
                for (int i = 10; i > 0; i--)
                {
                    debugText.text = "Ajusting GPS Position... (" + i + ")";
                    yield return new WaitForSeconds(1);
                }
                // debugText.text = "Waiting First Speed Calculation...";
                debugText.enabled = false;
                lastRecordedTime = Time.time;
                lastRecordedStepsValue = currentStepsValue;
            }

            double timeNow = Time.time;
            int interval = (int)(timeNow - lastRecordedTime);

            coordinateList.AddFirst(new Coordinates(latitude, longitude));

            if (interval % 10 == 0 && interval != 0)
            {
                movingSpeedUsingGPS = calculateSpeedUsingGPS();
                movingSpeedUsingSteps = calculateSpeedUsingSteps();
                // debugText.text = "Average moving speed (GPS): " + movingSpeedUsingGPS + "\nAverage moving speed (steps): " + movingSpeedUsingSteps + " steps/s";
                levelMechanism.updateItemLevel(movingSpeedUsingGPS, movingSpeedUsingSteps);
                exportDataToCsv();
                coordinateList.Clear();
                lastRecordedTime = Time.time;
            }
        }
    }

    public double calculateSpeedUsingGPS()
    {
        // remove extra coordinates due to the time calculation error
        while (coordinateList.Count > 10)
        {
            coordinateList.RemoveFirst();
        }

        double totalTravelDistance = 0;
        LinkedListNode<Coordinates> nodeHead = coordinateList.First;
        while(nodeHead != null)
        {
            double latitude1 = nodeHead.Value.latitude;
            double longitude1 = nodeHead.Value.longitude;

            nodeHead = nodeHead.Next;

            double latitude2 = nodeHead.Value.latitude;
            double longitude2 = nodeHead.Value.longitude;

            double distanceTravelled = calculateDistanceBetweenCoor(latitude1, longitude1, latitude2, longitude2);
            distanceTravelled = Math.Sqrt(distanceTravelled);
            distanceTravelled *= 100000;  // convert kilometer to centimeter

            totalTravelDistance += distanceTravelled;

            nodeHead = nodeHead.Next;
        }
        double avgTravelSpeed = (double)(totalTravelDistance / 10);
        if (avgTravelSpeed != 0) avgTravelSpeed = Math.Log10(avgTravelSpeed);
        avgTravelSpeed = Math.Round(avgTravelSpeed, 4);
        // debugText.text = "average moving speed (GPS): " + avgTravelSpeed + " cm/s";
        return avgTravelSpeed;
    }

    public double calculateDistanceBetweenCoor(double latitude1, double longitude1, double latitude2, double longitude2)
    {
        // The math module contains a function named toRadians which converts from degrees to radians.
        longitude1 = toRadians(longitude1);
        longitude2 = toRadians(longitude2);
        latitude1 = toRadians(latitude1);
        latitude2 = toRadians(latitude2);
 
        // Haversine formula
        double dlon = Math.Abs(longitude2 - longitude1);
        double dlat = Math.Abs(latitude2 - latitude1);
        double a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(latitude1) * Math.Cos(latitude2) * Math.Pow(Math.Sin(dlon / 2), 2);
        double c = 2 * Math.Asin(Math.Sqrt(a));
 
        // Radius of earth in kilometers. Use 3956 for miles
        double r = 6371;
 
        // calculate the result
        return (c * r);
    }

    public double toRadians(double angleIn10thofaDegree)
    {
        // Angle in 10th of a degree
        return (angleIn10thofaDegree * Math.PI) / 180;
    }

    public double calculateSpeedUsingSteps()
    {
        int stepsDiff = currentStepsValue - lastRecordedStepsValue;
        double avgMovingSpeed = (double)((double)stepsDiff / 10D);
        // debugText.text = "average moving speed (steps): " + avgMovingSpeed + " steps/s";
        lastRecordedStepsValue = currentStepsValue;
        return avgMovingSpeed;
    }

    public void exportDataToCsv()
    {
        dataOutput.insertCsvRow(((int)Time.time - 11), movingSpeedUsingGPS, movingSpeedUsingSteps);
    }
}
