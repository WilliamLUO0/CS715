using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelMechanism : MonoBehaviour
{
    public TextMeshProUGUI magnetEnergyValueText;
    public BarController barController;
    public LevelImageController levelImageController;
    public int changingRate = 5;

    private int magnetEnergy = 0;
    private char itemLevel = 'C';
    private double exerciseIntensityValue = 0;
    private double averageSteps = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        magnetEnergyValueText.text = "Magnet energy value: " + magnetEnergy + ". Item level: " + itemLevel;
    }

    public void lossAversionStrategyComputation()
    {
        // return;   // debug only

        if ((0 < exerciseIntensityValue && exerciseIntensityValue <= 2.9000D) && (0 < averageSteps && averageSteps <= 1.4)) {
            // low exercise intensity

            lowIntensityComputation();

        } else if ((2.9000D < exerciseIntensityValue && exerciseIntensityValue <= 3.3700D) && (averageSteps != 0)) {
            // medium exercise intensity

            if (0 < averageSteps && averageSteps <= 1.4) {
                lowIntensityComputation();
            } else {
                mediumIntensityComputation();
            }

        } else if ((exerciseIntensityValue > 3.3700D) && (averageSteps != 0)) {
            // high exercise intensity

            if (0 < averageSteps && averageSteps <= 1.4) {
                lowIntensityComputation();
            } else if (1.4 < averageSteps && averageSteps <= 2.2) {
                mediumIntensityComputation();
            } else {
                highIntensityComputation();
            }

        } else {
            // when exercise intensity equals to zero
            if (magnetEnergy > 0)
                magnetEnergy = magnetEnergy - changingRate;
        }

        setItemValue();
    }

    public void lowIntensityComputation()
    {
        if (magnetEnergy == 50) {
            // no energy loss or gain due to player stay in the low exercise intensity range
        } else if (magnetEnergy > 50) {
            // reduce energy value due to low exercise intensity
            // item level drop from A/B to C
            magnetEnergy = magnetEnergy - changingRate;
        } else {
            // increase energy value
            magnetEnergy = magnetEnergy + changingRate;
        }
    }

    public void mediumIntensityComputation()
    {
        if (magnetEnergy == 74) {
            // no energy loss or gain due to player stay in the medium exercise intensity range
        } else if (magnetEnergy > 74) {
            // reduce energy value due to low exercise intensity
            // item level drop from A to B/C
            magnetEnergy = magnetEnergy - changingRate;
        } else {
            // increase energy value
            magnetEnergy = magnetEnergy + changingRate;
        }
    }

    public void highIntensityComputation()
    {
        if (magnetEnergy == 100) {
            // no energy loss due to player stay in the high exercise intensity range
        } else {
            // increase energy value
            magnetEnergy = magnetEnergy + changingRate;
        }
    }

    public void setItemValue()
    {
        // set item level
        if (magnetEnergy <= 50)
        {
            itemLevel = 'C';
        } else if (50 < magnetEnergy && magnetEnergy <= 74)
        {
            itemLevel = 'B';
        } else
        {
            itemLevel = 'A';
        }
    }

    public void rewardStrategyComputation()
    {
        if ((0 < exerciseIntensityValue && exerciseIntensityValue <= 2.9000D) && (0 < averageSteps && averageSteps <= 1.4)) {
            // low exercise intensity

            itemLevel = 'C';

        } else if (2.9000D < exerciseIntensityValue && exerciseIntensityValue <= 3.3700D) {
            // medium exercise intensity

            if (0 < averageSteps && averageSteps <= 1.4) {
                itemLevel = 'C';
            } else {
                itemLevel = 'B';
            }

        } else if (exerciseIntensityValue > 3.3700D) {
            // high exercise intensity

            if (0 < averageSteps && averageSteps <= 1.4) {
                itemLevel = 'C';
            } else if (1.4 < averageSteps && averageSteps <= 2.2) {
                itemLevel = 'B';
            } else {
                itemLevel = 'A';
            }

        } else {
            // when exercise intensity equals to zero
            itemLevel = 'C';
        }
    }

    public void updateItemLevel(double exerciseIntensityValue, double averageSteps)
    {
        this.exerciseIntensityValue = exerciseIntensityValue;
        this.averageSteps = averageSteps;

        // loss aversion
        lossAversionStrategyComputation();
        barController.setBarValue((float)magnetEnergy);
        
        // reward
        // rewardStrategyComputation();
        // barController.setBarValue((float)exerciseIntensityValue);


        levelImageController.updateLevelImage(itemLevel);
    }

    public char getCurrentItemLevel()
    {
        return itemLevel;
    }
}
