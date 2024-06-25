using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoalTrainingData : MonoBehaviour
{
    private MainMenuGoalData mainMenuGoalData;

    [Header("TrainingPlayerData")]
    public TrainingPlayerData trainingPlayerData;
    public TextMeshProUGUI trainingType;
    public TextMeshProUGUI conditionType;
    public TextMeshProUGUI trainHours;
    public TextMeshProUGUI trainMinutes;
    private void Start()
    {
        
    }
    public void SetTrainingData()
    {
        mainMenuGoalData = FindObjectOfType<MainMenuGoalData>(true);
        trainingType.text = trainingPlayerData.trainingType;
        conditionType.text = trainingPlayerData.condition;
        if (trainingPlayerData.hours == "0")
        {
            trainHours.text = null;
            trainMinutes.text = trainingPlayerData.minutes.ToString() + " min";
        }
        else if (trainingPlayerData.minutes == "0")
        {
            trainMinutes.text = null;
            trainHours.text = trainingPlayerData.hours.ToString() + " hour";
        }
        else
        {
            trainHours.text = trainingPlayerData.hours.ToString() + "hr";
            trainMinutes.text = trainingPlayerData.minutes.ToString() + "m";
        }
        mainMenuGoalData.mainHistory.Add(trainingPlayerData);
    }
    public void SetHistory()
    {
        
    }
}
