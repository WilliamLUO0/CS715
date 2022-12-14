using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelMechanism : MonoBehaviour
{
    public TextMeshProUGUI magnetEnergyValueText;
    public TextMeshProUGUI GPSFailSafeText;
    public BarController barController;
    public LevelImageController levelImageController;
    public ChangeColor changeColor;
    public int changingRate = 5;
    public bool lossAversion;

    private int magnetEnergy = 0;
    private char itemLevel = 'C';
    private double exerciseIntensityValue = 0;
    private double averageSteps = 0;
    private bool useExerciseIntensity = false;
    private bool enableGPSFailSafe = false;

    public static LevelMechanism Instance;

    void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lossAversionStrategyComputation()
    {
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
            if (magnetEnergy == 80) {
                magnetEnergy = 0;
            } else if (magnetEnergy > 0) {
                magnetEnergy = magnetEnergy - changingRate;
            }
        }

        setItemLevel();
    }

    public void lowIntensityComputation()
    {
        if (magnetEnergy == 80) {
            // when magnet energy equals to 80, but the exercise intensity is low, then set magnetEnergy back to zero
            magnetEnergy = 0;
        } else if (magnetEnergy == 50) {
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
        if (magnetEnergy == 80) {
            // when magnet energy equals to 80, but the exercise intensity is medium, then set magnetEnergy back to zero
            magnetEnergy = 0;
        } else if (magnetEnergy == 75) {
            // no energy loss or gain due to player stay in the medium exercise intensity range
        } else if (magnetEnergy > 75) {
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

    public void setItemLevel()
    {
        // set item level
        if (magnetEnergy <= 50)
        {
            itemLevel = 'C';
        } else if (50 < magnetEnergy && magnetEnergy <= 75)
        {
            itemLevel = 'B';
        } else
        {
            itemLevel = 'A';
        }
    }

    public void rewardStrategyComputation()
    {
        if (averageSteps == 0) {
            itemLevel = 'C';
            useExerciseIntensity = false;
            return;
        }

        if (exerciseIntensityValue == 0) {
            itemLevel = 'C';
            useExerciseIntensity = true;
            return;
        }

        if ((0 < exerciseIntensityValue && exerciseIntensityValue <= 2.9000D) && (0 < averageSteps && averageSteps <= 1.4)) {
            // low exercise intensity

            itemLevel = 'C';
            useExerciseIntensity = true;

        } else if (2.9000D < exerciseIntensityValue && exerciseIntensityValue <= 3.3700D) {
            // medium exercise intensity

            if (0 <= averageSteps && averageSteps <= 1.4) {
                itemLevel = 'C';
                useExerciseIntensity = false;
            } else {
                itemLevel = 'B';
                useExerciseIntensity = true;
            }

        } else if (exerciseIntensityValue > 3.3700D) {
            // high exercise intensity

            if (0 <= averageSteps && averageSteps <= 1.4) {
                itemLevel = 'C';
                useExerciseIntensity = false;
            } else if (1.4 < averageSteps && averageSteps <= 2.2) {
                itemLevel = 'B';
                useExerciseIntensity = false;
            } else {
                itemLevel = 'A';
                useExerciseIntensity = true;
            }

        } else {
            // when exercise intensity equals to zero
            itemLevel = 'C';
            useExerciseIntensity = true;
        }
    }

    /**
     * This method is used when GPS fail safe function is trigger
     * To trigger this function, click the 'FS-Disabled' text on the top left of the screen
     * 
     * The motivation for designing GPS fail safe function is because, when the GPS accuracy is very very bad,
     * then we can discard the GPS data and only the step counter read to do the experiment.
     * 
     * Luckily, during our user study experiment, we never used this function.
    */
    public void lossAversionStrategyComputationFailSafe()
    {
        useExerciseIntensity = false;
        if (averageSteps == 0) {
            if (magnetEnergy == 80) {
                magnetEnergy = 0;
            } else if (magnetEnergy > 0) {
                magnetEnergy = magnetEnergy - changingRate;
            }
        } else if (0 < averageSteps && averageSteps <= 1.4) {
            lowIntensityComputation();
        } else if (1.4 < averageSteps && averageSteps <= 2.2) {
            mediumIntensityComputation();
        } else {
            highIntensityComputation();
        }

        setItemLevel();
    }

    /**
     * This method is used when GPS fail safe function is trigger
     * To trigger this function, click the 'FS-Disabled' text on the top left of the screen
     * 
     * The motivation for designing GPS fail safe function is because, when the GPS accuracy is very very bad,
     * then we can discard the GPS data and only the step counter read to do the experiment.
     * 
     * Luckily, during our user study experiment, we never used this function.
    */
    public void rewardStrategyComputationFailSafe()
    {
        useExerciseIntensity = false;
        if (0 <= averageSteps && averageSteps <= 1.4) {
            itemLevel = 'C';
        } else if (1.4 < averageSteps && averageSteps <= 2.2) {
            itemLevel = 'B';
        } else {
            itemLevel = 'A';
        }
    }

    public void updateItemLevel(double exerciseIntensityValue, double averageSteps)
    {
        this.exerciseIntensityValue = exerciseIntensityValue;
        this.averageSteps = averageSteps;

        if (lossAversion) {
            // loss aversion
            if (!enableGPSFailSafe) lossAversionStrategyComputation();
            else lossAversionStrategyComputationFailSafe();

            barController.setBarValue((float)magnetEnergy);
        } else {
            // reward
            if (!enableGPSFailSafe) rewardStrategyComputation();
            else rewardStrategyComputationFailSafe();

            barController.setBarValue((float)exerciseIntensityValue, (float)averageSteps, useExerciseIntensity);
        }

        levelImageController.updateLevelImage(itemLevel);
        changeColor.updateGlove(itemLevel);
    }

    public char getCurrentItemLevel()
    {
        return itemLevel;
    }

    public int getMagnetEnergy()
    {
        return magnetEnergy;
    }

    public void triggerGPSFailSafe()
    {
        if (enableGPSFailSafe)
        {
            enableGPSFailSafe = false;
            GPSFailSafeText.text = "FS-Disabled";
        }
        else
        {
            enableGPSFailSafe = true;
            GPSFailSafeText.text = "FS-Enabled";
        }
    }
}
