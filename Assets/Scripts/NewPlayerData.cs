using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayerData : MonoBehaviour
{
    public static GameObject instanceGoal;

    [Header("GoalPlayerData")]
    public GoalPlayerData goalPlayerData;
    public Image coverGoal;
    public TextMeshProUGUI goalPlayerType;
    public List<TrainingPlayerData> trainingHistoryData;

    [Header("MainMenuGoal")]
    private MainMenuGoalData mainMenuGoalData;

    public List<GameObject> trainingInfoObj = new List<GameObject>();

    private void Start()
    {

    }
    public void SetGoalData()
    {
        coverGoal.sprite = goalPlayerData.image;
        coverGoal.SetNativeSize();
        goalPlayerType.text = goalPlayerData.goalType;

        trainingHistoryData = goalPlayerData.historyTraining;
    }

    public void ChooseGoalToMenu()
    {
        mainMenuGoalData = FindObjectOfType<MainMenuGoalData>(true);

        mainMenuGoalData.mainGoalData.image = goalPlayerData.image;
        mainMenuGoalData.mainGoalData.goalType = goalPlayerData.goalType;
        if(goalPlayerData.historyTraining != null)
        {
            mainMenuGoalData.mainGoalData.historyTraining = goalPlayerData.historyTraining;
            
        }
        instanceGoal = gameObject;
        mainMenuGoalData.SetMainData();
    }
}
