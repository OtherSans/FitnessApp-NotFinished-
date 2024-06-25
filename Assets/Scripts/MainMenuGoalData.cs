using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;
public class MainMenuGoalData : MonoBehaviour
{
    public GoalPlayerData mainGoalData;
    [SerializeField] private Image mainImage;
    [SerializeField] private TextMeshProUGUI mainGoalType;

    public List<TrainingPlayerData> mainHistory = new List<TrainingPlayerData>();

    public GameObject goal;
    public Transform trainingPos;
    private void Update()
    {
        goal = NewPlayerData.instanceGoal;
    }
    public void SetMainData()
    {
        mainImage.sprite = mainGoalData.image;
        mainImage.SetNativeSize();
        mainGoalType.text = mainGoalData.goalType;

        mainGoalData.historyTraining = mainHistory;
        //mainHistory = mainGoalData.historyTraining;
        
        //foreach(var training in goal.GetComponent<NewPlayerData>().trainingInfoObj)
        //{

        //    Instantiate(training, trainingPos);
        //}
        
    }
}
