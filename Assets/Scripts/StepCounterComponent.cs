using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using PedometerU;

public class StepCounterComponent : MonoBehaviour
{
    public TextMeshProUGUI debugText;
    private Pedometer pedometer;

    // Start is called before the first frame update
    void Start()
    {
        // Create a new pedometer
        pedometer = new Pedometer(OnStep);
        // Reset UI
        OnStep(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable () {
        // Release the pedometer
        pedometer.Dispose();
        pedometer = null;
    }

    private void OnStep (int steps, double distance) {
        // Display the values, Distance in feet
        // debugText.text = "[DEBUG]: steps: " + steps.ToString() + ", distance: " + distance.ToString("F2") + " meters";
        MovementSpeedCalculator.currentStepsValue = steps;
    }

}
